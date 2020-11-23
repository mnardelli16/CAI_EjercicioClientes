
namespace EjercicioClientes.Formularios
{
    partial class frmTarjetas
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
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPeriodoVencimiento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLimiteCompra = new System.Windows.Forms.TextBox();
            this.btnAltaTarjeta = new System.Windows.Forms.Button();
            this.lstTarjetas = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(872, 388);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(92, 30);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(176, 33);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(176, 21);
            this.cbxCliente.TabIndex = 19;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(36, 36);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(122, 13);
            this.lblCliente.TabIndex = 20;
            this.lblCliente.Text = "SELECCIONE CLIENTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "TIPO TARJETA";
            // 
            // cbxTipoTarjeta
            // 
            this.cbxTipoTarjeta.FormattingEnabled = true;
            this.cbxTipoTarjeta.Location = new System.Drawing.Point(176, 81);
            this.cbxTipoTarjeta.Name = "cbxTipoTarjeta";
            this.cbxTipoTarjeta.Size = new System.Drawing.Size(176, 21);
            this.cbxTipoTarjeta.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "PERIODO VENC";
            // 
            // cbxPeriodoVencimiento
            // 
            this.cbxPeriodoVencimiento.FormattingEnabled = true;
            this.cbxPeriodoVencimiento.Location = new System.Drawing.Point(176, 130);
            this.cbxPeriodoVencimiento.Name = "cbxPeriodoVencimiento";
            this.cbxPeriodoVencimiento.Size = new System.Drawing.Size(176, 21);
            this.cbxPeriodoVencimiento.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "LIMITE COMPRA";
            // 
            // txtLimiteCompra
            // 
            this.txtLimiteCompra.Location = new System.Drawing.Point(225, 180);
            this.txtLimiteCompra.Name = "txtLimiteCompra";
            this.txtLimiteCompra.Size = new System.Drawing.Size(127, 20);
            this.txtLimiteCompra.TabIndex = 26;
            // 
            // btnAltaTarjeta
            // 
            this.btnAltaTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaTarjeta.Location = new System.Drawing.Point(216, 250);
            this.btnAltaTarjeta.Name = "btnAltaTarjeta";
            this.btnAltaTarjeta.Size = new System.Drawing.Size(136, 41);
            this.btnAltaTarjeta.TabIndex = 28;
            this.btnAltaTarjeta.Text = "DAR ALTA TARJETA";
            this.btnAltaTarjeta.UseVisualStyleBackColor = true;
            this.btnAltaTarjeta.Click += new System.EventHandler(this.btnAltaTarjeta_Click);
            // 
            // lstTarjetas
            // 
            this.lstTarjetas.FormattingEnabled = true;
            this.lstTarjetas.Location = new System.Drawing.Point(416, 62);
            this.lstTarjetas.Name = "lstTarjetas";
            this.lstTarjetas.Size = new System.Drawing.Size(548, 303);
            this.lstTarjetas.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "TARJETAS DEL CLIENTE SELECCIONADO";
            // 
            // frmTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstTarjetas);
            this.Controls.Add(this.btnAltaTarjeta);
            this.Controls.Add(this.txtLimiteCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxPeriodoVencimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTipoTarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.btnVolver);
            this.Name = "frmTarjetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo Tarjetas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipoTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPeriodoVencimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLimiteCompra;
        private System.Windows.Forms.Button btnAltaTarjeta;
        private System.Windows.Forms.ListBox lstTarjetas;
        private System.Windows.Forms.Label label4;
    }
}