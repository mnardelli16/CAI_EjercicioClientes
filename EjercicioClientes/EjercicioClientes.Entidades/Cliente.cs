using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades
{
    [DataContract]
    public class Cliente
    {
        private int _dni;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _email;
        private string _telefono;
        private DateTime _fechaNacimiento;
        private DateTime _fechaAlta;
        private bool _activo;
        private int _id;

        [DataMember]
        public int Dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }
        [DataMember]
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        [DataMember]
        public string Apellido { get => _apellido; set => _apellido = value; }

        [DataMember]
        public string Direccion { get => _direccion; set => _direccion = value; }

        [DataMember]
        public string Email { get => _email; set => _email = value; }

        [DataMember]
        public string Telefono { get => _telefono; set => _telefono = value; }

        [DataMember]
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        [DataMember]
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        [DataMember]
        public int Id { get => _id; set => _id = value; }

        [DataMember]
        public bool Activo { get => _activo; set => _activo = value; }
        public override string ToString()
        {
            return string.Format("Cliente - {0} {1} {2}",this._id,this._apellido,this._nombre);     
        }

        public Cliente(int dni, string nombre, string apellido, string direccion, string email, string telefono, string fechanac, bool activo)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._apellido = apellido;
            this._direccion = direccion;
            this._email = email;
            this._telefono = telefono;
            this._fechaNacimiento = Convert.ToDateTime(fechanac);
            this._activo = activo;
            this._id = 1;
        }
    }
}
