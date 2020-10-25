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

        public List<Cliente> TraerTodos() // trae a todos los clientes que estane en el GET
        {
            string json2 = WebHelper.Get("/cliente");
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
            n.Add("Usuario", "MAXI");

            return n;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
