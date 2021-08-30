using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        //Declaracion de variables
        int cont = 1;
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
            if (txt_usuario.Text == "Usuario")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.Black;
            }
        }

        private void txt_usu_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text=="")
            {
                txt_usuario.Text = "Usuario";
                txt_usuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Contraseña")
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

        public void logear(string nombre, string passw)
        {
            try
            {
                //Llamamos a la consulta y verificamos el primer paso 
                string sql = "select * from tbl_registrousuario where reg_usuario = @nom ";
                SqlCommand cmd = new SqlCommand(sql, ConexionBD.Conectar());
                cmd.Parameters.AddWithValue("@nom", nombre);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {

                    //Llamamos a la consulta y verificamos el segundo paso
                    string sql1 = "select reg_primnombre, rol_id, reg_estado from tbl_registrousuario where reg_usuario = @nom and dbo.DesencriptarPass(reg_password)=@pass";
                    SqlCommand cmd1 = new SqlCommand(sql1, ConexionBD.Conectar());
                    cmd1.Parameters.AddWithValue("@nom", nombre);
                    cmd1.Parameters.Add(new SqlParameter("@pass", Encoding.ASCII.GetBytes(passw)));
                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    if (dt1.Rows.Count == 1)
                    {
                        this.Hide();
                        if (dt1.Rows[0][2].ToString() == "I")
                        {
                            //Si el usuario esta bloqueado no nos permitira ingresar
                            MessageBox.Show("Usuario bloqueado comuniquese con el administrador....");
                            txt_usuario.Clear();
                            txt_pass.Clear();
                            Close();
                        }
                        else
                        {
                            this.Hide();
                            if (dt1.Rows[0][1].ToString() == "1")
                            {
                                //Ingresa a la ventana del administrador
                                new Ventana_admin().ShowDialog();

                            }
                            else if (dt1.Rows[0][1].ToString() == "2")
                            {
                                //Ingresa a la ventana del usuario
                                new Ventana_Usuario().ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        //Llamamos a la consulta y verificamos el primer paso 
                        string sql4 = "select * from tbl_registrousuario where reg_usuario = @nom and reg_estado='I'";
                        SqlCommand cmd4 = new SqlCommand(sql4, ConexionBD.Conectar());
                        cmd4.Parameters.AddWithValue("@nom", nombre);
                        SqlDataAdapter sda4 = new SqlDataAdapter(cmd4);
                        DataTable dt4 = new DataTable();
                        sda4.Fill(dt4);
                        if (dt4.Rows.Count == 1)
                        {
                            //Si el usuario esta bloqueado no nos permitira ingresar
                            MessageBox.Show("Usuario bloqueado comuniquese con el administrador....");
                            txt_usuario.Clear();
                            txt_pass.Clear();
                            Close();
                        }
                        else
                        {
                            //Mostramos un mensaje si la contraseña es incorrecta y a los tres intentos se bloquea
                            MessageBox.Show("Contraseña no existe ...");
                            txt_pass.Text = "Contraseña";
                            txt_pass.ForeColor = Color.DimGray;
                            txt_pass.UseSystemPasswordChar = false;
                            lbl_inten.Text = cont.ToString();
                            cont++;
                            if (lbl_inten.Text == "3")
                            {
                                //Llamamos a la consulta para poner inactivo al usuario si llega a los tres intentos
                                string sql2 = "UPDATE tbl_registrousuario SET reg_estado = 'I' WHERE reg_usuario = '" + txt_usuario.Text.Trim() + "'";
                                SqlCommand comando = new SqlCommand(sql2, ConexionBD.Conectar());
                                int cant;
                                cant = comando.ExecuteNonQuery();
                                if (cant == 1)
                                {
                                    MessageBox.Show("Maximo intentos posibles USUARIO BLOQUEADO");
                                    btn_ingresar.Enabled = false;
                                    Close();
                                }
                            }
                        }

                    }

                }
                else
                {
                    //Mensaje si no existe el usuario y limpiamos los texbox
                    MessageBox.Show("Usuario y contraseña no existe");
                    txt_usuario.Text = "Usuario";
                    txt_usuario.ForeColor = Color.DimGray;
                    txt_pass.Text = "Contraseña";
                    txt_pass.ForeColor = Color.DimGray;
                    txt_pass.UseSystemPasswordChar = false;

                }

            }
            catch (IndexOutOfRangeException)
            {
                throw;

            }
        }


        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //Validamos para q no ingrese campos vacion
            if (txt_usuario.Text == "" || txt_pass.Text == "")
            {
                txt_usuario.Text = "Usuario";
                txt_usuario.ForeColor = Color.DimGray;
                txt_pass.Text = "Contraseña";
                txt_pass.ForeColor = Color.DimGray;
                txt_pass.UseSystemPasswordChar = false;
                MessageBox.Show("Ingrese datos en los campos");
            }
            else
            {

                logear(txt_usuario.Text, txt_pass.Text);
            }
        }

        private void lkl_regis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrarse_Usuario registrarse = new Registrarse_Usuario();
            registrarse.Show();
            this.Hide();
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Codigo para acceder a la tecla enter 
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //Validamos para q no ingrese campos vacion
                if (txt_usuario.Text == "" || txt_pass.Text == "")
                {
                    MessageBox.Show("Ingrese datos en los campos");

                }
                else
                {
                    logear(txt_usuario.Text, txt_pass.Text);
                }
            }
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Codigo para acceder a la tecla enter 
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //Validamos para q no ingrese campos vacion
                if (txt_usuario.Text == "" || txt_pass.Text == "")
                {
                    MessageBox.Show("Ingrese datos en los campos");

                }
                else
                {
                    logear(txt_usuario.Text, txt_pass.Text);
                }
            }
        }
    }
}
