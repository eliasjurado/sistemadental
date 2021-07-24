using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSistemaDental.Boleta
{
    public partial class BoletaListado : Form
    {
        public BoletaListado()
        {
            InitializeComponent();
        }

        private DAO.BoletaDAO boleta = new DAO.BoletaDAO();

        private void Cargar_Grilla()
        {
            dgvBoleta.DataSource = boleta.Listar_BoletaCab();
            dgvBoleta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBoleta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBoleta.AllowUserToAddRows = false;
            dgvBoleta.AllowUserToDeleteRows = false;
            dgvBoleta.ReadOnly = true;
        }

        private void BoletaListado_Load(object sender, EventArgs e)
        {
            Cargar_Grilla();
        }


        public delegate void Almacenar_Datos(
            int PI_IDBOL
            ,DateTime PI_FECHAREGISTRO
            , int PI_IDPAC
            , string PI_NOMBRE
            , string PI_APELLIDO
            , string PI_DNI
            , string PI_EMAIL
            , double PI_SUBTOTALCAB
            , double PI_IGVCAB
            , double PI_TOTALCAB
            , double PI_DESCUENTOCAB
            , double PI_TOTALPAGARCAB
        );

        public event Almacenar_Datos Pasar_Datos;

        private void dgvBoleta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvBoleta.CurrentRow.Selected = true;

                int PI_IDBOL = int.Parse(dgvBoleta.CurrentRow.Cells[0].Value.ToString());
                DateTime PI_FECHAREGISTRO = DateTime.Parse(dgvBoleta.CurrentRow.Cells[1].Value.ToString());
                int PI_IDPAC = int.Parse(dgvBoleta.CurrentRow.Cells[2].Value.ToString());
                string PI_NOMBRE = dgvBoleta.CurrentRow.Cells[3].Value.ToString();
                string PI_APELLIDO = dgvBoleta.CurrentRow.Cells[4].Value.ToString();
                string PI_DNI = dgvBoleta.CurrentRow.Cells[5].Value.ToString();
                string PI_EMAIL = dgvBoleta.CurrentRow.Cells[6].Value.ToString();
                string PI_SUBTOTALCAB=dgvBoleta.CurrentRow.Cells[7].Value.ToString();
                string PI_IGVCAB=dgvBoleta.CurrentRow.Cells[8].Value.ToString();
                string PI_TOTALCAB=dgvBoleta.CurrentRow.Cells[9].Value.ToString();
                string PI_DESCUENTOCAB=dgvBoleta.CurrentRow.Cells[10].Value.ToString();
                string PI_TOTALPAGARCAB = dgvBoleta.CurrentRow.Cells[11].Value.ToString();

                Pasar_Datos(
                    PI_IDBOL
                    , PI_FECHAREGISTRO
                    , PI_IDPAC
                    , PI_NOMBRE
                    , PI_APELLIDO
                    , PI_DNI
                    , PI_EMAIL
                    , double.Parse(PI_SUBTOTALCAB)
                    , double.Parse(PI_IGVCAB)
                    , double.Parse(PI_TOTALCAB)
                    , double.Parse(PI_DESCUENTOCAB)
                    , double.Parse(PI_TOTALPAGARCAB)
                );
            }
        }

       

    }
}
