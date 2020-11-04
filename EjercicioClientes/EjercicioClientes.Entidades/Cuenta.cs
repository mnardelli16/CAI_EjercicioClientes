using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades
{
    [DataContract]
    public class Cuenta
    {
        private int _nrocuenta;
        private string _descripcion;
        private float _saldo;
        private DateTime _fechaApertura;
        private DateTime _fechaModificacion;
        private bool _activo;
        private int _idCliente;
        private int _id;

        [DataMember]
        public int NroCuenta { get => _nrocuenta; set => _nrocuenta = value; }
        [DataMember]
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        [DataMember]
        public float Saldo { get => _saldo; set => _saldo = value; }
        [DataMember]
        public DateTime FechaApertura { get => _fechaApertura; set => _fechaApertura = value; }
        [DataMember]
        public DateTime FechaModificacion { get => _fechaModificacion; set => _fechaModificacion = value; }
        [DataMember]
        public bool Activo { get => _activo; set => _activo = value; }
        [DataMember]
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        [DataMember]
        public int Id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return string.Format("ID: {0} - ID_CLIENTE: {1} - NRO_CUENTA: {2} - DESCRIPCION: {3} - SALDO: ${4} - FECHA_APERTURA {5}", this._id, this._idCliente, this._nrocuenta, this._descripcion, this._saldo, this._fechaApertura);
        }

        public Cuenta(int nrocuenta, float saldo, string descripcion, string FechaApertura, bool activo, int IdCliente, int id)
        {
            this._nrocuenta = nrocuenta;
            this._saldo = saldo;
            this._descripcion = descripcion;
            this._fechaApertura = Convert.ToDateTime(FechaApertura);
            this._fechaModificacion = DateTime.Now;
            this._activo = activo;
            this._idCliente = IdCliente;
            this._id = id;
        }


    }
}
