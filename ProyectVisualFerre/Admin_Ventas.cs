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
    public partial class Admin_Ventas : Form
    {
        public Admin_Ventas()
        {
            InitializeComponent();
        }

        private void Admin_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_vent_comprobvi_Click(object sender, EventArgs e)
        {
            admin_FormComprobanteVenta frm_ver_comp = new admin_FormComprobanteVenta();
            frm_ver_comp.ShowDialog();

            //if (dgv_admin_clientes.SelectedRows.Count > 0)
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Seleccione una fila para poder visualizar el comprobante");
            //}
        }

        private void btn_vent_comprobElim_Click(object sender, EventArgs e)
        {

            if (dgv_comp_vent.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Seleccione una fila para poder eliminar el comprobante");
            }
        }
    }
}
