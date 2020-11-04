using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
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

        public int InsertarCuenta(Cuenta C)
        {
            TransactionResult resultado = mapper.Insertar(C);

            if (!resultado.IsOk)
            {
                throw new Exception("Hubo un error en la petición al servidor.Detalle: " + resultado.Error);
            }
            else
            {
                return resultado.Id;
            }
        }

        public void AgregarSaldo(Cuenta C)
        {
            TransactionResult resultado = mapper.Update(C);

            if (!resultado.IsOk)
            {
                throw new Exception("Hubo un error en la petición al servidor.Detalle: " + resultado.Error);
            }

        }

        public Cuenta ListarCuentaPorID(int id)
        {
            Cuenta C = mapper.TraerCuentaPorID(id);
            return C;
        }

    }
}
