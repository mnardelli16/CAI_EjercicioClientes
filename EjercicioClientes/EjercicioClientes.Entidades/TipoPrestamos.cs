using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades
{
    public class TipoPrestamos
    {
        public double Tna { get; set; }
        public string Linea { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return string.Format("{0}-{1}", this.Tna,this.Linea);
        }
    }
}
