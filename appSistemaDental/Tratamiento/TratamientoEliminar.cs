using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSistemaDental.Tratamiento
{
    public partial class TratamientoEliminar : Form
    {
        public TratamientoEliminar()
        {
            InitializeComponent();
        }

        private TratamientoDAO tratamiento = new TratamientoDAO();

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string mensaje = tratamiento.Eliminar_Tratamiento(txtId.Text);
                MessageBox.Show(mensaje);
            }
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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TratamientoListar f1 = new TratamientoListar();
            f1.Pasar_Datos += new TratamientoListar.Almacenar_Datos(Recuperar_Datos);
            f1.ShowDialog();
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
