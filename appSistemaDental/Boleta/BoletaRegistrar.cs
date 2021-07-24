using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSistemaDental.Atencion
{
    public partial class AtencionRegistrar : Form
    {
        public AtencionRegistrar()
        {
            InitializeComponent();
        }
        
        DAO.BoletaDAO boleta = new DAO.BoletaDAO();

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
            txtNomPac.Text = PI_NOMBRES;
            txtApePac.Text = PI_APELLIDOS;
            txtDni.Text = PI_DNI;
            txtEmaPac.Text = PI_EMAIL;
        }

        private void Recuperar_Datos_Tratamiento(
            string PI_ID
            , string PI_DESCRIPCION
            , double PI_PRECIO
            , string PI_IDESPECIALIDAD
            , DateTime PI_FECHAREGISTRO
            )
        {
            txtIdTra.Text = PI_ID;
            txtDesTra.Text = PI_DESCRIPCION;
            txtPreTra.Text = PI_PRECIO.ToString();
        }


        private void btnBusPac_Click(object sender, EventArgs e)
        {
            PacienteListar f1 = new PacienteListar();
            f1.Pasar_Datos += new PacienteListar.Almacenar_Datos(Recuperar_Datos_Paciente);
            f1.ShowDialog();
        }

        private void btnBusTra_Click(object sender, EventArgs e)
        {
            TratamientoListar f1 = new TratamientoListar();
            f1.Pasar_Datos += new TratamientoListar.Almacenar_Datos(Recuperar_Datos_Tratamiento);
            f1.ShowDialog();

           
        }

        private void Codigo_Boleta() {
            txtNumBol.Text = boleta.Codigo_Boleta();
            btnBusPac.Focus();
        }
        
        private void AtencionRegistrar_Load(object sender, EventArgs e)
        {
            Codigo_Boleta();
        }






        private List<clsDetalleBoleta> lstDetBol = new List<clsDetalleBoleta>();

        private void CargarGrilla()
        {
            dgvDetalleAtencion.DataSource = null;
            dgvDetalleAtencion.DataSource = lstDetBol;
            dgvDetalleAtencion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleAtencion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDetalleAtencion.AllowUserToAddRows = false;
            dgvDetalleAtencion.AllowUserToDeleteRows = false;
            dgvDetalleAtencion.ReadOnly = true;
        }


        //Contadores y acumuladores
        int numboldet = 1;
        double subtotal = 0;
        double igv = 0;
        double total = 0;
        //------------------------

        private void btnPasTra_Click(object sender, EventArgs e)
        {
            if (txtIdTra.Text == "" && txtDesTra.Text == "" && txtPreTra.Text == "" && nudCan.Value.ToString() == "0")
            { MessageBox.Show("Seleccione al menos un tratamiento");}
            else if (nudCan.Value.ToString() == "0")
            { MessageBox.Show("La cantidad debe ser mayor a 0"); }
            else if (txtPiezas.Text == "")
            { MessageBox.Show("Indique pieza(s) tratada(s)"); }
            else
            {
                clsDetalleBoleta reg = lstDetBol.Find(i => i.Tratamiento == txtDesTra.Text);
                if (reg == null)
                {
                    reg = new clsDetalleBoleta();
                    reg.IdDetalle = numboldet++;
                    reg.Tratamiento = txtDesTra.Text;
                    reg.Cantidad = int.Parse(nudCan.Value.ToString());
                    reg.Piezas = txtPiezas.Text;
                    reg.PrecioUnitario = double.Parse(txtPreTra.Text);

                    lstDetBol.Add(reg);
                    //Acumuladores
                    subtotal += reg.Subtotal;
                    igv += reg.Igv;
                    total += reg.Total;
                    //Impresion totales
                    txtSubtotalCab.Text = subtotal.ToString();
                    txtIgvCab.Text = igv.ToString();
                    txtTotalCab.Text = total.ToString();

                    CargarGrilla();

                    nudCan.Value = 0;
                    txtPiezas.Text = "";
                }
            }
            

        }

        private void btnQuiTra_Click(object sender, EventArgs e)
        {
            clsDetalleBoleta reg = lstDetBol.Find(i => i.Tratamiento == txtDesTra.Text);
            if (reg != null)
            {

                lstDetBol.Remove(reg);
                subtotal -= reg.Subtotal;
                igv -= reg.Igv;
                total -= reg.Total;
                //Impresion totales
                txtSubtotalCab.Text = subtotal.ToString();
                txtIgvCab.Text = igv.ToString();
                txtTotalCab.Text = total.ToString();

                CargarGrilla();

                nudCan.Value = 0;
                txtPiezas.Text = "";

            }
        }

        

        private void btnGra_Click(object sender, EventArgs e)
        {

            if (txtIdPac.Text == "") { MessageBox.Show("Seleccione un paciente");}
            else if(txtSubtotalCab.Text=="") {MessageBox.Show("Seleccione al menos un tratamiento");}
            else if (dtpFecAte.Value > System.DateTime.Now) { MessageBox.Show("La fecha de atención no puede ser posterior a la fecha actual"); }
            else if (txtDescuentoCab.Text == "") { MessageBox.Show("Indique el descuento"); }
            else{
            string mensaje = boleta.Agregar_BoletaCab(
                int.Parse(txtNumBol.Text),
                int.Parse(txtIdPac.Text),
                dtpFecAte.Value,
                txtEmaPac.Text,
                double.Parse(txtSubtotalCab.Text),
                double.Parse(txtIgvCab.Text),
                double.Parse(txtTotalCab.Text),
                double.Parse(txtDescuentoCab.Text),
                double.Parse(txtTotalPagarCab.Text)
                );

            foreach (DataGridViewRow row in dgvDetalleAtencion.Rows)
            {
                string mensaje1 = boleta.Agregar_BoletaDet(
                   int.Parse(txtNumBol.Text),
                   int.Parse(row.Cells[0].Value.ToString()),
                   row.Cells[1].Value.ToString(),
                   int.Parse(row.Cells[2].Value.ToString()),
                   row.Cells[3].Value.ToString(),
                   double.Parse(row.Cells[5].Value.ToString()),
                   double.Parse(row.Cells[6].Value.ToString()),
                   double.Parse(row.Cells[7].Value.ToString())
                   );
                

            
            }         
            MessageBox.Show(mensaje);
            this.Close();
        
            }
        }


        private void txtDescuentoCab_TextChanged(object sender, EventArgs e)
        {
            if( txtDescuentoCab.Text!="")
            {
                txtTotalPagarCab.Text = (total - double.Parse(txtDescuentoCab.Text)).ToString(); 
            }
            else
            {
                MessageBox.Show("El descuento debe ser mínimo 0"); 
            } 
        }

        private void txtTotalCab_TextChanged(object sender, EventArgs e)
        {
            if (txtDescuentoCab.Text != "")
            {
                txtTotalPagarCab.Text = (total - double.Parse(txtDescuentoCab.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Indique el descuento");
            } 
        }


    }
}

