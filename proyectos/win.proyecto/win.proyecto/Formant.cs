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
    public partial class Formant : Form
    {
        mantenimientoBL _mantenimient;
        public Formant()
        {
            InitializeComponent();

            _mantenimient = new mantenimientoBL();
            mantenimientoBL_manteniBindingSource.DataSource = _mantenimient.obtenermantenimientos();
        }
    }
}
