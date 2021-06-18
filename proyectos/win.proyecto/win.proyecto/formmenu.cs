using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win.proyecto
{
    public partial class formmenu : Form
    {
        public formmenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Formlogin = new formlogin();
            Formlogin.ShowDialog();
        }

        private void inicioDeSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formalogin = new formlogin();
            formalogin.ShowDialog();
          
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproducto = new formproductos();
            formproducto.MdiParent = this;
            formproducto.Show();

        }

        private void reporteProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formanten = new Formant();
            formanten.MdiParent = this;
            formanten.Show();
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formclientes = new Formclient();
            formclientes.MdiParent = this;
            formclientes.Show();
        }

        private void transaccionesDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formtrandiass = new Formtrandia();
            formtrandiass.MdiParent = this;
            formtrandiass.Show();
        }

        private void reportesContabilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formcontabilidad = new Formconta();
            formcontabilidad.MdiParent = this;
            formcontabilidad.Show();
        }

        private void reportesDePlanillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formplan = new Formplanilla();
            formplan.MdiParent = this;
            formplan.Show();
        }

        private void reportesProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formpro = new Formprod();
            formpro.MdiParent = this;
            formpro.Show();
        }
    }
}
