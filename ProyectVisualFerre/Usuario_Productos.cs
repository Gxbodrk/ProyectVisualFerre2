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
    public partial class Usuario_Productos : Form
    {
        public Usuario_Productos()
        {
            InitializeComponent();
        }

        private void Usuario_Productos_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_carrito_AgregarProd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Añadido Exitosamente");
            txt_vs_ProdNombre.Text = txt_vs_ProdDescrp.Text = txt_vs_ProdId.Text = txt_vs_ProdStock.Text = txt_vs_ProdPrecio.Text = txt_vs_ProdEstado.Text = " ";
        }
    }
}
