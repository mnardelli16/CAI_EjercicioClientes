using EjercicioClientes.Entidades;
using EjercicioClientes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClientes.Formularios
{
    public partial class frmTarjetas : Form
    {
        TarjetaServicio _tarjetaServicio;
        ClienteServicio _clienteServicio;
        public frmTarjetas()
        {
            InitializeComponent();
            _tarjetaServicio = new TarjetaServicio();
            _clienteServicio = new ClienteServicio();
            CargarClientes();
            CargarTiposTarjetas();
            CargarVencimientos();
        }

        private void CargarVencimientos()
        {
            cbxPeriodoVencimiento.Items.Add("Primera_Semana");
            cbxPeriodoVencimiento.Items.Add("Segunda_Semana");
            cbxPeriodoVencimiento.Items.Add("Tercera_Semana");
            cbxPeriodoVencimiento.Items.Add("Cuarta_Semana");

        }

        private void CargarTiposTarjetas()
        {
            cbxTipoTarjeta.Items.Add("Visa");
            cbxTipoTarjeta.Items.Add("MasterCard");
            cbxTipoTarjeta.Items.Add("American");

        }

        private void CargarClientes()
        {
            List<Cliente> lst = _clienteServicio.TraerClientes();

            foreach(Cliente C in lst)
            {
                cbxCliente.Items.Add(C.Id + " - " + C.Nombre + " - " + C.Apellido);
            }

        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnAltaTarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbxCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un cliente");
                }

                else if(cbxTipoTarjeta.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo de tarjeta");
                }
                else if (cbxPeriodoVencimiento.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un vencimiento");
                }
                else
                {
                    var obj = cbxCliente.SelectedItem;

                    string[] vector = obj.ToString().Split('-');

                    int idcliente = Convert.ToInt32(vector[0]);


                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
