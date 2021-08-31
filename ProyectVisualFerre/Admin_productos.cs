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
    public partial class Admin_Productos : Form
    {
        public Admin_Productos()
        {
            InitializeComponent();
        }
        
        //load
        private void Admin_productos_Load(object sender, EventArgs e)
        {

        }
        //fin load

         //Boton nuevo producto
        private void btn_prod_nuevo_Click(object sender, EventArgs e)
        {
        
        }
        //fin boton

        //boton editar producto
        private void btn_prod_editar_Click(object sender, EventArgs e)
        {

            
        }
        //fin boton


        //Boton eliminar producto
        private void btn_prod_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_admin_productos.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Seleccione una fila para poder eliminar el producto");
            }
        }
        //fin boton

        

    }
}
