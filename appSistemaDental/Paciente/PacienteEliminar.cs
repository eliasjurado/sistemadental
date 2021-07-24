using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSistemaDental
{
    public partial class PacienteEliminar : Form
    {
        public PacienteEliminar()
        {
            InitializeComponent();
        }

        private PacienteDAO paciente = new PacienteDAO();

        private void btnEliminar_Click(object sender, EventArgs e)
        {         
            if (MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string mensaje = paciente.Eliminar_Paciente(txtId.Text);
                MessageBox.Show(mensaje);
            }     
        }

        private void Recuperar_Datos(
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
            txtId.Text = PI_ID;
            txtNombre.Text = PI_NOMBRES;
            txtApellido.Text = PI_APELLIDOS;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PacienteListar f1 = new PacienteListar();
            f1.Pasar_Datos += new PacienteListar.Almacenar_Datos(Recuperar_Datos);
            f1.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

            PacienteListar f = new PacienteListar();
            f.MdiParent = this.MdiParent;
            f.Show();
        }



    }
}
