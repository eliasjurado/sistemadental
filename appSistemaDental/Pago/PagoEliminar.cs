using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSistemaDental.Pago
{
    public partial class PagoEliminar : Form
    {
        public PagoEliminar()
        {
            InitializeComponent();
        }

        DAO.PagoDAO pago = new DAO.PagoDAO();

        private void Recuperar_Datos_Pago(
            int PI_IDPAGO
            , int PI_IDPACIENTE
            , string PI_NOMBRESYAPELLIDOS
            , double PI_MONTOPAGO
            , DateTime PI_FECHAPAGO
            )
        {
            txtIdPago.Text = PI_IDPAGO.ToString();
            txtIdPac.Text = PI_IDPACIENTE.ToString();
            txtPaciente.Text = PI_NOMBRESYAPELLIDOS;
            txtMonto.Text = PI_MONTOPAGO.ToString();
            dtpFechaPago.Value = PI_FECHAPAGO;
        }

        private void btnBuscarPac_Click(object sender, EventArgs e)
        {
            Pago.PagoListar f1 = new Pago.PagoListar();
            f1.Pasar_Datos += new Pago.PagoListar.Almacenar_Datos(Recuperar_Datos_Pago);
            f1.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string mensaje = pago.Eliminar_Pago(txtIdPago.Text);
                MessageBox.Show(mensaje);
            }     
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
