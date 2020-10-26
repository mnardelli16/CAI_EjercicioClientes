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
            NameValueCollection obj = ReverseMap(C);

            string result = WebHelper.Post("/cuenta", obj);

            TransactionResult resultado = MapResultado(result);

            return resultado;
        }

        private NameValueCollection ReverseMap(Cuenta C)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("NroCuenta", C.NroCuenta.ToString());
            n.Add("Descripcion", C.Descripcion);
            n.Add("Saldo", C.Saldo.ToString());
            //n.Add("FechaApertura", C.FechaApertura.ToShortDateString());
            //n.Add("FechaModificacion", C.FechaModificacion.ToShortDateString());
            n.Add("Activo", C.Activo.ToString());
            n.Add("IdCliente", C.IdCliente.ToString());
            //n.Add("Id", C.Id.ToString());

            return n;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }

        public Cuenta TraerCuentaPorID(int id)
        {
            string json = WebHelper.Get("/cuenta/" + id );
            Cuenta result = JsonConvert.DeserializeObject<Cuenta>(json); // HACE EL MAPLIST
            return result;
        }
    }
}
