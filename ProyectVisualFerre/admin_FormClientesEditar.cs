using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectVisualFerre
{
    public partial class admin_FormClientesEditar : Form
    {
        public admin_FormClientesEditar()
        {
            InitializeComponent();
        }

        //Load formulario clientes
        private void admin_FormClientesEditar_Load(object sender, EventArgs e)
        {
            
        }
        //fin load

        //Track bar scroll edad
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txt_edad.Text = trackBar1.Value.ToString();
        }
    }
}
