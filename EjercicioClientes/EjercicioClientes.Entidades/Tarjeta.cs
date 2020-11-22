using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades
{
    public class Tarjeta
    {
        private int _tipo;
        private int _periododevencimiento;
        private double _limitedecompra;
        private string _nroplastico;
        private string _usuario;
        private int _idCliente;

        public int Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }
        public int PeridoDeVencimiento
        {
            get { return this._periododevencimiento; }
            set { this._periododevencimiento = value; }
        }
        public double LimiteCompra
        {
            get { return this._limitedecompra; }
            set { this._limitedecompra = value; }
        }
        public string NroPlastico
        {
            get { return this._nroplastico; }
            set { this._nroplastico = value; }
        }
        public string Usuario
        {
            get { return this._usuario; }
            set { this._usuario = value; }
        }
        public int IdCliente
        {
            get { return this._idCliente; }
            set { this._idCliente = value; }
        }

        public Tarjeta(int idcliente, string usuario, int tipo, int peridovencimiento, double limite, string nroplastico )
        {
            this._idCliente = idcliente;
            this._usuario = usuario;
            this._tipo = tipo;
            this._periododevencimiento = peridovencimiento;
            this._limitedecompra = limite;
            this._nroplastico = nroplastico;
        }


        public enum TipoTarjeta
        {
            Visa = 1,
            MasterCard = 2,
            American = 3
        }

        public enum Vencimientos
        {
            Primera_Semana = 1,
            Segunda_Semana = 2,
            Tercera_Semana = 3,
            Cuarta_Semana = 4
        }
    }
}
