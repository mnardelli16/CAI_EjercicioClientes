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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListarCuentas = new System.Windows.Forms.Button();
            this.btnAgregarCuentas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "EIJA UNA OPCION DEL MENU";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(51, 29);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(95, 35);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Clientes";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(251, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 35);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Clientes";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(207, 334);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 35);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(59, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTES";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListarCuentas);
            this.groupBox2.Controls.Add(this.btnAgregarCuentas);
            this.groupBox2.Location = new System.Drawing.Point(59, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CUENTAS";
            // 
            // btnListarCuentas
            // 
            this.btnListarCuentas.Location = new System.Drawing.Point(51, 29);
            this.btnListarCuentas.Name = "btnListarCuentas";
            this.btnListarCuentas.Size = new System.Drawing.Size(95, 35);
            this.btnListarCuentas.TabIndex = 1;
            this.btnListarCuentas.Text = "Listar Cuentas";
            this.btnListarCuentas.UseVisualStyleBackColor = true;
            this.btnListarCuentas.Click += new System.EventHandler(this.btnListarCuentas_Click);
            // 
            // btnAgregarCuentas
            // 
            this.btnAgregarCuentas.Location = new System.Drawing.Point(251, 29);
            this.btnAgregarCuentas.Name = "btnAgregarCuentas";
            this.btnAgregarCuentas.Size = new System.Drawing.Size(95, 35);
            this.btnAgregarCuentas.TabIndex = 2;
            this.btnAgregarCuentas.Text = "Agregar Cuentas";
            this.btnAgregarCuentas.UseVisualStyleBackColor = true;
            this.btnAgregarCuentas.Click += new System.EventHandler(this.btnAgregarCuentas_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Name = "FrmInicio";
            this.Text = "CLIENTES";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnListarCuentas;
        private System.Windows.Forms.Button btnAgregarCuentas;
    }
}