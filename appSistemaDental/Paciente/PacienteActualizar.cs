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
    public partial class PacienteActualizar : Form
    {
        public PacienteActualizar()
        {
            InitializeComponent();
        }
        
        private PacienteDAO paciente = new PacienteDAO();


        private void Cargar_Combo_Sexo()
        {
            DataTable dtb = paciente.Listar_Sexo();

            //Para evitar valor nulo
            DataRow dr = dtb.NewRow();
            dr["DESCRIPCION"] = "Selecciona sexo";
            dtb.Rows.InsertAt(dr, 0);

            cboSex.DataSource = dtb;
            cboSex.DisplayMember = "DESCRIPCION";
            cboSex.ValueMember = "DESCRIPCION";
            cboSex.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Cargar_Combo_Departamento()
        {
            DataTable dtb = paciente.Listar_Departamento();

            //Para evitar valor nulo
            DataRow dr = dtb.NewRow();
            dr["DEPARTAMENTO"] = "Selecciona departamento";
            dtb.Rows.InsertAt(dr, 0);


            cboDepartamento.DataSource = dtb;
            cboDepartamento.DisplayMember = "DEPARTAMENTO";
            cboDepartamento.ValueMember = "DEPARTAMENTO";
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Cargar_Combo_Provincia()
        {

            DataTable dtb = paciente.Listar_Provincia(cboDepartamento.SelectedValue.ToString());

            DataRow dr = dtb.NewRow();
            dr["PROVINCIA"] = "Selecciona provincia";
            dtb.Rows.InsertAt(dr, 0);

            cboProvincia.DataSource = dtb;
            cboProvincia.DisplayMember = "PROVINCIA";
            cboProvincia.ValueMember = "PROVINCIA";
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Cargar_Combo_Distrito()
        {
            DataTable dtb = paciente.Listar_Distrito(cboProvincia.SelectedValue.ToString());

            DataRow dr = dtb.NewRow();
            dr["DISTRITO"] = "Selecciona distrito";
            dtb.Rows.InsertAt(dr, 0);

            cboDistrito.DataSource = dtb;
            cboDistrito.DisplayMember = "DISTRITO";
            cboDistrito.ValueMember = "DISTRITO";
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Cargar_Combo_Como_Conocio()
        {
            DataTable dtb = paciente.Listar_Como_Conocio();

            DataRow dr = dtb.NewRow();
            dr["DESCRIPCION"] = "Selecciona referencia";
            dtb.Rows.InsertAt(dr, 0);

            cboComCon.DataSource = dtb;
            cboComCon.DisplayMember = "DESCRIPCION";
            cboComCon.ValueMember = "DESCRIPCION";
            cboComCon.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Cargar_Codigo()
        {
            txtId.Text = paciente.Codigo_Paciente();
            txtNombre.Focus();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "") { MessageBox.Show("Ingrese nombre"); }
            else if (txtApellido.Text == "") { MessageBox.Show("Ingrese apellido"); }
            else if (cboSex.SelectedIndex.ToString() == "0") { MessageBox.Show("Elija sexo"); }
            else if (cboDepartamento.SelectedIndex.ToString() == "0") { MessageBox.Show("Elija departamento"); }
            else if (cboProvincia.SelectedIndex.ToString() == "0") { MessageBox.Show("Elija provincia"); }
            else if (cboDistrito.SelectedIndex.ToString() == "0") { MessageBox.Show("Elija distrito"); }
            else if (cboComCon.SelectedIndex.ToString() == "0") { MessageBox.Show("Elija cómo conoció el consultorio"); }
            else
            {
                string mensaje = paciente.Actualizar_Paciente(
                    txtId.Text,
                    DateTime.Today,
                    txtNombre.Text,
                    txtApellido.Text,
                    txtDni.Text,
                    dtpFecNac.Value,
                    cboSex.SelectedValue.ToString(),
                    txtMov.Text,
                    txtFij.Text,
                    txtEmail.Text,
                    cboDepartamento.SelectedValue.ToString(),
                    cboProvincia.SelectedValue.ToString(),
                    cboDistrito.SelectedValue.ToString(),
                    txtDireccion.Text,
                    txtMotCon.Text,
                    txtAlergia.Text,
                    txtMed.Text,
                    txtEnf.Text,
                    txtECE.Text,
                    txtECI.Text,
                    cboComCon.SelectedValue.ToString()
                    );
                MessageBox.Show(mensaje);

                this.Close();

                PacienteListar f = new PacienteListar();
                f.MdiParent = this.MdiParent;
                f.Show();
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
            dtpFecReg.Value = PI_FECHAREGISTRO;
            txtNombre.Text = PI_NOMBRES;
            txtApellido.Text = PI_APELLIDOS;
            txtDni.Text = PI_DNI;
            dtpFecNac.Value = PI_FECHANACIMIENTO;
            cboSex.SelectedValue = PI_SEXO;
            txtMov.Text = PI_TELMOVIL;
            txtFij.Text = PI_TELFIJO;
            txtEmail.Text = PI_EMAIL;
            cboDepartamento.SelectedValue = PI_DEPARTAMENTO;
            cboProvincia.SelectedValue = PI_PROVINCIA;
            cboDistrito.SelectedValue = PI_DISTRITO;
            txtDireccion.Text = PI_DIRECCION;
            txtMotCon.Text = PI_MOTIVOCONSULTA;
            txtAlergia.Text = PI_ALERGIAS;
            txtMed.Text = PI_MEDICAMENTOS;
            txtEnf.Text = PI_ENFERMEDADES;
            txtECE.Text = PI_EXEXTRAORAL;
            txtECI.Text = PI_EXINTRAORAL;
            cboComCon.SelectedValue = PI_COMOCONOCIO;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cargar_Combo_Sexo();
            Cargar_Combo_Departamento();
            Cargar_Combo_Como_Conocio();
            
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar_Combo_Provincia();
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar_Combo_Distrito();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PacienteListar f1 = new PacienteListar();
            f1.Pasar_Datos += new PacienteListar.Almacenar_Datos(Recuperar_Datos);
            f1.ShowDialog();
        }
    }
}
