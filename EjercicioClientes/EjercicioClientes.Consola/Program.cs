using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClientes.Negocio;
using EjercicioClientes.Entidades;

namespace EjercicioClientes.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ClienteServicio servicio = new ClienteServicio(); // new a la capa de negocios, como presentismo, tiendaropa (nuestros manejadores)

                List<Cliente> lst = servicio.TraerClientes();

                foreach(Cliente c in lst)
                {
                    Console.WriteLine(c.ToString());
                }





                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
