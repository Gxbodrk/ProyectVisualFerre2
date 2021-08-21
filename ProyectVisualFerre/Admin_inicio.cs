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
    public partial class Admin_Inicio : Form
    {
        public Admin_Inicio()
        {
            InitializeComponent();
        }

        private void tm_hora_fecha_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_fecha.Text = DateTime.Now.ToString("dddd MMMM yyy");
        }

        private void Admin_Inicio_Load(object sender, EventArgs e)
        {
            //lbl_hora.Text = DateTime.Now.ToString();
            //lbl_fecha.Text = DateTime.Now.ToString();
            tm_hora_fecha_Tick(null, e);
        }

    }
}
