using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;//libreria para poder mover la ventana
using Proyecto_Simuacion;

namespace Simulacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Maximized;
            btnMaximizar.Visible= false;
            btnRestaurar.Visible= true;    
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible= false;
            btnMaximizar.Visible= true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int Msg, int wParam, int lParam);

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); 
        }
        private void AbrirFormijo(object formHijo)//funcion para abrir el formulario en el panel 
        {
            if(this.panelContenedor.Controls.Count > 0) this.panelContenedor.Controls.RemoveAt(0);//Si existe un control en el panel lo eliminamos
            Form fh=formHijo as Form;
            fh.TopLevel = false;//no es un formulario de nivel superior
            fh.Dock=DockStyle.Fill;//para que se acople al panel
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag= fh;
            fh.Show();
        }

        private void btnCuadradosMedios_Click(object sender, EventArgs e)
        {
            AbrirFormijo(new FormMediosCuadrados());
        }

        private void btnProductosMedios_Click(object sender, EventArgs e)
        {
            AbrirFormijo(new FormProductosMedios());
        }
    }
}
