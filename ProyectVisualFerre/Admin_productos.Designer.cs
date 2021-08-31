
namespace ProyectVisualFerre
{
    partial class Admin_Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Productos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_dgv = new System.Windows.Forms.Panel();
            this.dgv_admin_productos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_buscarProd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_mant_eliminar = new System.Windows.Forms.Button();
            this.btn_mant_editar = new System.Windows.Forms.Button();
            this.btn_mant_anadir = new System.Windows.Forms.Button();
            this.pl_form_abrir_editar = new System.Windows.Forms.Panel();
            this.txt_ProdNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_PrecioVenta = new System.Windows.Forms.TextBox();
            this.txt_PrecioCompra = new System.Windows.Forms.TextBox();
            this.txt_descrp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnl_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pl_form_abrir_editar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(256, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO PRODUCTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de productos:";
            // 
            // pnl_dgv
            // 
            this.pnl_dgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_dgv.Controls.Add(this.dgv_admin_productos);
            this.pnl_dgv.Location = new System.Drawing.Point(50, 196);
            this.pnl_dgv.Name = "pnl_dgv";
            this.pnl_dgv.Size = new System.Drawing.Size(759, 267);
            this.pnl_dgv.TabIndex = 2;
            // 
            // dgv_admin_productos
            // 
            this.dgv_admin_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_admin_productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_admin_productos.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_admin_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_admin_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_admin_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_admin_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_admin_productos.ColumnHeadersHeight = 25;
            this.dgv_admin_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_admin_productos.EnableHeadersVisualStyles = false;
            this.dgv_admin_productos.GridColor = System.Drawing.Color.Teal;
            this.dgv_admin_productos.Location = new System.Drawing.Point(3, 3);
            this.dgv_admin_productos.Name = "dgv_admin_productos";
            this.dgv_admin_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_admin_productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_admin_productos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_admin_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_admin_productos.Size = new System.Drawing.Size(755, 263);
            this.dgv_admin_productos.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(815, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buscar producto:";
            // 
            // txt_buscarProd
            // 
            this.txt_buscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarProd.Location = new System.Drawing.Point(187, 164);
            this.txt_buscarProd.Name = "txt_buscarProd";
            this.txt_buscarProd.Size = new System.Drawing.Size(411, 22);
            this.txt_buscarProd.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_limpiar);
            this.panel2.Controls.Add(this.btn_mant_eliminar);
            this.panel2.Controls.Add(this.btn_mant_editar);
            this.panel2.Controls.Add(this.btn_mant_anadir);
            this.panel2.Location = new System.Drawing.Point(815, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 267);
            this.panel2.TabIndex = 10;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_limpiar.Location = new System.Drawing.Point(23, 183);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(90, 31);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // btn_mant_eliminar
            // 
            this.btn_mant_eliminar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_mant_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_mant_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mant_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mant_eliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_mant_eliminar.Location = new System.Drawing.Point(23, 135);
            this.btn_mant_eliminar.Name = "btn_mant_eliminar";
            this.btn_mant_eliminar.Size = new System.Drawing.Size(90, 31);
            this.btn_mant_eliminar.TabIndex = 2;
            this.btn_mant_eliminar.Text = "Eliminar";
            this.btn_mant_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_mant_editar
            // 
            this.btn_mant_editar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_mant_editar.FlatAppearance.BorderSize = 0;
            this.btn_mant_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mant_editar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mant_editar.ForeColor = System.Drawing.Color.White;
            this.btn_mant_editar.Location = new System.Drawing.Point(23, 89);
            this.btn_mant_editar.Name = "btn_mant_editar";
            this.btn_mant_editar.Size = new System.Drawing.Size(90, 31);
            this.btn_mant_editar.TabIndex = 1;
            this.btn_mant_editar.Text = "Editar";
            this.btn_mant_editar.UseVisualStyleBackColor = false;
            // 
            // btn_mant_anadir
            // 
            this.btn_mant_anadir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_mant_anadir.FlatAppearance.BorderSize = 0;
            this.btn_mant_anadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mant_anadir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mant_anadir.ForeColor = System.Drawing.Color.White;
            this.btn_mant_anadir.Location = new System.Drawing.Point(23, 43);
            this.btn_mant_anadir.Name = "btn_mant_anadir";
            this.btn_mant_anadir.Size = new System.Drawing.Size(90, 31);
            this.btn_mant_anadir.TabIndex = 0;
            this.btn_mant_anadir.Text = "Añadir";
            this.btn_mant_anadir.UseVisualStyleBackColor = false;
            // 
            // pl_form_abrir_editar
            // 
            this.pl_form_abrir_editar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pl_form_abrir_editar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_form_abrir_editar.Controls.Add(this.txt_ProdNombre);
            this.pl_form_abrir_editar.Controls.Add(this.label4);
            this.pl_form_abrir_editar.Controls.Add(this.cmb_estado);
            this.pl_form_abrir_editar.Controls.Add(this.cmb_marca);
            this.pl_form_abrir_editar.Controls.Add(this.cmb_categoria);
            this.pl_form_abrir_editar.Controls.Add(this.txt_stock);
            this.pl_form_abrir_editar.Controls.Add(this.txt_PrecioVenta);
            this.pl_form_abrir_editar.Controls.Add(this.txt_PrecioCompra);
            this.pl_form_abrir_editar.Controls.Add(this.txt_descrp);
            this.pl_form_abrir_editar.Controls.Add(this.label8);
            this.pl_form_abrir_editar.Controls.Add(this.label7);
            this.pl_form_abrir_editar.Controls.Add(this.label6);
            this.pl_form_abrir_editar.Controls.Add(this.label5);
            this.pl_form_abrir_editar.Controls.Add(this.label9);
            this.pl_form_abrir_editar.Controls.Add(this.label10);
            this.pl_form_abrir_editar.Controls.Add(this.label11);
            this.pl_form_abrir_editar.Location = new System.Drawing.Point(50, 469);
            this.pl_form_abrir_editar.Name = "pl_form_abrir_editar";
            this.pl_form_abrir_editar.Size = new System.Drawing.Size(908, 177);
            this.pl_form_abrir_editar.TabIndex = 11;
            // 
            // txt_ProdNombre
            // 
            this.txt_ProdNombre.Location = new System.Drawing.Point(132, 33);
            this.txt_ProdNombre.Name = "txt_ProdNombre";
            this.txt_ProdNombre.Size = new System.Drawing.Size(121, 20);
            this.txt_ProdNombre.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nombre:";
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "Disponible",
            "No disponible"});
            this.cmb_estado.Location = new System.Drawing.Point(757, 114);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(121, 21);
            this.cmb_estado.TabIndex = 21;
            // 
            // cmb_marca
            // 
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Items.AddRange(new object[] {
            "Truper",
            "DeWALT",
            "Lenox",
            "3M",
            "Sika",
            "Pintuco"});
            this.cmb_marca.Location = new System.Drawing.Point(757, 72);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(121, 21);
            this.cmb_marca.TabIndex = 20;
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Items.AddRange(new object[] {
            "Pinturas",
            "Tornillos",
            "Herramientas ",
            "Llaves"});
            this.cmb_categoria.Location = new System.Drawing.Point(757, 33);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(121, 21);
            this.cmb_categoria.TabIndex = 19;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(485, 115);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(60, 20);
            this.txt_stock.TabIndex = 15;
            // 
            // txt_PrecioVenta
            // 
            this.txt_PrecioVenta.Location = new System.Drawing.Point(485, 72);
            this.txt_PrecioVenta.Name = "txt_PrecioVenta";
            this.txt_PrecioVenta.Size = new System.Drawing.Size(121, 20);
            this.txt_PrecioVenta.TabIndex = 14;
            // 
            // txt_PrecioCompra
            // 
            this.txt_PrecioCompra.Location = new System.Drawing.Point(485, 33);
            this.txt_PrecioCompra.Name = "txt_PrecioCompra";
            this.txt_PrecioCompra.Size = new System.Drawing.Size(121, 20);
            this.txt_PrecioCompra.TabIndex = 13;
            // 
            // txt_descrp
            // 
            this.txt_descrp.Location = new System.Drawing.Point(15, 114);
            this.txt_descrp.Name = "txt_descrp";
            this.txt_descrp.Size = new System.Drawing.Size(322, 20);
            this.txt_descrp.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(637, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(365, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(365, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Precio Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(365, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio Compra:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(637, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Marca:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(637, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Categoría:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Descripción:";
            // 
            // Admin_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(980, 670);
            this.Controls.Add(this.pl_form_abrir_editar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_buscarProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnl_dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Productos";
            this.Text = "Admin_productos";
            this.Load += new System.EventHandler(this.Admin_productos_Load);
            this.pnl_dgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pl_form_abrir_editar.ResumeLayout(false);
            this.pl_form_abrir_editar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_buscarProd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_admin_productos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_mant_eliminar;
        private System.Windows.Forms.Button btn_mant_editar;
        private System.Windows.Forms.Button btn_mant_anadir;
        private System.Windows.Forms.Panel pl_form_abrir_editar;
        public System.Windows.Forms.TextBox txt_ProdNombre;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmb_estado;
        public System.Windows.Forms.ComboBox cmb_marca;
        public System.Windows.Forms.ComboBox cmb_categoria;
        public System.Windows.Forms.TextBox txt_stock;
        public System.Windows.Forms.TextBox txt_PrecioVenta;
        public System.Windows.Forms.TextBox txt_PrecioCompra;
        public System.Windows.Forms.TextBox txt_descrp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}