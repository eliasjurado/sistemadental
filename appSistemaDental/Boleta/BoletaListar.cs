using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSistemaDental.Boleta
{
    public partial class BoletaListar : Form
    {
        public BoletaListar()
        {
            InitializeComponent();
        }
        DAO.BoletaDAO boleta = new DAO.BoletaDAO();

        private void Recuperar_Datos(
            int PI_IDBOL
            , DateTime PI_FECHAREGISTRO
            , int PI_IDPAC
            , string PI_NOMBRE
            , string PI_APELLIDO
            , string PI_DNI
            , string PI_EMAIL
            , double PI_SUBTOTALCAB
            , double PI_IGVCAB
            , double PI_TOTALCAB
            , double PI_DESCUENTOCAB
            , double PI_TOTALPAGARCAB
            )
        {
            txtNumBol.Text = PI_IDBOL.ToString();
            dtpFecAte.Value = PI_FECHAREGISTRO;
            txtIdPac.Text = PI_IDPAC.ToString();
            txtNomPac.Text = PI_NOMBRE;
            txtApePac.Text = PI_APELLIDO;
            txtDni.Text = PI_DNI;
            txtEmail.Text = PI_EMAIL;
            txtSubtotal.Text = PI_SUBTOTALCAB.ToString();
            txtIgv.Text = PI_IGVCAB.ToString();
            txtTotal.Text = PI_TOTALCAB.ToString();
            txtDescuento.Text = PI_DESCUENTOCAB.ToString();
            txtTotalPagar.Text = PI_TOTALPAGARCAB.ToString();
            
        }

        private void btnBusTra_Click(object sender, EventArgs e)
        {
            Boleta.BoletaListado f1 = new Boleta.BoletaListado();
            f1.Pasar_Datos += new Boleta.BoletaListado.Almacenar_Datos(Recuperar_Datos);
            f1.ShowDialog();
        }

        private void txtNumBol_TextChanged(object sender, EventArgs e)
        {
            dgvDetalleAtencion.DataSource = boleta.Listar_BoletaDet(int.Parse(txtNumBol.Text));
            dgvDetalleAtencion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleAtencion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDetalleAtencion.AllowUserToAddRows = false;
            dgvDetalleAtencion.AllowUserToDeleteRows = false;
            dgvDetalleAtencion.ReadOnly = true;
        }
    }
}
