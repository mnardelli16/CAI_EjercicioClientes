using EjercicioClientes.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace EjercicioConsola.Datos
{ 
    public class TarjetaMapper
    {
        string reg = ConfigurationManager.AppSettings["Legajo"];

        public List<Tarjeta> TraerTarjetas()
        {
            string json = WebHelper.Get("/tarjetacredito/" + reg.ToString());
            List<Tarjeta> resultado = JsonConvert.DeserializeObject<List<Tarjeta>>(json);
            return resultado;
        }

        public List<Tarjeta> TraerTarjetasDeUnCliente(int idcliente)
        {
            string json = WebHelper.Get("/tarjetacredito/" + reg.ToString() + "/" + idcliente) ;
            List<Tarjeta> resultado = JsonConvert.DeserializeObject<List<Tarjeta>>(json);
            return resultado;
        }

        public TransactionResult InsertarTarjeta(Tarjeta T)
        {
            NameValueCollection obj = ReverseMap(T);

            string result = WebHelper.Post("/tarjetacredito", obj);

            TransactionResult res = MapResultado(result);

            return res;

        } 

        private NameValueCollection ReverseMap(Tarjeta T)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("Tipo", T.Tipo.ToString());
            n.Add("PeriodoVencimiento", T.PeriodoVencimiento.ToString());
            n.Add("LimiteCompra", T.LimiteCompra.ToString());
            n.Add("NroPlastico", T.NroPlastico.ToString());
            n.Add("Usuario", T.Usuario.ToString());
            n.Add("idCliente", T.IdCliente.ToString());
            return n;

        }

        public TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }



    }
}
