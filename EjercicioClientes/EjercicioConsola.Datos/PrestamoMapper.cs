using Newtonsoft.Json;
using EjercicioClientes.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConsola.Datos
{
    public class PrestamoMapper
    {
        string reg = ConfigurationManager.AppSettings["Legajo"];
        public List<Prestamo> TraerTodosLosPrestamos()
        {
            string json = WebHelper.Get("/prestamo/" + Convert.ToInt32(reg));
            List<Prestamo> res = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return res;
        }

        public TransactionResult InsertarPrestamo(Prestamo P)
        {
            NameValueCollection obj = ReverseMap(P);

            string result = WebHelper.Post("/prestamo", obj);

            TransactionResult resultado = MapResultado(result);

            return resultado;

        }

        public NameValueCollection ReverseMap(Prestamo P)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("TNA", P.Tna.ToString());
            n.Add("Linea", P.Linea);
            n.Add("Plazo", P.Plazo.ToString());
            n.Add("idCliente", P.IdCliente.ToString());
            n.Add("Monto", P.Monto.ToString());
            n.Add("Cuota", P.Cuota.ToString());
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);

            return n;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
