using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSistemaDental.Historial
{
    public partial class HistorialConsultar : Form
    {
        public HistorialConsultar()
        {
            InitializeComponent();
        }
        PacienteDAO paciente = new PacienteDAO();
        DAO.BoletaDAO boleta = new DAO.BoletaDAO();

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
            txtEdad.Text = (System.DateTime.Now.Year - PI_FECHANACIMIENTO.Year).ToString();
            txtAlergias.Text = PI_ALERGIAS;
            txtMedicamentos.Text = PI_MEDICAMENTOS;
            txtEnfermedades.Text = PI_ENFERMEDADES;
        }

        private void btnBusTra_Click(object sender, EventArgs e)
        {
            PacienteListar f1 = new PacienteListar();
            f1.Pasar_Datos += new PacienteListar.Almacenar_Datos(Recuperar_Datos_Paciente);
            f1.ShowDialog();
        }

        private void txtIdPac_TextChanged(object sender, EventArgs e)
        {
            txtTotalAtencion.Text = boleta.TotalAtencionPaciente(int.Parse(txtIdPac.Text));
            txtTotalDescuento.Text = boleta.TotalDescuentoPaciente(int.Parse(txtIdPac.Text));
            txtTotalPorcentaje.Text = boleta.TotalPorcentajeDsctoPaciente(int.Parse(txtIdPac.Text))+" %";

            dgvDetalleAtencion.DataSource = boleta.Listar_BoletaDetPorPaciente(int.Parse(txtIdPac.Text));
            dgvDetalleAtencion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleAtencion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDetalleAtencion.AllowUserToAddRows = false;
            dgvDetalleAtencion.AllowUserToDeleteRows = false;
            dgvDetalleAtencion.ReadOnly = true;

            if (boleta.TotalPendientePorPagar(int.Parse(txtIdPac.Text)) == "") { txtSaldo.Text = "0"; }
            txtSaldo.Text = boleta.TotalPendientePorPagar(int.Parse(txtIdPac.Text));
            if (double.Parse(txtSaldo.Text) >= 0.00) { lblSaldo.Text = "Saldo pendiente"; }
            if (double.Parse(txtSaldo.Text) < 0.00) { lblSaldo.Text = "Saldo a favor"; txtSaldo.Text = double.Parse(txtSaldo.Text).ToString().Replace("-", ""); }
        }
    }
}
