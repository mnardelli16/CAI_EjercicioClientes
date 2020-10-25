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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmListar Listar = new FrmListar();
            Listar.Owner = this;  //le dice que este formulario es el propietario
            Listar.Show(); // abre el otro formulario
            this.Hide(); // oculta el formulario principal

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregar Agregar = new FrmAgregar();
            Agregar.Owner = this;  //le dice que este formulario es el propietario
            Agregar.Show(); // abre el otro formulario
            this.Hide(); // oculta el formulario principal
        }

        private void btnListarCuentas_Click(object sender, EventArgs e)
        {
            FrmListarCuentas Cuentas = new FrmListarCuentas();
            Cuentas.Owner = this;
            Cuentas.Show();
            this.Hide();
        }

        private void btnAgregarCuentas_Click(object sender, EventArgs e)
        {
            FrmAgregarCuentas CuentasA = new FrmAgregarCuentas();
            CuentasA.Owner = this;
            CuentasA.Show();
            this.Hide();
        }
    }
}
