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
    public partial class PagoRegistrar : Form
    {
        public PagoRegistrar()
        {
            InitializeComponent();
        }

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
            txtPaciente.Text = PI_NOMBRES+" "+PI_APELLIDOS;
        }

        private void btnBuscarPac_Click(object sender, EventArgs e)
        {
            PacienteListar f1 = new PacienteListar();
            f1.Pasar_Datos += new PacienteListar.Almacenar_Datos(Recuperar_Datos_Paciente);
            f1.ShowDialog();
        }

        private void PagoRegistrar_Load(object sender, EventArgs e)
        {
            txtIdPago.Text = pago.Codigo_Pago();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text == "") { MessageBox.Show("Indique monto"); }
            else if (dtpFechaPago.Value > System.DateTime.Now) { MessageBox.Show("La fecha de pago no puede ser posterior a la fecha actual"); }
            else {

                string mensaje = pago.Agregar_Pago(
                    int.Parse(txtIdPago.Text),
                    int.Parse(txtIdPac.Text),
                    double.Parse(txtMonto.Text),
                    dtpFechaPago.Value
                    );
                MessageBox.Show(mensaje);

                this.Close();
                
            }
        }

    }
}
