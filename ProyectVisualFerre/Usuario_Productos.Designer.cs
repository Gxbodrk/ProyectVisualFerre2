
namespace ProyectVisualFerre
{
    partial class Usuario_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario_Productos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_BuscarProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_vs_ProdDescrp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_vs_ProdNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_vs_ProdEstado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_vs_ProdStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_vs_ProdPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_vs_ProdId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_carrito_AgregarProd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_usu_productos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usu_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(416, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "PRODUCTOS DISPONIBLES ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(386, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(375, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // txt_BuscarProd
            // 
            this.txt_BuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarProd.Location = new System.Drawing.Point(128, 31);
            this.txt_BuscarProd.Name = "txt_BuscarProd";
            this.txt_BuscarProd.Size = new System.Drawing.Size(250, 22);
            this.txt_BuscarProd.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Buscar producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Listado de productos:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_BuscarProd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(46, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 452);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgv_usu_productos);
            this.panel2.Location = new System.Drawing.Point(3, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 382);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_vs_ProdDescrp);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txt_vs_ProdNombre);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_vs_ProdEstado);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_vs_ProdStock);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_vs_ProdPrecio);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_vs_ProdId);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btn_carrito_AgregarProd);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(731, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 452);
            this.panel3.TabIndex = 16;
            // 
            // txt_vs_ProdDescrp
            // 
            this.txt_vs_ProdDescrp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_vs_ProdDescrp.Enabled = false;
            this.txt_vs_ProdDescrp.ForeColor = System.Drawing.Color.White;
            this.txt_vs_ProdDescrp.Location = new System.Drawing.Point(96, 293);
            this.txt_vs_ProdDescrp.Multiline = true;
            this.txt_vs_ProdDescrp.Name = "txt_vs_ProdDescrp";
            this.txt_vs_ProdDescrp.Size = new System.Drawing.Size(240, 24);
            this.txt_vs_ProdDescrp.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Descripción:";
            // 
            // txt_vs_ProdNombre
            // 
            this.txt_vs_ProdNombre.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_vs_ProdNombre.Enabled = false;
            this.txt_vs_ProdNombre.ForeColor = System.Drawing.Color.White;
            this.txt_vs_ProdNombre.Location = new System.Drawing.Point(96, 254);
            this.txt_vs_ProdNombre.Multiline = true;
            this.txt_vs_ProdNombre.Name = "txt_vs_ProdNombre";
            this.txt_vs_ProdNombre.Size = new System.Drawing.Size(121, 24);
            this.txt_vs_ProdNombre.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nombre:";
            // 
            // txt_vs_ProdEstado
            // 
            this.txt_vs_ProdEstado.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_vs_ProdEstado.Enabled = false;
            this.txt_vs_ProdEstado.ForeColor = System.Drawing.Color.White;
            this.txt_vs_ProdEstado.Location = new System.Drawing.Point(241, 340);
            this.txt_vs_ProdEstado.Multiline = true;
            this.txt_vs_ProdEstado.Name = "txt_vs_ProdEstado";
            this.txt_vs_ProdEstado.Size = new System.Drawing.Size(95, 24);
            this.txt_vs_ProdEstado.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(182, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Estado:";
            // 
            // txt_vs_ProdStock
            // 
            this.txt_vs_ProdStock.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_vs_ProdStock.Enabled = false;
            this.txt_vs_ProdStock.ForeColor = System.Drawing.Color.White;
            this.txt_vs_ProdStock.Location = new System.Drawing.Point(241, 210);
            this.txt_vs_ProdStock.Multiline = true;
            this.txt_vs_ProdStock.Name = "txt_vs_ProdStock";
            this.txt_vs_ProdStock.Size = new System.Drawing.Size(45, 24);
            this.txt_vs_ProdStock.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(182, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Stock:";
            // 
            // txt_vs_ProdPrecio
            // 
            this.txt_vs_ProdPrecio.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_vs_ProdPrecio.Enabled = false;
            this.txt_vs_ProdPrecio.ForeColor = System.Drawing.Color.White;
            this.txt_vs_ProdPrecio.Location = new System.Drawing.Point(74, 340);
            this.txt_vs_ProdPrecio.Multiline = true;
            this.txt_vs_ProdPrecio.Name = "txt_vs_ProdPrecio";
            this.txt_vs_ProdPrecio.Size = new System.Drawing.Size(77, 24);
            this.txt_vs_ProdPrecio.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Precio:";
            // 
            // txt_vs_ProdId
            // 
            this.txt_vs_ProdId.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_vs_ProdId.Enabled = false;
            this.txt_vs_ProdId.ForeColor = System.Drawing.Color.White;
            this.txt_vs_ProdId.Location = new System.Drawing.Point(73, 211);
            this.txt_vs_ProdId.Multiline = true;
            this.txt_vs_ProdId.Name = "txt_vs_ProdId";
            this.txt_vs_ProdId.Size = new System.Drawing.Size(44, 24);
            this.txt_vs_ProdId.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID:";
            // 
            // btn_carrito_AgregarProd
            // 
            this.btn_carrito_AgregarProd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_carrito_AgregarProd.FlatAppearance.BorderSize = 0;
            this.btn_carrito_AgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_carrito_AgregarProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_carrito_AgregarProd.ForeColor = System.Drawing.Color.White;
            this.btn_carrito_AgregarProd.Location = new System.Drawing.Point(123, 407);
            this.btn_carrito_AgregarProd.Name = "btn_carrito_AgregarProd";
            this.btn_carrito_AgregarProd.Size = new System.Drawing.Size(141, 31);
            this.btn_carrito_AgregarProd.TabIndex = 14;
            this.btn_carrito_AgregarProd.Text = "Añadir al carrito";
            this.btn_carrito_AgregarProd.UseVisualStyleBackColor = false;
            this.btn_carrito_AgregarProd.Click += new System.EventHandler(this.btn_carrito_AgregarProd_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(96, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 150);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Vista previa del producto";
            // 
            // dgv_usu_productos
            // 
            this.dgv_usu_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_usu_productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_usu_productos.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_usu_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_usu_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_usu_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usu_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_usu_productos.ColumnHeadersHeight = 25;
            this.dgv_usu_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_usu_productos.EnableHeadersVisualStyles = false;
            this.dgv_usu_productos.GridColor = System.Drawing.Color.Teal;
            this.dgv_usu_productos.Location = new System.Drawing.Point(-4, -1);
            this.dgv_usu_productos.Name = "dgv_usu_productos";
            this.dgv_usu_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usu_productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_usu_productos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_usu_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usu_productos.Size = new System.Drawing.Size(674, 382);
            this.dgv_usu_productos.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Usuario_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1095, 570);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuario_Productos";
            this.Text = "Usuario_Productos";
            this.Load += new System.EventHandler(this.Usuario_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usu_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_BuscarProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_carrito_AgregarProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_vs_ProdId;
        private System.Windows.Forms.TextBox txt_vs_ProdNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_vs_ProdEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_vs_ProdStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_vs_ProdPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_vs_ProdDescrp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_usu_productos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}