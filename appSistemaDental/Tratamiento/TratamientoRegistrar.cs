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
    public partial class TratamientoRegistrar : Form
    {
        public TratamientoRegistrar()
        {
            InitializeComponent();
        }
        private TratamientoDAO tratamiento = new TratamientoDAO();

        private void Cargar_Combo_Especialidad()
        {
            DataTable dtb = tratamiento.Listar_Especialidad();

            //Para evitar valor nulo
            DataRow dr = dtb.NewRow();
            dr["DESCRIPCION"] = "Selecciona especialidad";
            dtb.Rows.InsertAt(dr, 0);


            cboEspecialidad.DataSource = dtb;
            cboEspecialidad.DisplayMember = "DESCRIPCION";
            cboEspecialidad.ValueMember = "ID";
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Cargar_Codigo()
        {
            txtId.Text = tratamiento.Codigo_Tratamiento();
            txtDescripcion.Focus();
        }

        private void TratamientoRegistrar_Load(object sender, EventArgs e)
        {
            Cargar_Combo_Especialidad();
            Cargar_Codigo();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "") { MessageBox.Show("Ingrese descripción"); }
            else if (txtPrecio.Text == "") { MessageBox.Show("Ingrese precio"); }
            else if (cboEspecialidad.SelectedIndex.ToString() == "0") { MessageBox.Show("Elija especialidad"); }
            else
            {
                string mensaje = tratamiento.Agregar_Tratamiento(
                    txtId.Text,
                    txtDescripcion.Text,
                    double.Parse(txtPrecio.Text),
                    int.Parse(cboEspecialidad.SelectedValue.ToString()),
                    DateTime.Today
                    );
                MessageBox.Show(mensaje);

                this.Close();

                TratamientoListar f = new TratamientoListar();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

            TratamientoListar f = new TratamientoListar();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

    }
}
