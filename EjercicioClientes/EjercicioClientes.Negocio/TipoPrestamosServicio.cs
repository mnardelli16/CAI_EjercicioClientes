using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClientes.Entidades;
using EjercicioConsola.Datos;

namespace EjercicioClientes.Negocio
{
    public class TipoPrestamosServicio
    {

        public List<TipoPrestamos> TrerTipodePrestamos()
        {
            return TipoPrestamoMapper.TraerTiposdePrestamos();
        }
    }
}
