using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectVisualFerre
{
    public partial class Registrarse_Usuario : Form
    {
        public Registrarse_Usuario()
        {
            InitializeComponent();
        }
        //PANEL SUPERIOR
        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximi_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btn_maximi.Visible = false;
            btn_restau.Visible = true;
        }

        private void btn_sale_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_restau_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1000, 600);
            btn_restau.Visible = false;
            btn_maximi.Visible = true;
        }

        //MOVER VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pl_barras_MouseClick(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //FIN MOVER VENTANA

        //FIN PANEL SUPERIOR

        private void pl_barras_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
