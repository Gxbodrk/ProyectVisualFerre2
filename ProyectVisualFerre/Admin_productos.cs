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
    public partial class Admin_productos : Form
    {
        public Admin_productos()
        {
            InitializeComponent();
        }
        
        //load
        private void Admin_productos_Load(object sender, EventArgs e)
        {

        }
        //fin load

        //Boton nuevo producto
        private void btn_mant_nuevo_Click(object sender, EventArgs e)
        {
            Admin_FormCrearEditar frm_crear = new Admin_FormCrearEditar();
            frm_crear.ShowDialog();
        }
        //fin boton crear producto

        //boton editar producto
        private void btn_mant_editar_Click(object sender, EventArgs e)
        {
            Admin_FormCrearEditar frm_editar = new Admin_FormCrearEditar();
            
            if (dgv_admin_productos.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Seleccione una fila para poder editar");
            }
        }
        //fin boton editar producto
    }
}
