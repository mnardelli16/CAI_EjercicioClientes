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
        private TipoPrestamoMapper _mapper;

        public TipoPrestamosServicio()
        {
            _mapper = new TipoPrestamoMapper();
        }


        public List<TipoPrestamos> TrerTipodePrestamos()
        {
            return _mapper.TraerTiposdePrestamos();
        }
    }
}
