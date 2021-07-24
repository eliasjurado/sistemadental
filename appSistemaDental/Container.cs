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
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacienteListar f = new PacienteListar();
            f.MdiParent = this;
            f.Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PacienteRegistrar f = new PacienteRegistrar();
            f.MdiParent = this;
            f.Show();
        }

        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PacienteActualizar f = new PacienteActualizar();
            f.MdiParent = this;
            f.Show();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PacienteEliminar f = new PacienteEliminar();
            f.MdiParent = this;
            f.Show();
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TratamientoListar f = new TratamientoListar();
            f.MdiParent = this;
            f.Show();
        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TratamientoRegistrar f = new TratamientoRegistrar();
            f.MdiParent = this;
            f.Show();
        }

        private void actualizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TratamientoActualizar f = new TratamientoActualizar();
            f.MdiParent = this;
            f.Show();
        }

        private void eliminarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Tratamiento.TratamientoEliminar f = new Tratamiento.TratamientoEliminar();
            f.MdiParent = this;
            f.Show();
        }



        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Boleta.BoletaListar f = new Boleta.BoletaListar();
            f.MdiParent = this;
            f.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atencion.AtencionRegistrar f = new Atencion.AtencionRegistrar();
            f.MdiParent = this;
            f.Show();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial.HistorialConsultar f = new Historial.HistorialConsultar();
            f.MdiParent = this;
            f.Show();
        }

        private void listadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Pago.PagoRegistrar f = new Pago.PagoRegistrar();
            f.MdiParent = this;
            f.Show();
        }

        private void listadoPorPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pago.PagoListar f = new Pago.PagoListar();
            f.MdiParent = this;
            f.Show();
        }

        private void registrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Pago.PagoEliminar f = new Pago.PagoEliminar();
            f.MdiParent = this;
            f.Show();
        }



    }
}
