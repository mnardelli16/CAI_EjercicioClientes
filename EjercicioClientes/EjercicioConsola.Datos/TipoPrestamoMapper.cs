using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClientes.Entidades;
using Newtonsoft.Json;

namespace EjercicioConsola.Datos
{
    public static class TipoPrestamoMapper
    { 
        public static List<TipoPrestamos> TraerTiposdePrestamos()
        {
            string json = WebHelper.Get("/prestamotipo");
            List<TipoPrestamos> resul = JsonConvert.DeserializeObject<List<TipoPrestamos>>(json);
            return resul;
        }


    }
}
