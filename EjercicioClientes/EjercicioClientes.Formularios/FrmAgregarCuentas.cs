using EjercicioClientes.Negocio;
using EjercicioClientes.Entidades;
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
    public partial class FrmAgregarCuentas : Form
    {
        private CuentaServicio _cuentaServicio;
        private ClienteServicio _clienteServicio;
        public FrmAgregarCuentas()
        {
            InitializeComponent();

            _cuentaServicio = new CuentaServicio();
            _clienteServicio = new ClienteServicio();
            AgregarClientesCombo();
            AgregarComboDescricion();
            AgregarCuentasCombo();
            
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
                bool _activo = false;
                string _descpricion;
                string _fechaApertura = dateTimePicker1.Text;
                string _STRIdcliente;
                int _idCliente;



                if (checkActivo.Checked)
                {
                    _activo = true;
                }

                if(cbxCliente.SelectedIndex == -1)
                {
                    throw new Exception("Debe seleccionar un cliente");
                }
                if (cbxDescripcion.SelectedIndex == -1)
                {
                    throw new Exception("Debe seleccionar una descripcion");
                }

                _descpricion = cbxDescripcion.SelectedItem.ToString();

                _STRIdcliente = cbxCliente.SelectedItem.ToString();
                string[] a = _STRIdcliente.Split('-');
                _idCliente = Convert.ToInt32(a[0]);

                Cuenta C = new Cuenta(1,0,_descpricion, _fechaApertura, _activo, _idCliente, TraerProximoID());

                _cuentaServicio.InsertarCuenta(C);

                MessageBox.Show("Se agrego la cuenta al cliente " + C.IdCliente + " exitosamente","Mensaje del sistema");

                Cuenta Aux = _cuentaServicio.ListarCuentaPorID(C.IdCliente);

                txtNroCuenta.Text = Aux.NroCuenta.ToString();
                txtSaldo.Text = Aux.Saldo.ToString();

                AgregarCuentasCombo();

            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void AgregarComboDescricion()
        {
            cbxDescripcion.Items.Add("Caja de ahorro");
            cbxDescripcion.Items.Add("Cuenta Corriente");
        }

        private void AgregarClientesCombo()
        {
            List<Cliente> lst = _clienteServicio.TraerClientes();

            foreach(Cliente C in lst)
            {
                cbxCliente.Items.Add(C.Id + " - " + C.Nombre + " - " + C.Apellido);
            }
        }

        private void AgregarCuentasCombo()
        {
            List<Cuenta> lst = _cuentaServicio.ListarTodas();

            foreach(Cuenta C in lst)
            {
                cbxCuenta.Items.Add(C.IdCliente + " - " + C.NroCuenta);
            }
        }

        private int TraerProximoID()
        {
            List<Cuenta> ccc = _cuentaServicio.ListarTodas();
            int contador = 0;
            foreach(Cuenta C in ccc)
            {
                if(C.Id > contador)
                {
                    contador = C.Id;
                }
            }
            return contador + 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cbxCliente.SelectedIndex = -1;
            cbxDescripcion.SelectedIndex = -1;
            txtNroCuenta.Clear();
            txtSaldo.Clear();
        }

        private void btnAgregarSaldo_Click(object sender, EventArgs e)
        {
            try
            {
                string STRsaldo = txtSaldoAgregar.Text;
                float _saldo = 0;

                string msj = Validaciones.ValidarSaldo(STRsaldo, "Saldo", ref _saldo);

                if(cbxCuenta.SelectedIndex == -1)
                {
                    throw new Exception("Debe seleccionar una cuenta");
                }

                string STRID = cbxCuenta.SelectedItem.ToString();
                string[] B = STRID.Split('-');
                int id = Convert.ToInt32(B[0]);

                if (!string.IsNullOrWhiteSpace(msj))
                {
                    MessageBox.Show(msj);
                }
                else
                {
                    Cuenta C = _cuentaServicio.ListarCuentaPorID(id);

                    _cuentaServicio.AgregarSaldo(C);

                    MessageBox.Show("Se agrego el saldo al " + C.IdCliente + " exitosamente", "Mensaje del sistema");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
