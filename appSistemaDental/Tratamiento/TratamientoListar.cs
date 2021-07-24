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
    public partial class TratamientoListar : Form
    {
        public TratamientoListar()
        {
            InitializeComponent();
        }

        private TratamientoDAO tratamiento = new TratamientoDAO();

        private void Cargar_Grilla()
        {
            dgvListaTratamiento.DataSource = tratamiento.Listar_Tratamiento();
            dgvListaTratamiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaTratamiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListaTratamiento.AllowUserToAddRows = false;
            dgvListaTratamiento.AllowUserToDeleteRows = false;
            dgvListaTratamiento.ReadOnly = true;
        }

        private void Filtrar_Grilla()
        {
            dgvListaTratamiento.DataSource = tratamiento.Buscar_Tratamiento_Por_Nombre(txtNombre.Text);
            dgvListaTratamiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaTratamiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListaTratamiento.AllowUserToAddRows = false;
            dgvListaTratamiento.AllowUserToDeleteRows = false;
            dgvListaTratamiento.ReadOnly = true;
        }

        private void TratamientoListar_Load(object sender, EventArgs e)
        {
            Cargar_Grilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();

            TratamientoRegistrar f = new TratamientoRegistrar();
            f.MdiParent = this.MdiParent;
            f.Show();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Filtrar_Grilla();
        }


        //Almacenar datos para pasarlos a otro formulario

        public delegate void Almacenar_Datos(
            string PI_ID
            , string PI_DESCRIPCION
            , double PI_PRECIO
            , string PI_IDESPECIALIDAD
            , DateTime PI_FECHAREGISTRO
        );

        public event Almacenar_Datos Pasar_Datos;

        private void dgvListaTratamiento_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvListaTratamiento.CurrentRow.Selected = true;

                string PI_ID = dgvListaTratamiento.CurrentRow.Cells[0].Value.ToString();
                string PI_DESCRIPCION = dgvListaTratamiento.CurrentRow.Cells[1].Value.ToString();
                double PI_PRECIO = double.Parse(dgvListaTratamiento.CurrentRow.Cells[2].Value.ToString());
                string PI_IDESPECIALIDAD = dgvListaTratamiento.CurrentRow.Cells[3].Value.ToString();
                DateTime PI_FECHAREGISTRO = DateTime.Parse(dgvListaTratamiento.CurrentRow.Cells[4].Value.ToString());

                Pasar_Datos(
                    PI_ID
                    , PI_DESCRIPCION
                    , PI_PRECIO
                    , PI_IDESPECIALIDAD
                    , PI_FECHAREGISTRO
                );
            }
        }

       








    }
}
