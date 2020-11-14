namespace EjercicioClientes.Formularios
{
    partial class FrmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpClientes = new System.Windows.Forms.GroupBox();
            this.grpCuentas = new System.Windows.Forms.GroupBox();
            this.btnListarCuentas = new System.Windows.Forms.Button();
            this.btnAgregarCuentas = new System.Windows.Forms.Button();
            this.grpPrestamos = new System.Windows.Forms.GroupBox();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.grpClientes.SuspendLayout();
            this.grpCuentas.SuspendLayout();
            this.grpPrestamos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "EIJA UNA OPCION DEL MENU";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(132, 29);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(95, 35);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Clientes";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(434, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 35);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Clientes";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(306, 532);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 35);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpClientes
            // 
            this.grpClientes.Controls.Add(this.btnListar);
            this.grpClientes.Controls.Add(this.btnAgregar);
            this.grpClientes.Location = new System.Drawing.Point(59, 74);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(657, 100);
            this.grpClientes.TabIndex = 4;
            this.grpClientes.TabStop = false;
            this.grpClientes.Text = "CLIENTES";
            // 
            // grpCuentas
            // 
            this.grpCuentas.Controls.Add(this.btnListarCuentas);
            this.grpCuentas.Controls.Add(this.btnAgregarCuentas);
            this.grpCuentas.Location = new System.Drawing.Point(59, 196);
            this.grpCuentas.Name = "grpCuentas";
            this.grpCuentas.Size = new System.Drawing.Size(657, 100);
            this.grpCuentas.TabIndex = 5;
            this.grpCuentas.TabStop = false;
            this.grpCuentas.Text = "CUENTAS";
            // 
            // btnListarCuentas
            // 
            this.btnListarCuentas.Location = new System.Drawing.Point(132, 38);
            this.btnListarCuentas.Name = "btnListarCuentas";
            this.btnListarCuentas.Size = new System.Drawing.Size(95, 35);
            this.btnListarCuentas.TabIndex = 1;
            this.btnListarCuentas.Text = "Listar Cuentas";
            this.btnListarCuentas.UseVisualStyleBackColor = true;
            this.btnListarCuentas.Click += new System.EventHandler(this.btnListarCuentas_Click);
            // 
            // btnAgregarCuentas
            // 
            this.btnAgregarCuentas.Location = new System.Drawing.Point(404, 38);
            this.btnAgregarCuentas.Name = "btnAgregarCuentas";
            this.btnAgregarCuentas.Size = new System.Drawing.Size(144, 35);
            this.btnAgregarCuentas.TabIndex = 2;
            this.btnAgregarCuentas.Text = "Agregar Cuentas y Saldo";
            this.btnAgregarCuentas.UseVisualStyleBackColor = true;
            this.btnAgregarCuentas.Click += new System.EventHandler(this.btnAgregarCuentas_Click);
            // 
            // grpPrestamos
            // 
            this.grpPrestamos.Controls.Add(this.btnPrestamos);
            this.grpPrestamos.Location = new System.Drawing.Point(59, 323);
            this.grpPrestamos.Name = "grpPrestamos";
            this.grpPrestamos.Size = new System.Drawing.Size(657, 100);
            this.grpPrestamos.TabIndex = 6;
            this.grpPrestamos.TabStop = false;
            this.grpPrestamos.Text = "PRESTAMOS";
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Location = new System.Drawing.Point(235, 39);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(162, 35);
            this.btnPrestamos.TabIndex = 1;
            this.btnPrestamos.Text = "Modulo de Prestamos";
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 596);
            this.Controls.Add(this.grpPrestamos);
            this.Controls.Add(this.grpCuentas);
            this.Controls.Add(this.grpClientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANCO GOL";
            this.grpClientes.ResumeLayout(false);
            this.grpCuentas.ResumeLayout(false);
            this.grpPrestamos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.GroupBox grpCuentas;
        private System.Windows.Forms.Button btnListarCuentas;
        private System.Windows.Forms.Button btnAgregarCuentas;
        private System.Windows.Forms.GroupBox grpPrestamos;
        private System.Windows.Forms.Button btnPrestamos;
    }
}