using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioClientes.Entidades;
using EjercicioClientes.Negocio;

namespace EjercicioClientes.Formularios
{
    public partial class FrmAgregar : Form
    {
        private ClienteServicio _clienteServicio;
        public FrmAgregar()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                string _STRdni = txtDni.Text;
                int _dni = 0;
                string _nombre = txtNombre.Text;
                string _apellido = txtApellido.Text;
                string _direccion = txtDireccion.Text;
                string _email = txtEmail.Text;
                string _telefono = txtTelefono.Text;
                string _STRfechaNacimiento = dateFecha.Text;
                bool _activo = false;

                if (checkActivo.Checked)
                {
                    _activo = true;
                }

                string msj = "";

                msj += Validaciones.ValidarNumero(_STRdni, "Dni", ref _dni);
                msj += Validaciones.ValidarSTRING(_nombre, "Nombre");
                msj += Validaciones.ValidarSTRING(_apellido, "Apellido");
                msj += Validaciones.ValidarSTRING(_direccion, "Direccion");
                msj += Validaciones.ValidarSTRING(_email, "Email");
                msj += Validaciones.ValidarSTRING(_telefono, "Telefono");

                if (!string.IsNullOrWhiteSpace(msj))
                {
                    MessageBox.Show(msj, "ERRORES");
                }
                else
                {
                    Cliente C = new Cliente(_dni, _nombre, _apellido, _direccion, _email, _telefono, _STRfechaNacimiento, _activo);

                    int salida = _clienteServicio.InsertarCliente(C);

                    MessageBox.Show("Cliente Agregado con exito ID: " + salida , "Mensaje del sistema");
                    LimpiarBotones();

                }
            }
            catch(Exception xe)
            {
                MessageBox.Show(xe.Message);
                LimpiarBotones();
            }

        }

        private void LimpiarBotones()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            checkActivo.Checked = false;
        }
    }
}
