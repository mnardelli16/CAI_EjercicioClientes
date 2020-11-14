namespace EjercicioClientes.Formularios
{
    partial class FrmAgregarCuentas
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtNroCuenta = new System.Windows.Forms.TextBox();
            this.cbxDescripcion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkActivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarSaldo = new System.Windows.Forms.Button();
            this.txtSaldoAgregar = new System.Windows.Forms.TextBox();
            this.lblSaldoAgregar = new System.Windows.Forms.Label();
            this.cbxCuenta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(529, 400);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 36);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.txtNroCuenta);
            this.groupBox1.Controls.Add(this.cbxDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkActivo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxCliente);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(48, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 427);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Cuenta";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 24);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Limpiar Campos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(134, 326);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 11;
            // 
            // txtNroCuenta
            // 
            this.txtNroCuenta.Location = new System.Drawing.Point(134, 287);
            this.txtNroCuenta.Name = "txtNroCuenta";
            this.txtNroCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtNroCuenta.TabIndex = 10;
            // 
            // cbxDescripcion
            // 
            this.cbxDescripcion.FormattingEnabled = true;
            this.cbxDescripcion.Location = new System.Drawing.Point(114, 76);
            this.cbxDescripcion.Name = "cbxDescripcion";
            this.cbxDescripcion.Size = new System.Drawing.Size(121, 21);
            this.cbxDescripcion.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo";
            // 
            // checkActivo
            // 
            this.checkActivo.AutoSize = true;
            this.checkActivo.Location = new System.Drawing.Point(167, 149);
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.Size = new System.Drawing.Size(15, 14);
            this.checkActivo.TabIndex = 2;
            this.checkActivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de Cuenta";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(113, 39);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(121, 21);
            this.cbxCliente.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Activo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha Apertura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSaldoActual);
            this.groupBox2.Controls.Add(this.lblSaldoActual);
            this.groupBox2.Controls.Add(this.btnAgregarSaldo);
            this.groupBox2.Controls.Add(this.txtSaldoAgregar);
            this.groupBox2.Controls.Add(this.lblSaldoAgregar);
            this.groupBox2.Controls.Add(this.cbxCuenta);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(373, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 186);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Saldo";
            // 
            // btnAgregarSaldo
            // 
            this.btnAgregarSaldo.Location = new System.Drawing.Point(147, 150);
            this.btnAgregarSaldo.Name = "btnAgregarSaldo";
            this.btnAgregarSaldo.Size = new System.Drawing.Size(97, 24);
            this.btnAgregarSaldo.TabIndex = 13;
            this.btnAgregarSaldo.Text = "Agregar Saldo";
            this.btnAgregarSaldo.UseVisualStyleBackColor = true;
            this.btnAgregarSaldo.Click += new System.EventHandler(this.btnAgregarSaldo_Click);
            // 
            // txtSaldoAgregar
            // 
            this.txtSaldoAgregar.Location = new System.Drawing.Point(144, 108);
            this.txtSaldoAgregar.Name = "txtSaldoAgregar";
            this.txtSaldoAgregar.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoAgregar.TabIndex = 12;
            // 
            // lblSaldoAgregar
            // 
            this.lblSaldoAgregar.AutoSize = true;
            this.lblSaldoAgregar.Location = new System.Drawing.Point(20, 111);
            this.lblSaldoAgregar.Name = "lblSaldoAgregar";
            this.lblSaldoAgregar.Size = new System.Drawing.Size(34, 13);
            this.lblSaldoAgregar.TabIndex = 8;
            this.lblSaldoAgregar.Text = "Saldo";
            // 
            // cbxCuenta
            // 
            this.cbxCuenta.FormattingEnabled = true;
            this.cbxCuenta.Location = new System.Drawing.Point(123, 36);
            this.cbxCuenta.Name = "cbxCuenta";
            this.cbxCuenta.Size = new System.Drawing.Size(121, 21);
            this.cbxCuenta.TabIndex = 7;
            this.cbxCuenta.SelectedIndexChanged += new System.EventHandler(this.cbxCuenta_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cuenta";
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Location = new System.Drawing.Point(20, 79);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(67, 13);
            this.lblSaldoActual.TabIndex = 14;
            this.lblSaldoActual.Text = "Saldo Actual";
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.Enabled = false;
            this.txtSaldoActual.Location = new System.Drawing.Point(144, 76);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoActual.TabIndex = 15;
            // 
            // FrmAgregarCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmAgregarCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cuentas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtNroCuenta;
        private System.Windows.Forms.ComboBox cbxDescripcion;
        private System.Windows.Forms.CheckBox checkActivo;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarSaldo;
        private System.Windows.Forms.TextBox txtSaldoAgregar;
        private System.Windows.Forms.Label lblSaldoAgregar;
        private System.Windows.Forms.ComboBox cbxCuenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.TextBox txtSaldoActual;
    }
}