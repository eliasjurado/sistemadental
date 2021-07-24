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
    public partial class PagoListar : Form
    {
        public PagoListar()
        {
            InitializeComponent();
        }

        DAO.BoletaDAO boleta = new DAO.BoletaDAO();
        DAO.PagoDAO pago = new DAO.PagoDAO();

        private void Recuperar_Datos_Paciente(
            string PI_ID
            , DateTime PI_FECHAREGISTRO
            , string PI_NOMBRES
            , string PI_APELLIDOS
            , string PI_DNI
            , DateTime PI_FECHANACIMIENTO
            , string PI_SEXO
            , string PI_TELMOVIL
            , string PI_TELFIJO
            , string PI_EMAIL
            , string PI_DEPARTAMENTO
            , string PI_PROVINCIA
            , string PI_DISTRITO
            , string PI_DIRECCION
            , string PI_MOTIVOCONSULTA
            , string PI_ALERGIAS
            , string PI_MEDICAMENTOS
            , string PI_ENFERMEDADES
            , string PI_EXEXTRAORAL
            , string PI_EXINTRAORAL
            , string PI_COMOCONOCIO
            )
        {
            txtIdPac.Text = PI_ID;
            txtNomPac.Text = PI_NOMBRES + " " + PI_APELLIDOS;
        }

        private void tbnBusPac_Click(object sender, EventArgs e)
        {
            PacienteListar f1 = new PacienteListar();
            f1.Pasar_Datos += new PacienteListar.Almacenar_Datos(Recuperar_Datos_Paciente);
            f1.ShowDialog();
        }

        private void txtIdPac_TextChanged(object sender, EventArgs e)
        {
            if (boleta.TotalDescuentoPaciente(int.Parse(txtIdPac.Text)) == "") { txtDescuento.Text = "0"; }
            txtDescuento.Text = boleta.TotalDescuentoPaciente(int.Parse(txtIdPac.Text));
            if (boleta.TotalPendientePorPagar(int.Parse(txtIdPac.Text))=="")   { txtSaldo.Text = "0"; }
            txtSaldo.Text = boleta.TotalPendientePorPagar(int.Parse(txtIdPac.Text));
            if (double.Parse(txtSaldo.Text) >= 0.00) { lblSaldo.Text = "Saldo pendiente"; }
            if (double.Parse(txtSaldo.Text) < 0.00) { lblSaldo.Text = "Saldo a favor"; txtSaldo.Text = double.Parse(txtSaldo.Text).ToString().Replace("-", ""); }


            dgvListaPago.DataSource = pago.Listar_PagoPorPaciente(int.Parse(txtIdPac.Text));
            dgvListaPago.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListaPago.AllowUserToAddRows = false;
            dgvListaPago.AllowUserToDeleteRows = false;
            dgvListaPago.ReadOnly = true;
        
        }


        public delegate void Almacenar_Datos(
            int PI_IDPAGO
            , int PI_IDPACIENTE
            , string PI_NOMBRESYAPELLIDOS
            , double PI_MONTOPAGO
            , DateTime PI_FECHAPAGO
        );

        public event Almacenar_Datos Pasar_Datos;

        private void dgvListaPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvListaPago.CurrentRow.Selected = true;

                int PI_IDPAGO = int.Parse(dgvListaPago.CurrentRow.Cells[0].Value.ToString());
                int PI_IDPACIENTE = int.Parse(txtIdPac.Text);
                string PI_NOMBRESYAPELLIDOS = txtNomPac.Text;
                double PI_MONTOPAGO = double.Parse(dgvListaPago.CurrentRow.Cells[2].Value.ToString());
                DateTime PI_FECHAPAGO = DateTime.Parse(dgvListaPago.CurrentRow.Cells[1].Value.ToString());

                Pasar_Datos(
                    PI_IDPAGO
                    , PI_IDPACIENTE
                    , PI_NOMBRESYAPELLIDOS
                    , PI_MONTOPAGO
                    , PI_FECHAPAGO
                );
            }
        }


    }
}
