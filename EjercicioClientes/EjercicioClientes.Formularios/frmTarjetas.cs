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
using static EjercicioClientes.Entidades.Tarjeta;

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
            cbxPeriodoVencimiento.Items.Add("Primera Semana");
            cbxPeriodoVencimiento.Items.Add("Segunda Semana");
            cbxPeriodoVencimiento.Items.Add("Tercera Semana");
            cbxPeriodoVencimiento.Items.Add("Cuarta Semana");
             
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
                    throw new Exception("Debe seleccionar un cliente");
                }

                else if(cbxTipoTarjeta.SelectedIndex == -1)
                {
                    throw new Exception("Debe seleccionar un tipo de tarjeta");
                }
                else if (cbxPeriodoVencimiento.SelectedIndex == -1)
                {
                    throw new Exception("Debe seleccionar un vencimiento");
                }
                else
                {
                    var obj = cbxCliente.SelectedItem;

                    string[] vector = obj.ToString().Split('-');

                    int idcliente = Convert.ToInt32(vector[0]);
                    
                    int tipotarjeta = 0;

                    if(cbxTipoTarjeta.SelectedItem.ToString() == "Visa")
                    {
                        tipotarjeta = 1;
                    }
                    if (cbxTipoTarjeta.SelectedItem.ToString() == "MasterCard")
                    {
                        tipotarjeta = 2;
                    }
                    if (cbxTipoTarjeta.SelectedItem.ToString() == "American")
                    {
                        tipotarjeta = 3;
                    }

                    int peridovencimiento = 0;

                    if(cbxPeriodoVencimiento.SelectedItem.ToString() == "Primera Semana")
                    {
                        peridovencimiento = 1;
                    }
                    if (cbxPeriodoVencimiento.SelectedItem.ToString() == "Segunda Semana")
                    {
                        peridovencimiento = 2;
                    }
                    if (cbxPeriodoVencimiento.SelectedItem.ToString() == "Tercera Semana")
                    {
                        peridovencimiento = 3;
                    }
                    if (cbxPeriodoVencimiento.SelectedItem.ToString() == "Cuarta Semana")
                    {
                        peridovencimiento = 4;
                    }

                    double limitecompra = 0;
                    string strLimite = txtLimiteCompra.Text;

                    string msj = Validaciones.ValidarMonto(strLimite, "Limite de compra", ref limitecompra);

                    if (!string.IsNullOrWhiteSpace(msj))
                    {
                        MessageBox.Show(msj);
                    }
                    else
                    {
                        _tarjetaServicio.DarDeAltaTarjeta(idcliente, tipotarjeta, peridovencimiento, limitecompra);

                        MessageBox.Show("Se dio de alta correctamente la tajerta");

                        LimpiarCampos();

                        List<Tarjeta> lsttar = _tarjetaServicio.TraerTarjetadeunCliente(idcliente);

                        lstTarjetas.DataSource = lsttar;

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            cbxPeriodoVencimiento.SelectedIndex = -1;
            cbxTipoTarjeta.SelectedIndex = -1;
            txtLimiteCompra.Clear();
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = cbxCliente.SelectedItem;

            string[] idv = obj.ToString().Split('-');

            int idcliente = Convert.ToInt32(idv[0]);

            List<Tarjeta> lsttar = _tarjetaServicio.TraerTarjetadeunCliente(idcliente);

            lstTarjetas.DataSource = lsttar;


        }
    }
}
