using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClientes.Entidades;
using EjercicioConsola.Datos;

namespace EjercicioClientes.Negocio
{
    public class CuentaServicio
    {
        private CuentaMapper mapper;

        public CuentaServicio()
        {
            mapper = new CuentaMapper();
        }

        public List<Cuenta> ListarTodas()
        {
            List<Cuenta> lst = mapper.TraerTodasLasCuentas();
            return lst;
        }



    }
}
