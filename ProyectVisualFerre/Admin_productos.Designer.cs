
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Productos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_admin_productos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_prod_eliminar = new System.Windows.Forms.Button();
            this.btn_mant_editar = new System.Windows.Forms.Button();
            this.btn_mant_nuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_productos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 59);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_admin_productos);
            this.panel1.Location = new System.Drawing.Point(50, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 357);
            this.panel1.TabIndex = 2;
            // 
            // dgv_admin_productos
            // 
            this.dgv_admin_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin_productos.Location = new System.Drawing.Point(0, 0);
            this.dgv_admin_productos.Name = "dgv_admin_productos";
            this.dgv_admin_productos.Size = new System.Drawing.Size(548, 357);
            this.dgv_admin_productos.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_prod_eliminar);
            this.panel2.Controls.Add(this.btn_mant_editar);
            this.panel2.Controls.Add(this.btn_mant_nuevo);
            this.panel2.Location = new System.Drawing.Point(604, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 357);
            this.panel2.TabIndex = 3;
            // 
            // btn_prod_eliminar
            // 
            this.btn_prod_eliminar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_prod_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_prod_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prod_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod_eliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_prod_eliminar.Location = new System.Drawing.Point(27, 135);
            this.btn_prod_eliminar.Name = "btn_prod_eliminar";
            this.btn_prod_eliminar.Size = new System.Drawing.Size(90, 31);
            this.btn_prod_eliminar.TabIndex = 2;
            this.btn_prod_eliminar.Text = "Eliminar";
            this.btn_prod_eliminar.UseVisualStyleBackColor = false;
            this.btn_prod_eliminar.Click += new System.EventHandler(this.btn_prod_eliminar_Click);
            // 
            // btn_mant_editar
            // 
            this.btn_mant_editar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_mant_editar.FlatAppearance.BorderSize = 0;
            this.btn_mant_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mant_editar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mant_editar.ForeColor = System.Drawing.Color.White;
            this.btn_mant_editar.Location = new System.Drawing.Point(27, 84);
            this.btn_mant_editar.Name = "btn_mant_editar";
            this.btn_mant_editar.Size = new System.Drawing.Size(90, 31);
            this.btn_mant_editar.TabIndex = 1;
            this.btn_mant_editar.Text = "Editar";
            this.btn_mant_editar.UseVisualStyleBackColor = false;
            this.btn_mant_editar.Click += new System.EventHandler(this.btn_mant_editar_Click);
            // 
            // btn_mant_nuevo
            // 
            this.btn_mant_nuevo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_mant_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_mant_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mant_nuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mant_nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_mant_nuevo.Location = new System.Drawing.Point(27, 35);
            this.btn_mant_nuevo.Name = "btn_mant_nuevo";
            this.btn_mant_nuevo.Size = new System.Drawing.Size(90, 31);
            this.btn_mant_nuevo.TabIndex = 0;
            this.btn_mant_nuevo.Text = "Nuevo";
            this.btn_mant_nuevo.UseVisualStyleBackColor = false;
            this.btn_mant_nuevo.Click += new System.EventHandler(this.btn_mant_nuevo_Click);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(187, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 22);
            this.textBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(780, 570);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_productos";
            this.Text = "Admin_productos";
            this.Load += new System.EventHandler(this.Admin_productos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_productos)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_admin_productos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_prod_eliminar;
        private System.Windows.Forms.Button btn_mant_editar;
        private System.Windows.Forms.Button btn_mant_nuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}