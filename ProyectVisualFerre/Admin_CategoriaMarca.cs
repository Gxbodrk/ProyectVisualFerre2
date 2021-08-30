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
    public partial class Admin_CategoriaMarca : Form
    {
        public Admin_CategoriaMarca()
        {
            InitializeComponent();
        }

        private void Admin_CategoriaMarca_Load(object sender, EventArgs e)
        {

        }

        private void btn_catg_anadir_Click(object sender, EventArgs e)
        {
            admin_FormCatgCrear frm_crear_catg = new admin_FormCatgCrear();
            frm_crear_catg.ShowDialog();
        }

        private void btn_catg_editar_Click(object sender, EventArgs e)
        {
            admin_FormCatgEdit frm_editar_catg = new admin_FormCatgEdit();
            frm_editar_catg.ShowDialog();
            //if (dgv_admin_catg.SelectedRows.Count > 0)
            //{
            //    admin_FormCatgEdit frm_editar_catg = new admin_FormCatgEdit);
            //    frm_editar_catg.ShowDialog();

            //}
            //else
            //{
            //    MessageBox.Show("Seleccione una fila para poder editar una categoría");
            //}
        }

        private void btn_catg_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_admin_catg.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Seleccione una fila para poder eliminar la categoría");
            }
        }

        private void btn_mc_anadir_Click(object sender, EventArgs e)
        {
            admin_FormMcCrear frm_crear_mc = new admin_FormMcCrear();
            frm_crear_mc.ShowDialog();
        }

        private void btn_mc_editar_Click(object sender, EventArgs e)
        {
            admin_FormMcEdit frm_editar_mc = new admin_FormMcEdit();
            frm_editar_mc.ShowDialog();
            //if (dgv_admin_marca.SelectedRows.Count > 0)
            //{
            //    admin_FormMcEdit frm_editar_mc = new admin_FormMcEdit();
            //    frm_editar_mc.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione una fila para poder editar una marca");
            //}

        }

        private void btn_mc_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_admin_marca.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Seleccione una fila para poder eliminar la marca");
            }
        }
    }
}
