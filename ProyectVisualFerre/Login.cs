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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //PANEL SUPERIOR
        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btn_maximizar.Visible = false;
            btn_resta.Visible = true;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1000, 600);
            btn_resta.Visible = false;
            btn_maximizar.Visible = true;
        }

        //MOVER VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void pl_barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //FIN MOVER VENTANA

        //FIN PANEL SUPERIOR

        //Limpia las letras de la vista
        private void txt_usu_Enter(object sender, EventArgs e)
        {
            if (txt_usu.Text == "Usuario")
            {
                txt_usu.Text = "";
                txt_usu.ForeColor = Color.Black;
            }
        }

        private void txt_usu_Leave(object sender, EventArgs e)
        {
            if (txt_usu.Text=="")
            {
                txt_usu.Text = "Usuario";
                txt_usu.ForeColor = Color.LightGray;
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Password")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.Black;
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "Password";
                txt_pass.ForeColor = Color.LightGray;
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Ventana_admin admin = new Ventana_admin();
            admin.Show();
            this.Hide();
        }

        private void lkl_regis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrarse_Usuario registrarse = new Registrarse_Usuario();
            registrarse.Show();
            this.Hide();
        }
    }
}
