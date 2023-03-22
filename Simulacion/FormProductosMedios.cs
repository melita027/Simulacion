using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion
{
    public partial class FormProductosMedios : Form
    {
        public FormProductosMedios()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                ProductosMedios medios = new ProductosMedios();
                medios.calularNumeros(tbxSemilla1.Text,tbxSemilla2.Text,Convert.ToInt16(tbxCantidadNumeros.Text), dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            tbxSemilla1.Text = null;
            tbxSemilla2.Text = null;
            tbxCantidadNumeros.Text = null;
        }
    }
}
