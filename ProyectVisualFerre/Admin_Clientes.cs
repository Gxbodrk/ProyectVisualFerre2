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
    public partial class Admin_Clientes : Form
    {
        public Admin_Clientes()
        {
            InitializeComponent();
        }

        //Load
        private void Admin_Clientes_Load(object sender, EventArgs e)
        {

        }
        //Fin Load

        //Boton añadir cliente
        private void btn_mant_anadir_Click(object sender, EventArgs e)
        {
            admin_FormClientesEditar frm_crear_clt = new admin_FormClientesEditar();
            frm_crear_clt.ShowDialog();
        }
        //Fin boton añadir cliente

        //Boton editar cliente
        private void btn_mant_editar_Click(object sender, EventArgs e)
        {
            admin_FormClientesEditar frm_editar_clt = new admin_FormClientesEditar();

            if (dgv_admin_clientes.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Seleccione una fila para poder editar un usuario");
            }
        }
        //Fin boton editar cliente

        //Boton eliminar cliente
        private void btn_clt_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_admin_clientes.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Seleccione una fila para poder eliminar el usuario");
            }
        }
        //fin boton eliminar cliente
    }
}
