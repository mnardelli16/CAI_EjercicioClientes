using EjercicioClientes.Entidades;
using EjercicioConsola.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Negocio
{
    public class PrestamoServicio
    {
        PrestamoMapper _mapper;

        public PrestamoServicio()
        {
            _mapper = new PrestamoMapper();
        }

        public Operador TraertodoslosPrestamos()
        {
            List<Prestamo> aux = new List<Prestamo>();

            foreach (Prestamo P in _mapper.TraerTodosLosPrestamos())
            {
                aux.Add(P);
            }

            Operador B = new Operador(aux);

            return B;
        }

        public int InsertarPrestamo(Prestamo P)
        {
            TransactionResult resultado = _mapper.InsertarPrestamo(P);

            if (!resultado.IsOk)
            {
                throw new Exception("Hubo un error en la petición al servidor.Detalle: " + resultado.Error);
            }
            else
            {
                return resultado.Id;
            }
        }

    }
}
