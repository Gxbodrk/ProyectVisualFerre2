using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectVisualFerre
{
    public partial class Ventana_Usuario : Form
    {
        public Ventana_Usuario()
        {
            InitializeComponent();
        }

        //LOAD
        private void Ventana_Usuario_Load(object sender, EventArgs e)
        {
            btn_carrito_slide_Click(null, e);
            btn_inicio_ferre_Click(null, e);
        }
        //FIN LOAD

        //PANEL SUPERIOR
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btn_max.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1220, 600);
            btn_restaurar.Visible = false;
            btn_max.Visible = true;
        }

        //MOVER VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pl_barra_superior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
            
        //FIN MOVER VENTANA

        //FIN PANEL SUPERIOR

        //FUNCION CON UN OBJETO abrir formulario hija 
        private void Abrir_form_hija(object form_hija)
        {
            if (this.pl_contenedor.Controls.Count > 0)

                this.pl_contenedor.Controls.RemoveAt(0);
            Form frm_hija = form_hija as Form;
            frm_hija.TopLevel = false;
            frm_hija.Dock = DockStyle.Fill;
            //agregamos al panel
            this.pl_contenedor.Controls.Add(frm_hija);
            this.pl_contenedor.Tag = frm_hija;
            //mostramos
            frm_hija.Show();

        }
        //FIN FUNCION

        //Imagen ferre
        private void btn_inicio_ferre_Click(object sender, EventArgs e)
        {
            Abrir_form_hija(new Usuario_Inicio());
        }

        //Imagen logo
        private void btn_inicio_logo_Click(object sender, EventArgs e)
        {
            Abrir_form_hija(new Usuario_Inicio());
        }
        //fin botones

        //Mostrar menu
        private void btn_menu_slide_Click(object sender, EventArgs e)
        {
            if (pl_menu_izq.Width == 220)
            {
                pl_menu_izq.Width = 65;
            }
            else
            {
                pl_menu_izq.Width = 220;
            }
        }
        //Boton salir
        private void btn_salir_Click(object sender, EventArgs e)
        {
            //aqui poner para regresar al login
            //Application.Exit();
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        //Fin menu

        //Menu carrito
        private void btn_carrito_slide_Click(object sender, EventArgs e)
        {
            if (pl_derch_carrito.Width == 220)
            {
                pl_derch_carrito.Width = 1;
            }
            else
            {
                pl_derch_carrito.Width = 220;
            }
        }
        //Fin menu


        private void btn_usu_prod_Click(object sender, EventArgs e)
        {
            btn_menu_slide_Click(null, e);
            Abrir_form_hija(new Usuario_Productos());

        }

        private void btn_usu_estadi_Click(object sender, EventArgs e)
        {
            btn_menu_slide_Click(null, e);
        }

        private void btn_usu_compb_Click(object sender, EventArgs e)
        {
            btn_menu_slide_Click(null, e);
        }
    }
}
