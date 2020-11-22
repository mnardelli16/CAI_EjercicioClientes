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
        internal List<Cuenta> _lstCuentas;
        ClienteServicio clienteServicio;
        public CuentaServicio()
        {
            mapper = new CuentaMapper();
            _lstCuentas = new List<Cuenta>();
            clienteServicio = new ClienteServicio();
        }

        public List<Cuenta> ListarTodas()
        {
            List<Cuenta> aux = mapper.TraerTodasLasCuentas();
            List<Cuenta> listado = new List<Cuenta>();

            foreach (Cuenta Cue in aux)
            {
                foreach(Cliente C in clienteServicio._lstClientes) // TRAIGO SOLO LAS CUENTAS DE MIS CLIENTES
                {
                    if(C.Id == Cue.IdCliente)
                    {
                        listado.Add(Cue);
                    }
                }
            }

            return listado;
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

        public void AgregarSaldo(int idcuenta, float saldonuevo, float acreditacion)
        {
            Cuenta C = new Cuenta();
            C.Id = idcuenta;
            C.Saldo = saldonuevo;

            TransactionResult resultado = mapper.Update(C);

            if (!resultado.IsOk)
            {
                throw new Exception("Hubo un error en la petición al servidor.Detalle: " + resultado.Error);
            }

            Utilidades U = new Utilidades(idcuenta, C.Saldo, acreditacion);

            TransactionResult enviomail = mapper.EnviarEmail(U);

            if (!enviomail.IsOk)
            {
                throw new Exception("Hubo un error en la petición al servidor.Detalle: " + resultado.Error);
            }

        }

        public Cuenta ListarCuentaPorIDCliente(int idCliente)
        {
            Cuenta C = mapper.TraerCuentaPorID(idCliente);
            return C;
        }

    }
}
