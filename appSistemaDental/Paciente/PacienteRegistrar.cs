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
    public partial class PacienteRegistrar : Form
    {
        public PacienteRegistrar()
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
            cboSex.ValueMember = "ID";
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
            cboComCon.ValueMember = "ID";
            cboComCon.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void Cargar_Codigo()
        {
            txtId.Text = paciente.Codigo_Paciente();
            txtNombre.Focus();
        }


        //Eventos
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
        if(txtNombre.Text==""){MessageBox.Show("Ingrese nombre");}
        else if (txtApellido.Text == "") { MessageBox.Show("Ingrese apellido"); }
        else if (cboSex.SelectedIndex.ToString() == "0") { MessageBox.Show("Elija sexo"); }
        else if (cboDepartamento.SelectedIndex.ToString() == "0") { MessageBox.Show("Elija departamento"); }
        else if (cboProvincia.SelectedIndex.ToString() == "0") { MessageBox.Show("Elija provincia"); }
        else if (cboDistrito.SelectedIndex.ToString() == "0") { MessageBox.Show("Elija distrito"); }
        else if (cboComCon.SelectedIndex.ToString() == "0") { MessageBox.Show("Elija cómo conoció el consultorio"); }
        else
            {
            string mensaje = paciente.Agregar_Paciente(
                txtId.Text,
                DateTime.Today,
                txtNombre.Text,
                txtApellido.Text,
                txtDni.Text,
                dtpFecNac.Value,
                cboSex.SelectedValue.ToString(),
                txtMovil.Text,
                txtFijo.Text,
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

            PacienteListar f = new PacienteListar();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Cargar_Codigo();
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
  

        
    }
}
