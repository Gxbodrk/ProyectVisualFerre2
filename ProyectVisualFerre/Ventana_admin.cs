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
    public partial class Ventana_admin : Form
    {
        public Ventana_admin()
        {
            InitializeComponent();
        }

        //LOAD
        private void Ventana_admin_Load(object sender, EventArgs e)
        {
            //btn_inicio_logo(null ,e);
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

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size (1000, 600); 
            btn_restaurar.Visible = false;
            btn_max.Visible = true;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        //BOTONES IMAGEN INICIO
        //Imagen ferre
        private void btn_inicio_ferre_Click(object sender, EventArgs e)
        {
            Abrir_form_hija(new Admin_Inicio());
        }
        //Imagen logo
        private void btn_inicio_logo_Click(object sender, EventArgs e)
        {
            Abrir_form_hija(new Admin_Inicio());
        }
        //FIN BOTONES INICIO

        //mostrar menu
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
        //fin mostrar menu

        //BOTON IMAGEN SALIR
        private void btn_salir_Click(object sender, EventArgs e)
        {
            //aqui poner para regresar al login
            Application.Exit();
        }
        //FIN SALIR

        //FUNCION CON UN OBJETO abrir formulario hija 
        private void Abrir_form_hija (object form_hija)
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

        //BOTON ADMIN PRODUCTOS
        private void btn_admin_prod_Click(object sender, EventArgs e)
        {
            //llamar a la funcion y envimos como parametro declarando un nuevo objeto 
            Abrir_form_hija(new Admin_Productos());
        }
        //FIN ADMIN BOTON PRODUCTOS

        //BOTON ADMIN CLIENTES
        private void btn_admin_clt_Click(object sender, EventArgs e)
        {
            Abrir_form_hija(new Admin_Clientes());
        }
        //FIN BOTON ADMIN CLIENTES

        //BOTON ADMIN ESTADISTICAS
        private void btn_admin_estadi_Click(object sender, EventArgs e)
        {
            Abrir_form_hija(new Admin_Estadisticas());
        }
        //FIN BOTON ADMIN ESTADISTICAS
        private void pl_barra_superior_Paint(object sender, PaintEventArgs e)
        {

        }
        



    }
}
