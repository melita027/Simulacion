using Simulacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Simuacion
{
    public partial class FormMediosCuadrados : Form
    {
        public FormMediosCuadrados()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                CuadradosMedios medios = new CuadradosMedios();
                medios.calularNumeros(tbxSemilla.Text, Convert.ToInt16(tbxDigitos.Text), Convert.ToInt16(tbxCantidadNumeros.Text), dataGridView1);
            }catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            tbxSemilla.Text = null;
            tbxDigitos.Text = null;
            tbxCantidadNumeros.Text = null;
        }
    }
}
