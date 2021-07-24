namespace appSistemaDental.Boleta
{
    partial class BoletaListado
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
            this.dgvBoleta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoleta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBoleta
            // 
            this.dgvBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoleta.Location = new System.Drawing.Point(13, 12);
            this.dgvBoleta.Name = "dgvBoleta";
            this.dgvBoleta.Size = new System.Drawing.Size(957, 407);
            this.dgvBoleta.TabIndex = 0;
            this.dgvBoleta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoleta_CellContentClick);
            // 
            // BoletaListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 431);
            this.Controls.Add(this.dgvBoleta);
            this.Name = "BoletaListado";
            this.Text = "BoletaListado";
            this.Load += new System.EventHandler(this.BoletaListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoleta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBoleta;
    }
}