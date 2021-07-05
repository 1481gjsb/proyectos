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




        private void mantenimientoBL_manteniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            mantenimientoBL_manteniBindingSource.EndEdit();
            var mantenimiento = (Manteni)mantenimientoBL_manteniBindingSource.Current;

            var resultado = _mantenimient.Guardarmantenimiento(mantenimiento);

            if (resultado.Exitoso == true)
            {
                mantenimientoBL_manteniBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }



        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _mantenimient.Agregarmantenimiento();
            mantenimientoBL_manteniBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool Valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = Valor;
            bindingNavigatorMoveLastItem.Enabled = Valor;
            bindingNavigatorMovePreviousItem.Enabled = Valor;
            bindingNavigatorMoveNextItem.Enabled = Valor;
            bindingNavigatorPositionItem.Enabled = Valor;

            bindingNavigatorAddNewItem.Enabled = Valor;
            bindingNavigatorDeleteItem.Enabled = Valor;
            toolStripButtoncancelar.Visible = !Valor;
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")

            {
                var resultado = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                
                if (resultado == DialogResult.Yes)
               {
                var id = Convert.ToInt32(idTextBox.Text);
                Eliminar(id);
                }

            }
            
            
        }

        private void Eliminar(int id)
        {
            
            var Resultado = _mantenimient.Eliminarmantenimiento(id);

            if (Resultado == true)
            {
                mantenimientoBL_manteniBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }

        private void toolStripButtoncancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}
