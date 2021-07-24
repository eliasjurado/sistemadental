namespace appSistemaDental.Boleta
{
    partial class BoletaListar
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
            this.dtpFecAte = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetalleAtencion = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApePac = new System.Windows.Forms.TextBox();
            this.txtNumBol = new System.Windows.Forms.TextBox();
            this.txtNomPac = new System.Windows.Forms.TextBox();
            this.txtIdPac = new System.Windows.Forms.TextBox();
            this.btnBusTra = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAtencion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecAte
            // 
            this.dtpFecAte.Enabled = false;
            this.dtpFecAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecAte.Location = new System.Drawing.Point(455, 163);
            this.dtpFecAte.Name = "dtpFecAte";
            this.dtpFecAte.Size = new System.Drawing.Size(97, 20);
            this.dtpFecAte.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Detalle";
            // 
            // dgvDetalleAtencion
            // 
            this.dgvDetalleAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleAtencion.Location = new System.Drawing.Point(14, 331);
            this.dgvDetalleAtencion.Name = "dgvDetalleAtencion";
            this.dgvDetalleAtencion.Size = new System.Drawing.Size(535, 191);
            this.dgvDetalleAtencion.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Listar Boleta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(402, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Fecha";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nombres";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Nro. Boleta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nro. Historia";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(455, 136);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(97, 20);
            this.txtDni.TabIndex = 25;
            // 
            // txtApePac
            // 
            this.txtApePac.Location = new System.Drawing.Point(95, 161);
            this.txtApePac.Name = "txtApePac";
            this.txtApePac.ReadOnly = true;
            this.txtApePac.Size = new System.Drawing.Size(274, 20);
            this.txtApePac.TabIndex = 24;
            // 
            // txtNumBol
            // 
            this.txtNumBol.Location = new System.Drawing.Point(95, 74);
            this.txtNumBol.Name = "txtNumBol";
            this.txtNumBol.ReadOnly = true;
            this.txtNumBol.Size = new System.Drawing.Size(75, 20);
            this.txtNumBol.TabIndex = 22;
            this.txtNumBol.TextChanged += new System.EventHandler(this.txtNumBol_TextChanged);
            // 
            // txtNomPac
            // 
            this.txtNomPac.Location = new System.Drawing.Point(95, 133);
            this.txtNomPac.Name = "txtNomPac";
            this.txtNomPac.ReadOnly = true;
            this.txtNomPac.Size = new System.Drawing.Size(274, 20);
            this.txtNomPac.TabIndex = 21;
            // 
            // txtIdPac
            // 
            this.txtIdPac.Location = new System.Drawing.Point(95, 104);
            this.txtIdPac.Name = "txtIdPac";
            this.txtIdPac.ReadOnly = true;
            this.txtIdPac.Size = new System.Drawing.Size(75, 20);
            this.txtIdPac.TabIndex = 20;
            // 
            // btnBusTra
            // 
            this.btnBusTra.Location = new System.Drawing.Point(14, 37);
            this.btnBusTra.Name = "btnBusTra";
            this.btnBusTra.Size = new System.Drawing.Size(75, 23);
            this.btnBusTra.TabIndex = 14;
            this.btnBusTra.Text = "Buscar";
            this.btnBusTra.UseVisualStyleBackColor = true;
            this.btnBusTra.Click += new System.EventHandler(this.btnBusTra_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(95, 218);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(75, 20);
            this.txtSubtotal.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Subtotal     S/.";
            // 
            // txtIgv
            // 
            this.txtIgv.Location = new System.Drawing.Point(95, 246);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(75, 20);
            this.txtIgv.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "IGV            S/.";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(294, 218);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(75, 20);
            this.txtDescuento.TabIndex = 22;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(294, 246);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(75, 20);
            this.txtTotalPagar.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Descuento  S/.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Total Pagar S/.";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(95, 275);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(75, 20);
            this.txtTotal.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Total          S/.";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(274, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Email";
            // 
            // BoletaListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 539);
            this.Controls.Add(this.dtpFecAte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetalleAtencion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIgv);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtApePac);
            this.Controls.Add(this.txtNumBol);
            this.Controls.Add(this.txtNomPac);
            this.Controls.Add(this.txtIdPac);
            this.Controls.Add(this.btnBusTra);
            this.Name = "BoletaListar";
            this.Text = "Boleta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAtencion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecAte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetalleAtencion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApePac;
        private System.Windows.Forms.TextBox txtNumBol;
        private System.Windows.Forms.TextBox txtNomPac;
        private System.Windows.Forms.TextBox txtIdPac;
        private System.Windows.Forms.Button btnBusTra;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;

    }
}