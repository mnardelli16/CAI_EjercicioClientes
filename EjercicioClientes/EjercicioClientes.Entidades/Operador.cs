using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades
{
    public class Operador
    {

        private List<Prestamo> _lstPrestamos;
        private double _comision;
        private double _porcentajeComision;

        public List<Prestamo> ListaPrestamos
        {
            get { return this._lstPrestamos; }
            set { this._lstPrestamos = value; }
        }

        public double Comision
        {
            get { return this._comision; }
            set { this._comision = value; }
        }

        public double PorcentajeComision
        {
            get { return this._porcentajeComision; }
        }

        public Operador(List<Prestamo> lista)
        {
            _lstPrestamos = lista;
            _porcentajeComision = 0.15;
            _comision = CalcularComsion();
        }

        private double CalcularComsion()
        {
            double totalcomis = 0;

            foreach(Prestamo P in _lstPrestamos)
            {
                totalcomis += P.CuotaInteres * P.Plazo * 0.15;
            }

            return totalcomis;
        }

        public override string ToString()
        {
            return string.Format("{0}",this._lstPrestamos);
        }
    }
}
