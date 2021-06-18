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
    public partial class formlogin : Form
    {
        seguridadBL _seguridad;

        public formlogin()
        {
            InitializeComponent();

            _seguridad = new seguridadBL();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void formlogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        internal static void showdialog()
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

          var resultado =  _seguridad.Autorizar(usuario, contrasena);

            if (resultado == true)
            {
                this.Close();
            }
            else
                {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
