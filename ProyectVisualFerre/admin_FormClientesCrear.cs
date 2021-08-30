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
    public partial class admin_FormClientesCrear : Form
    {
        public admin_FormClientesCrear()
        {
            InitializeComponent();
        }

        private void admin_FormClientesCrear_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txt_edad.Text = trackBar1.Value.ToString();
        }
    }
}
