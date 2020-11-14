using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioClientes.Negocio;
using EjercicioClientes.Entidades;
using System.Configuration;

namespace EjercicioClientes.Formularios
{
    public partial class frmModuloPrestamos : Form
    {
        TipoPrestamosServicio _tipoPrestamosServicio;
        PrestamoServicio _prestamoServicio;
        ClienteServicio _clienteServicio;
        public frmModuloPrestamos()
        {
            InitializeComponent();
            _tipoPrestamosServicio = new TipoPrestamosServicio();
            _prestamoServicio = new PrestamoServicio();
            _clienteServicio = new ClienteServicio();
            CargarListaTipoPrestamos();
            CargarPrestamos();
            CargarClientes();
        }

        private void CargarClientes()
        {
            List<Cliente> lst = _clienteServicio.TraerClientes();

            foreach (Cliente C in lst)
            {
                cbxCliente.Items.Add(C.Id + " - " + C.Nombre + " - " + C.Apellido);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void CargarListaTipoPrestamos()
        {
            lstTipoPrestamos.DataSource = _tipoPrestamosServicio.TrerTipodePrestamos();
        }

        private void CargarPrestamos()
        {
            lstPrestamosDadosDeAlta.DataSource = _prestamoServicio.TraertodoslosPrestamos();
        }

        private void lstTipoPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstTipoPrestamos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de prestamo");
            }
            else
            {
                var obj = lstTipoPrestamos.SelectedItem;

                string[] vector = obj.ToString().Split('-');

                txtLinea.Text = vector[1];
                txtTNA.Text = vector[0];
            }
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                string _STRplazo = txtPlazo.Text;
                int _plazo = 0;
                string _STRmonto = txtMonto.Text;
                double _monto = 0;

                string msj = "";

                msj += Validaciones.ValidarNumero(_STRplazo, "Plazo", ref _plazo);
                msj += Validaciones.ValidarMonto(_STRmonto, "Monto", ref _monto);

                double tna = Convert.ToDouble(txtTNA.Text);

                double cuotacapital = Math.Round(_monto / _plazo,2);
                double cuotainteres = Math.Round(cuotacapital * (tna / 12 / 100),2);
                double cuotatotal = Math.Round(cuotacapital + cuotainteres,2);

                if (!string.IsNullOrWhiteSpace(msj))
                {
                    MessageBox.Show(msj);
                }
                else
                {
                    txtCuotaCapital.Text = cuotacapital.ToString();
                    txtCuotaInteres.Text = cuotainteres.ToString();
                    txtCuotaTotal.Text = cuotatotal.ToString();


                }


            }
            catch(Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un cliente");
                }
                else if (lstTipoPrestamos.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo de prestamo");
                }
                else
                {
                    var STRidcliente = cbxCliente.SelectedItem;

                    string[] ob = STRidcliente.ToString().Split('-');

                    int idcliente = Convert.ToInt32(ob[0]);

                    string _STRplazo = txtPlazo.Text;
                    int _plazo = 0;
                    string _STRmonto = txtMonto.Text;
                    double _monto = 0;

                    string msj = "";

                    msj += Validaciones.ValidarNumero(_STRplazo, "Plazo", ref _plazo);
                    msj += Validaciones.ValidarMonto(_STRmonto, "Monto", ref _monto);

                    double tna = Convert.ToDouble(txtTNA.Text);
                    string linea = txtLinea.Text;

                    double cuotacapital = Math.Round(_monto / _plazo, 2);
                    double cuotainteres = Math.Round(cuotacapital * (tna / 12 / 100), 2);
                    double cuotatotal = Math.Round(cuotacapital + cuotainteres, 2);

                    if (!string.IsNullOrWhiteSpace(msj))
                    {
                        MessageBox.Show(msj);
                    }
                    else
                    {
                        Prestamo P = new Prestamo(tna, linea, _plazo, idcliente, _monto, cuotatotal);

                        _prestamoServicio.InsertarPrestamo(P);

                        MessageBox.Show("Se dio de alta el prestamo");

                        CargarPrestamos();


                    }

                }
            }
            catch(Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }
    }
}
