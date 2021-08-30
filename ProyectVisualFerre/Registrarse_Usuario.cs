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
    public partial class Registrarse_Usuario : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LoginMovilCB.mssql.somee.com;Initial Catalog=LoginMovilCB;Persist Security Info=True;User ID=joseruiz_SQLLogin_1;Password=v31usdbjx1");
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void txt_prinombre_Enter(object sender, EventArgs e)
        {
            if (txt_prinombre.Text == "Primer nombre")
            {
                txt_prinombre.Text = "";
                txt_prinombre.ForeColor = Color.Black;
            }
        }

        private void txt_segnombre_Enter(object sender, EventArgs e)
        {
            if (txt_segnombre.Text == "Segundo nombre")
            {
                txt_segnombre.Text = "";
                txt_segnombre.ForeColor = Color.Black;
            }
        }

        private void txt_priapellido_Enter(object sender, EventArgs e)
        {
            if (txt_priapellido.Text == "Primer apellido")
            {
                txt_priapellido.Text = "";
                txt_priapellido.ForeColor = Color.Black;
            }
        }

        private void txt_segapellido_Enter(object sender, EventArgs e)
        {
            if (txt_segapellido.Text == "Segundo apellido")
            {
                txt_segapellido.Text = "";
                txt_segapellido.ForeColor = Color.Black;
            }
        }

        private void txt_cedula_Enter(object sender, EventArgs e)
        {
            if (txt_cedula.Text == "Cedula ")
            {
                txt_cedula.Text = "";
                txt_cedula.ForeColor = Color.Black;
            }
        }

        private void txt_edad_Enter(object sender, EventArgs e)
        {
            if (txt_edad.Text == "Edad")
            {
                txt_edad.Text = "";
                txt_edad.ForeColor = Color.Black;
            }
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "Usuario")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.Black;
            }
        }

        private void txt_clave_Enter(object sender, EventArgs e)
        {
            if (txt_clave.Text == "Contraseña")
            {
                txt_clave.Text = "";
                txt_clave.ForeColor = Color.Black;
                txt_clave.UseSystemPasswordChar = true;
            }
        }

        private void txt_clavenueva_Enter(object sender, EventArgs e)
        {
            if (txt_clavenueva.Text == "Repita contra")
            {
                txt_clavenueva.Text = "";
                txt_clavenueva.ForeColor = Color.Black;
                txt_clavenueva.UseSystemPasswordChar = true;
            }
        }

        private void txt_direccion_Enter(object sender, EventArgs e)
        {
            if (txt_direccion.Text == "Direccion")
            {
                txt_direccion.Text = "";
                txt_direccion.ForeColor = Color.Black;
            }
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                txt_email.Text = "";
                txt_email.ForeColor = Color.Black;
            }
        }

        private void txt_prinombre_Leave(object sender, EventArgs e)
        {
            if (txt_prinombre.Text == "")
            {
                txt_prinombre.Text = "Primer nombre";
                txt_prinombre.ForeColor = Color.DarkGray;
            }
        }

        private void txt_segnombre_Leave(object sender, EventArgs e)
        {
            if (txt_segnombre.Text == "")
            {
                txt_segnombre.Text = "Segundo nombre";
                txt_segnombre.ForeColor = Color.DarkGray;
            }
        }

        private void txt_priapellido_Leave(object sender, EventArgs e)
        {
            if (txt_priapellido.Text == "")
            {
                txt_priapellido.Text = "Primer apellido";
                txt_priapellido.ForeColor = Color.DarkGray;
            }
        }

        private void txt_segapellido_Leave(object sender, EventArgs e)
        {
            if (txt_segapellido.Text == "")
            {
                txt_segapellido.Text = "Segundo apellido";
                txt_segapellido.ForeColor = Color.DarkGray;
            }
        }

        private void txt_cedula_Leave(object sender, EventArgs e)
        {
            if (txt_cedula.Text == "")
            {
                txt_cedula.Text = "Cedula ";
                txt_cedula.ForeColor = Color.DarkGray;
            }
        }

        private void txt_telefono_Leave(object sender, EventArgs e)
        {
            if (txt_telefono.Text == "")
            {
                txt_telefono.Text = "Telefono celular";
                txt_telefono.ForeColor = Color.DarkGray;
            }
        }

        private void txt_edad_Leave(object sender, EventArgs e)
        {
            if (txt_edad.Text == "")
            {
                txt_edad.Text = "Edad";
                txt_edad.ForeColor = Color.DarkGray;
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "Usuario";
                txt_usuario.ForeColor = Color.DarkGray;
            }
        }

        private void txt_clave_Leave(object sender, EventArgs e)
        {
            if (txt_clave.Text == "")
            {
                txt_clave.Text = "Contraseña";
                txt_clave.ForeColor = Color.DarkGray;
                txt_clave.UseSystemPasswordChar = false;
            }
        }

        private void txt_clavenueva_Leave(object sender, EventArgs e)
        {
            if (txt_clavenueva.Text == "")
            {
                txt_clavenueva.Text = "Repita contra";
                txt_clavenueva.ForeColor = Color.DarkGray;
                txt_clavenueva.UseSystemPasswordChar = false;
            }
        }

        private void txt_direccion_Leave(object sender, EventArgs e)
        {
            if (txt_direccion.Text == "")
            {
                txt_direccion.Text = "Direccion";
                txt_direccion.ForeColor = Color.DarkGray;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                txt_email.ForeColor = Color.DarkGray;
            }
        }

        private void txt_telefono_Enter(object sender, EventArgs e)
        {
            if (txt_telefono.Text == "Telefono celular")
            {
                txt_telefono.Text = "";
                txt_telefono.ForeColor = Color.Black;
            }
        }

        //Metodo para limpiar todo
        private void limpiar()
        {
            txt_prinombre.Text = "Primer nombre";
            txt_prinombre.ForeColor = Color.DarkGray;
            txt_segnombre.Text = "Segundo nombre";
            txt_segnombre.ForeColor = Color.DarkGray;
            txt_priapellido.Text = "Primer apellido";
            txt_priapellido.ForeColor = Color.DarkGray;
            txt_segapellido.Text = "Segundo apellido";
            txt_segapellido.ForeColor = Color.DarkGray;
            txt_cedula.Text = "Cedula ";
            txt_cedula.ForeColor = Color.DarkGray;
            txt_telefono.Text = "Telefono celular";
            txt_telefono.ForeColor = Color.DarkGray;
            txt_edad.Text = "Edad";
            txt_edad.ForeColor = Color.DarkGray;
            txt_usuario.Text = "Usuario";
            txt_usuario.ForeColor = Color.DarkGray;
            txt_clave.Text = "Contraseña";
            txt_clave.ForeColor = Color.DarkGray;
            txt_clave.UseSystemPasswordChar = false;
            txt_clavenueva.Text = "Repita contra";
            txt_clavenueva.ForeColor = Color.DarkGray;
            txt_clavenueva.UseSystemPasswordChar = false;
            txt_direccion.Text = "Direccion";
            txt_direccion.ForeColor = Color.DarkGray;
            txt_email.Text = "Email";
            txt_email.ForeColor = Color.DarkGray;
        }

        private void Registrarse( string prinombre, string segnombre, string priapellido, string segapellido, string cedula, string telefono, string edad, string usuario, string clave, string direccion, string email)
        {
            if (txt_clave.Text == txt_clavenueva.Text)
            {
                //Llamamos a la funcion y guardamos los valores
                con.Open();
                string query = "INSERT INTO tbl_registrousuario values(@prinombre,@prinombre,@priapellido,@segapellido,@cedula,@direccion,@telefono,@usuario,dbo.EncriptarPass(@clave),'A',@edad,@email,2)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@prinombre", txt_prinombre.Text.Trim());
                cmd.Parameters.AddWithValue("@segnombre", txt_segnombre.Text.Trim());
                cmd.Parameters.AddWithValue("@priapellido", txt_priapellido.Text.Trim());
                cmd.Parameters.AddWithValue("@segapellido", txt_segapellido.Text.Trim());
                cmd.Parameters.AddWithValue("@cedula", txt_cedula.Text.Trim());
                cmd.Parameters.AddWithValue("@telefono", txt_telefono.Text.Trim());
                cmd.Parameters.AddWithValue("@edad", txt_edad.Text.Trim());
                cmd.Parameters.AddWithValue("@usuario", txt_usuario.Text.Trim());
                cmd.Parameters.AddWithValue("@clave", txt_clave.Text.Trim());
                cmd.Parameters.AddWithValue("@direccion", txt_direccion.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txt_email.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuario guardado exitosamente ...!");
                limpiar();
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            //Validamos para q no ingrese campos vacion
            if (txt_prinombre.Text == "Primer nombre" || txt_segnombre.Text == "Segundo nombre" || txt_priapellido.Text == "Primer apellido" || txt_segapellido.Text == "Segundo apellido" || txt_cedula.Text == "Cedula" || txt_telefono.Text == "Telefono celular" || txt_edad.Text == "Edad" || txt_usuario.Text == "Usuarios" || txt_clave.Text == "Contraseña" || txt_clavenueva.Text == "Repita contra" || txt_direccion.Text == "Direccion" || txt_email.Text == "Email")
            {
                txt_prinombre.Text = "Primer nombre";
                txt_prinombre.ForeColor = Color.DarkGray;
                txt_segnombre.Text = "Segundo nombre";
                txt_segnombre.ForeColor = Color.DarkGray;
                txt_priapellido.Text = "Primer apellido";
                txt_priapellido.ForeColor = Color.DarkGray;
                txt_segapellido.Text = "Segundo apellido";
                txt_segapellido.ForeColor = Color.DarkGray;
                txt_cedula.Text = "Cedula ";
                txt_cedula.ForeColor = Color.DarkGray;
                txt_telefono.Text = "Telefono celular";
                txt_telefono.ForeColor = Color.DarkGray;
                txt_edad.Text = "Edad";
                txt_edad.ForeColor = Color.DarkGray;
                txt_usuario.Text = "Usuario";
                txt_usuario.ForeColor = Color.DarkGray;
                txt_clave.Text = "Contraseña";
                txt_clave.ForeColor = Color.DarkGray;
                txt_clave.UseSystemPasswordChar = false;
                txt_clavenueva.Text = "Repita contra";
                txt_clavenueva.ForeColor = Color.DarkGray;
                txt_clavenueva.UseSystemPasswordChar = false;
                txt_direccion.Text = "Direccion";
                txt_direccion.ForeColor = Color.DarkGray;
                txt_email.Text = "Email";
                txt_email.ForeColor = Color.DarkGray;
                MessageBox.Show("Ingrese datos en los campos");
            }
            else
            {
                Registrarse(txt_prinombre.Text, txt_segnombre.Text, txt_priapellido.Text, txt_segapellido.Text, txt_cedula.Text, txt_telefono.Text, txt_edad.Text, txt_usuario.Text, txt_clave.Text, txt_direccion.Text, txt_email.Text);
            }
        }

        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validamos la cedula
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validamos la cedula
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validamos la cedula
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
