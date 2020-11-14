using EjercicioConsola.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClientes.Entidades;

namespace EjercicioClientes.Negocio
{
    public class ClienteServicio
    {
        private ClienteMapper mapper;
        internal List<Cliente> _lstClientes;
        public ClienteServicio()
        {
            mapper = new ClienteMapper();
            _lstClientes = TraerClientes();
        }

        public List<Cliente> TraerClientes()  
        {
            _lstClientes = mapper.TraerTodos(); // yo aca podria hacer algun tipo de filtro en lugar de traer todos los clientes
                                                        // estariamos duplicando el metodo en este sentido
            return _lstClientes;
        }


        public int InsertarCliente(Cliente cli)
        {
            List<Cliente> result = mapper.TraerTodos();

            foreach(Cliente C in result) // valida el negocio que no este ya cargado
            {
                if(cli.Dni == C.Dni)
                {
                    throw new Exception("El cliente ya existe");
                }
            }

            TransactionResult resultado = mapper.Insert(cli);

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
