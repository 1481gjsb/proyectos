using BL.proyecto;
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
    public partial class formproductos : Form
    {
        ProductosBL _productos;
        public formproductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _productos.obtenerproductos();
        }

        private void formproductos_Load(object sender, EventArgs e)
        {

        }
    }
}
