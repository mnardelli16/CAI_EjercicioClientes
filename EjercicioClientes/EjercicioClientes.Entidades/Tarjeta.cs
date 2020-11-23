using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades
{
    [DataContract]
    public class Tarjeta
    {
        private int _tipo;
        private int _periodovencimiento;
        private double _limitedecompra;
        private string _nroplastico;
        private string _usuario;
        private int _idCliente;

        [DataMember]
        public int Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }
        [DataMember]
        public int PeriodoVencimiento
        {
            get { return this._periodovencimiento; }
            set { this._periodovencimiento = value; }
        }
        [DataMember]
        public double LimiteCompra
        {
            get { return this._limitedecompra; }
            set { this._limitedecompra = value; }
        }
        [DataMember]
        public string NroPlastico
        {
            get { return this._nroplastico; }
            set { this._nroplastico = value; }
        }
        [DataMember]
        public string Usuario
        {
            get { return this._usuario; }
            set { this._usuario = value; }
        }
        [DataMember]
        public int IdCliente
        {
            get { return this._idCliente; }
            set { this._idCliente = value; }
        }

        public Tarjeta(int tipo, int peridovencimiento, double limite, string nroplastico, int idcliente)
        {
            this._tipo = tipo;
            this._periodovencimiento = peridovencimiento;
            this._limitedecompra = limite;
            this._nroplastico = nroplastico;
            this._usuario = ConfigurationManager.AppSettings["Legajo"].ToLower().ToString();
            this._idCliente = idcliente;
        }

        public override string ToString()
        {
            return string.Format("TIPO: {0} - PERIDO VENC: {1} - LIMITE: {2} - NUMERO: {3}", ResolverTipo(this._tipo), ResolverPeriodo(this._periodovencimiento), this._limitedecompra, this._nroplastico);
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

        public string ResolverTipo(int t)
        {
            string tipo ="";
            if(t == Convert.ToInt32(TipoTarjeta.Visa))
            {
                tipo = "Visa";
            }
            if (t == Convert.ToInt32(TipoTarjeta.MasterCard))
            {
                tipo = "MasterCard";
            }
            if (t == Convert.ToInt32(TipoTarjeta.American))
            {
                tipo = "American";
            }
            return tipo;

        }

        public string ResolverPeriodo(int t)
        {
            string tipo = "";

            if (t == Convert.ToInt32(Vencimientos.Primera_Semana))
            {
                tipo = "Primera Semana";
            }
            if (t == Convert.ToInt32(Vencimientos.Segunda_Semana))
            {
                tipo = "Segunda Semana";
            }
            if (t == Convert.ToInt32(Vencimientos.Tercera_Semana))
            {
                tipo = "Tercera Semana";
            }
            if (t == Convert.ToInt32(Vencimientos.Cuarta_Semana))
            {
                tipo = "Cuarta Semana";
            }
            return tipo;

        }
    }
}
