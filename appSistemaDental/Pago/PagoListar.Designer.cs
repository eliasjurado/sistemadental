namespace appSistemaDental.Pago
{
    partial class PagoListar
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
            this.tbnBusPac = new System.Windows.Forms.Button();
            this.dgvListaPago = new System.Windows.Forms.DataGridView();
            this.txtIdPac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomPac = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPago)).BeginInit();
            this.SuspendLayout();
            // 
            // tbnBusPac
            // 
            this.tbnBusPac.Location = new System.Drawing.Point(13, 35);
            this.tbnBusPac.Name = "tbnBusPac";
            this.tbnBusPac.Size = new System.Drawing.Size(100, 23);
            this.tbnBusPac.TabIndex = 14;
            this.tbnBusPac.Text = "Buscar Paciente";
            this.tbnBusPac.UseVisualStyleBackColor = true;
            this.tbnBusPac.Click += new System.EventHandler(this.tbnBusPac_Click);
            // 
            // dgvListaPago
            // 
            this.dgvListaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPago.Location = new System.Drawing.Point(12, 203);
            this.dgvListaPago.Name = "dgvListaPago";
            this.dgvListaPago.Size = new System.Drawing.Size(383, 346);
            this.dgvListaPago.TabIndex = 13;
            this.dgvListaPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPago_CellContentClick);
            // 
            // txtIdPac
            // 
            this.txtIdPac.Location = new System.Drawing.Point(141, 69);
            this.txtIdPac.Name = "txtIdPac";
            this.txtIdPac.ReadOnly = true;
            this.txtIdPac.Size = new System.Drawing.Size(95, 20);
            this.txtIdPac.TabIndex = 12;
            this.txtIdPac.TextChanged += new System.EventHandler(this.txtIdPac_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nro. Historia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Listado de Pagos por Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre";
            // 
            // txtNomPac
            // 
            this.txtNomPac.Location = new System.Drawing.Point(141, 97);
            this.txtNomPac.Name = "txtNomPac";
            this.txtNomPac.ReadOnly = true;
            this.txtNomPac.Size = new System.Drawing.Size(222, 20);
            this.txtNomPac.TabIndex = 12;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(15, 153);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(126, 13);
            this.lblSaldo.TabIndex = 10;
            this.lblSaldo.Text = "Saldo pendiente         S/.";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(141, 150);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(95, 20);
            this.txtSaldo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total dscto. recibido  S/.";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(141, 123);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(95, 20);
            this.txtDescuento.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pagos realizados";
            // 
            // PagoListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 561);
            this.Controls.Add(this.tbnBusPac);
            this.Controls.Add(this.dgvListaPago);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNomPac);
            this.Controls.Add(this.txtIdPac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PagoListar";
            this.Text = "Operaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbnBusPac;
        private System.Windows.Forms.DataGridView dgvListaPago;
        private System.Windows.Forms.TextBox txtIdPac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomPac;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label6;
    }
}