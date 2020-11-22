using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades
{
    public class Utilidades
    {

        string _email;
        string _asunto;
        string _mensaje;

        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        public string Asunto
        {
            get { return this._asunto; }
            set { this._asunto = value; }
        }
        public string Mensaje
        {
            get { return this._mensaje; }
            set { this._mensaje = value; }
        }

        public Utilidades(int idcliente, double saldonuevo, double acreditacion)
        {
            this._email = "cai." + idcliente.ToString() + "@yopmail.com";
            this._asunto = "Modificacion de saldo - Cuenta N° " + idcliente.ToString();
            this._mensaje = "Buenos dias, ha recibido una acreditacion de $" + acreditacion.ToString() + Environment.NewLine +
                            "Su nuevo saldo es de $" + saldonuevo.ToString();
        }

    }
}
