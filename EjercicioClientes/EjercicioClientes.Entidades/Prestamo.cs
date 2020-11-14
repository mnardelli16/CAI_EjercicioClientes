using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades
{
    public class Prestamo
    {
        private string _linea;
        private double _tna;
        private int _plazo;
        private double _monto;
        private string _usuario;
        private int _id;
        private int _idCliente;

        private double _cuotaCapital;
        private double _cuotaInteres;
        private double _cuota;

        public string Linea
        {
            get { return this._linea; }
            set { this._linea = value; }
        }

        public double Tna { get => this._tna; set => this._tna = value; }

        public int Plazo { get => this._plazo; set => this._plazo = value; }

        public double Monto { get => this._monto; set => this._monto = value; }

        public string Usuario { get => this._usuario; set => this._usuario = value; }

        public int Id { get => this._id; set => this._id = value; }

        public int IdCliente { get => this._idCliente; set => this._idCliente = value; }

        public double Cuota { get => this._cuota; set => this._cuota = value; }

        public Prestamo(double tna, string linea, int plazo, int idcliente, double monto, double cuotatotal)
        {
            this._tna = tna;
            this._linea = linea;
            this._plazo = plazo;
            this._idCliente = idcliente;
            this._monto = monto;
            this._cuotaCapital = Math.Round(monto / plazo, 2);
            this._cuotaInteres = Math.Round((_cuotaCapital * (tna / 12 / 100)), 2);
            this._cuota = cuotatotal;
        }

        public override string ToString()
        {
            return string.Format("ID: {0} - TNA: {1} - LINEA: {2} - PLAZO: {3}", this.Id, this._tna, this._linea, this._plazo);
        }
    }
}
