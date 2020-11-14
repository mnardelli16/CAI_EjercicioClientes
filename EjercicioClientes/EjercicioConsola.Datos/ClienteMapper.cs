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
    public class ClienteMapper // MAPEADORES DE LOS SERVICIOS QUE NECESITAMOS
    {
        string reg = ConfigurationManager.AppSettings["Legajo"];
        public List<Cliente> TraerTodos() // trae a todos los clientes donde el usuario registro soy yo
        {
            string json2 = WebHelper.Get("/cliente/" + Convert.ToInt32(reg));
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }


        private List<Cliente> MapList(string json) // MAPEO DE STRING DE LA WEB A UNA LISTA DE CLIENTES
        {
            List<Cliente> lista = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lista;
        }

        public TransactionResult Insert(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);              // serializo y transformo en un diccionario

            string result = WebHelper.Post("/cliente", obj);

            TransactionResult resultTransaccion = MapResultado(result);

            return resultTransaccion;
        }

        private NameValueCollection ReverseMap(Cliente C)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Dni", C.Dni.ToString());
            n.Add("Nombre", C.Nombre);
            n.Add("Apellido", C.Apellido);
            n.Add("Direccion", C.Direccion);
            n.Add("Email", C.Email);
            n.Add("Telefono", C.Telefono);
            n.Add("FechaNacimiento", C.FechaNacimiento.ToShortDateString());
            n.Add("FechaAlta", C.FechaAlta.ToShortDateString());
            n.Add("Activo", C.Activo.ToString());
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
