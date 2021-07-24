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
    public partial class TratamientoActualizar : Form
    {
        public TratamientoActualizar()
        {
            InitializeComponent();
        }

        TratamientoDAO tratamiento = new TratamientoDAO();



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
        private void TratamientoActualizar_Load(object sender, EventArgs e)
        {
            Cargar_Combo_Especialidad();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "") { MessageBox.Show("Ingrese descripción"); }
            else if (txtPrecio.Text == "") { MessageBox.Show("Ingrese precio"); }
            else if (cboEspecialidad.SelectedIndex.ToString() == "0") { MessageBox.Show("Elija especialidad"); }
            else
            {
                string mensaje = tratamiento.Actualizar_Tratamiento(
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


        private void Recuperar_Datos(
            string PI_ID
            , string PI_DESCRIPCION
            , double PI_PRECIO
            , string PI_IDESPECIALIDAD
            , DateTime PI_FECHAREGISTRO
            )
        {
            txtId.Text = PI_ID;
            txtDescripcion.Text = PI_DESCRIPCION;
            txtPrecio.Text = PI_PRECIO.ToString();
            cboEspecialidad.Text = PI_IDESPECIALIDAD;
            dtpFechaRegistro.Value = PI_FECHAREGISTRO;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TratamientoListar f1 = new TratamientoListar();
            f1.Pasar_Datos += new TratamientoListar.Almacenar_Datos(Recuperar_Datos);
            f1.ShowDialog();
        }
    }
}
