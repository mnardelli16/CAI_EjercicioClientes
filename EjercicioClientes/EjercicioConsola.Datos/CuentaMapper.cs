using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using EjercicioClientes.Entidades;
using Newtonsoft.Json;

namespace EjercicioConsola.Datos
{
    public class CuentaMapper
    {
        public List<Cuenta> TraerTodasLasCuentas()
        {
            string json = WebHelper.Get("/cuenta");
            List<Cuenta> result = JsonConvert.DeserializeObject<List<Cuenta>>(json); // HACE EL MAPLIST
            return result;
        }

        public TransactionResult Insertar(Cuenta C)
        {
            NameValueCollection obj = ReverseMap(C, "INSERT");

            string result = WebHelper.Post("/cuenta", obj);

            TransactionResult resultado = MapResultado(result);

            return resultado;
        }

        public TransactionResult Update(Cuenta C)
        {
            NameValueCollection obj = ReverseMap(C, "UPDATE");

            string result = WebHelper.Post("/cuenta", obj);

            TransactionResult resultado = MapResultado(result);

            return resultado;
        }
        private NameValueCollection ReverseMap(Cuenta C, string tipo)
        {
            NameValueCollection n = new NameValueCollection();

            if(tipo == "INSERT")
            {
                n.Add("IdCliente", C.IdCliente.ToString());
                n.Add("Descripcion", C.Descripcion);
                n.Add("Activo", C.Activo.ToString());

            }
            else if(tipo == "UPDATE")
            {
                n.Add("id", C.Id.ToString());
                n.Add("Saldo", C.Saldo.ToString());
            }

            return n;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }

        public Cuenta TraerCuentaPorID(int idCliente)
        {
            string json = WebHelper.Get("/cuenta/" + idCliente.ToString() );
            Cuenta result = JsonConvert.DeserializeObject<Cuenta>(json); // HACE EL MAPLIST
            return result;
        }
    }
}
