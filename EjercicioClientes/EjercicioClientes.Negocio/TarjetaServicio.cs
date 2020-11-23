using EjercicioClientes.Entidades;
using EjercicioConsola.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EjercicioClientes.Entidades.Tarjeta;

namespace EjercicioClientes.Negocio
{
    public class TarjetaServicio
    {
        TarjetaMapper _mapper;
        CuentaServicio _cuentaServicio;

        public TarjetaServicio()
        {
            _mapper = new TarjetaMapper();
            _cuentaServicio = new CuentaServicio();
        }


        public List<Tarjeta> TraerTodasLasTarjetas()
        {
            List<Tarjeta> aux = _mapper.TraerTarjetas();

            return aux;
        }

        public List<Tarjeta> TraerTarjetadeunCliente(int idcliente)
        {
            return _mapper.TraerTarjetasDeUnCliente(idcliente);
        }

        public int DarDeAltaTarjeta(int idcliente, int tipo, int peridovencimiento, double limite)
        {

            // VALIDACIONES DEL NEGOCIO

            // QUE TENGA CUENTA
            Cuenta C = _cuentaServicio.ListarCuentaPorIDCliente(idcliente);

            if (C is null)
            {
                throw new Exception("El cliente debe tener una cuenta antes de tener una tarjeta");
            }

            // LIMITE DE COMPRA

            if((C.Saldo * 18) < limite)
            {
                throw new Exception("Limite exedido, no puede ser mayor a 18 veces su saldo");
            }

            List<Tarjeta> lsttarcliente = _mapper.TraerTarjetasDeUnCliente(idcliente);

            //SI EL CLIENTE YA TIENE UN TARJETA DEL MISMO TIPO NO PUEDE

            foreach(Tarjeta D  in lsttarcliente)
            {
                if(tipo == Convert.ToInt32(TipoTarjeta.Visa) && tipo == D.Tipo)
                {
                    throw new Exception("El cliente ya tiene una tarjeta Visa");
                }
                if (tipo == Convert.ToInt32(TipoTarjeta.MasterCard) && tipo == D.Tipo)
                {
                    throw new Exception("El cliente ya tiene una tarjeta MasterCard");
                }
                if (tipo == Convert.ToInt32(TipoTarjeta.American) && tipo == D.Tipo)
                {
                    throw new Exception("El cliente ya tiene una tarjeta American");
                }
            }

            List<Tarjeta> lstTarjeta = _mapper.TraerTarjetas();

            int ultimoplastico = 0;

            foreach(Tarjeta A in lstTarjeta)
            {
                if(tipo == A.Tipo)
                {
                    if(Convert.ToInt32(A.NroPlastico.Substring(14)) >= ultimoplastico)
                    {
                        ultimoplastico = Convert.ToInt32(A.NroPlastico.Substring(14));
                    }
                }
            }

            string nroplastico = GenerarNumeroPlastico(tipo, ultimoplastico);


            Tarjeta T = new Tarjeta(tipo, peridovencimiento, limite, nroplastico,idcliente);


            TransactionResult resultado = _mapper.InsertarTarjeta(T);

            if (!resultado.IsOk)
            {
                throw new Exception("Hubo un error en la petición al servidor.Detalle: " + resultado.Error);
            }
            else
            {
                return resultado.Id;
            }

        }

        private string GenerarNumeroPlastico(int tipotarjeta, int ultimatarjeta)
        {
            long num = 0;

            if (tipotarjeta == Convert.ToInt32(TipoTarjeta.Visa)) // 16 digitos
            {
                num = 6500000010000000 + ultimatarjeta + 1;
            }
            if (tipotarjeta == Convert.ToInt32(TipoTarjeta.MasterCard)) // 16 digitos
            {
                num = 7800000010000000 + ultimatarjeta + 1;
            }
            if (tipotarjeta == Convert.ToInt32(TipoTarjeta.American)) // 15 digitos
            {
                num = 990000001000000 + ultimatarjeta + 1;
            }

            return num.ToString();

        }



    }
}
