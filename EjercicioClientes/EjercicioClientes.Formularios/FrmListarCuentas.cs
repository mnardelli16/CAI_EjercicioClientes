﻿using EjercicioClientes.Negocio;
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
    public partial class FrmListarCuentas : Form
    {
        private CuentaServicio cuentaServicio;
        public FrmListarCuentas()
        {
            InitializeComponent();
            cuentaServicio = new CuentaServicio();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List<Cuenta> lst = cuentaServicio.ListarTodas();

            dataGridView1.DataSource = lst;
        }
    }
}
