using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace appSistemaDental
{
    public partial class PacienteListar : Form
    {
        public PacienteListar()
        {
            InitializeComponent();
        }

        private PacienteDAO paciente = new PacienteDAO();

        private void Filtrar_Grilla()
        {
            dgvListaPaciente.DataSource = paciente.Buscar_Pacientes_Por_Nombre_O_Apellido(txtNombre.Text);
            dgvListaPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListaPaciente.AllowUserToAddRows = false;
            dgvListaPaciente.AllowUserToDeleteRows = false;
            dgvListaPaciente.ReadOnly = true;
        }


        private void Cargar_Grilla()
        {
            dgvListaPaciente.DataSource = paciente.Listar_Pacientes();
            dgvListaPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListaPaciente.AllowUserToAddRows = false;
            dgvListaPaciente.AllowUserToDeleteRows = false;
            dgvListaPaciente.ReadOnly = true;
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Filtrar_Grilla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar_Grilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
            
            PacienteRegistrar f = new PacienteRegistrar();
            f.MdiParent = this.MdiParent;
            f.Show();

            
        }



        //Almacenar datos para pasarlos a otro formulario

        public delegate void Almacenar_Datos(
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
        );

        public event Almacenar_Datos Pasar_Datos;
              
        private void dgvListaPaciente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvListaPaciente.CurrentRow.Selected = true;

                string PI_ID = dgvListaPaciente.CurrentRow.Cells[0].Value.ToString();
                DateTime PI_FECHAREGISTRO = DateTime.Parse(dgvListaPaciente.CurrentRow.Cells[1].Value.ToString());
                string PI_NOMBRES = dgvListaPaciente.CurrentRow.Cells[2].Value.ToString();
                string PI_APELLIDOS = dgvListaPaciente.CurrentRow.Cells[3].Value.ToString();
                string PI_DNI = dgvListaPaciente.CurrentRow.Cells[4].Value.ToString();
                DateTime PI_FECHANACIMIENTO = DateTime.Parse(dgvListaPaciente.CurrentRow.Cells[5].Value.ToString());
                string PI_SEXO = dgvListaPaciente.CurrentRow.Cells[6].Value.ToString();
                string PI_TELMOVIL = dgvListaPaciente.CurrentRow.Cells[7].Value.ToString();
                string PI_TELFIJO = dgvListaPaciente.CurrentRow.Cells[8].Value.ToString();
                string PI_EMAIL = dgvListaPaciente.CurrentRow.Cells[9].Value.ToString();
                string PI_DEPARTAMENTO = dgvListaPaciente.CurrentRow.Cells[10].Value.ToString();
                string PI_PROVINCIA = dgvListaPaciente.CurrentRow.Cells[11].Value.ToString();
                string PI_DISTRITO = dgvListaPaciente.CurrentRow.Cells[12].Value.ToString();
                string PI_DIRECCION = dgvListaPaciente.CurrentRow.Cells[13].Value.ToString();
                string PI_MOTIVOCONSULTA = dgvListaPaciente.CurrentRow.Cells[14].Value.ToString();
                string PI_ALERGIAS = dgvListaPaciente.CurrentRow.Cells[15].Value.ToString();
                string PI_MEDICAMENTOS = dgvListaPaciente.CurrentRow.Cells[16].Value.ToString();
                string PI_ENFERMEDADES = dgvListaPaciente.CurrentRow.Cells[17].Value.ToString();
                string PI_EXEXTRAORAL = dgvListaPaciente.CurrentRow.Cells[18].Value.ToString();
                string PI_EXINTRAORAL = dgvListaPaciente.CurrentRow.Cells[19].Value.ToString();
                string PI_COMOCONOCIO = dgvListaPaciente.CurrentRow.Cells[20].Value.ToString();

                Pasar_Datos(
                    PI_ID
                    ,PI_FECHAREGISTRO
                    ,PI_NOMBRES
                    ,PI_APELLIDOS
                    ,PI_DNI
                    ,PI_FECHANACIMIENTO
                    ,PI_SEXO
                    ,PI_TELMOVIL
                    ,PI_TELFIJO
                    ,PI_EMAIL
                    ,PI_DEPARTAMENTO
                    ,PI_PROVINCIA
                    ,PI_DISTRITO
                    ,PI_DIRECCION
                    ,PI_MOTIVOCONSULTA
                    ,PI_ALERGIAS
                    ,PI_MEDICAMENTOS
                    ,PI_ENFERMEDADES
                    ,PI_EXEXTRAORAL
                    ,PI_EXINTRAORAL
                    ,PI_COMOCONOCIO 
                );
            }
        }

    }
}
