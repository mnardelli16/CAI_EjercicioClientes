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
    public partial class FrmListar : Form
    {
        private ClienteServicio _clienteServicio;
        public FrmListar()
        {
            InitializeComponent();

            _clienteServicio = new ClienteServicio();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            List<Cliente> lst = _clienteServicio.TraerClientes();

            //forma de hacer un datasource pero personalizado
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("apellido", "Apellido");
            dataGridView1.Columns.Add("direccion", "Direccion");
            dataGridView1.Columns.Add("email", "Email");

            foreach (Cliente c in lst)
            {
                dataGridView1.Rows.Add(c.Id, c.Nombre, c.Apellido,c.Direccion,c.Email);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
