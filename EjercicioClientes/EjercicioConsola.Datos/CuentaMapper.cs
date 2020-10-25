using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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



    }
}
