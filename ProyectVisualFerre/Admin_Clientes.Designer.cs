
namespace ProyectVisualFerre
{
    partial class Admin_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Clientes));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clt_eliminar = new System.Windows.Forms.Button();
            this.btn_mant_editar = new System.Windows.Forms.Button();
            this.btn_mant_anadir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_admin_clientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(184, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 22);
            this.textBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Buscar cliente:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_clt_eliminar);
            this.panel2.Controls.Add(this.btn_mant_editar);
            this.panel2.Controls.Add(this.btn_mant_anadir);
            this.panel2.Location = new System.Drawing.Point(601, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 357);
            this.panel2.TabIndex = 9;
            // 
            // btn_clt_eliminar
            // 
            this.btn_clt_eliminar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_clt_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_clt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clt_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clt_eliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_clt_eliminar.Location = new System.Drawing.Point(27, 134);
            this.btn_clt_eliminar.Name = "btn_clt_eliminar";
            this.btn_clt_eliminar.Size = new System.Drawing.Size(90, 31);
            this.btn_clt_eliminar.TabIndex = 2;
            this.btn_clt_eliminar.Text = "Eliminar";
            this.btn_clt_eliminar.UseVisualStyleBackColor = false;
            this.btn_clt_eliminar.Click += new System.EventHandler(this.btn_clt_eliminar_Click);
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
            // btn_mant_anadir
            // 
            this.btn_mant_anadir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_mant_anadir.FlatAppearance.BorderSize = 0;
            this.btn_mant_anadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mant_anadir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mant_anadir.ForeColor = System.Drawing.Color.White;
            this.btn_mant_anadir.Location = new System.Drawing.Point(27, 35);
            this.btn_mant_anadir.Name = "btn_mant_anadir";
            this.btn_mant_anadir.Size = new System.Drawing.Size(90, 31);
            this.btn_mant_anadir.TabIndex = 0;
            this.btn_mant_anadir.Text = "Añadir";
            this.btn_mant_anadir.UseVisualStyleBackColor = false;
            this.btn_mant_anadir.Click += new System.EventHandler(this.btn_mant_anadir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_admin_clientes);
            this.panel1.Location = new System.Drawing.Point(47, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 357);
            this.panel1.TabIndex = 8;
            // 
            // dgv_admin_clientes
            // 
            this.dgv_admin_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin_clientes.Location = new System.Drawing.Point(0, 0);
            this.dgv_admin_clientes.Name = "dgv_admin_clientes";
            this.dgv_admin_clientes.Size = new System.Drawing.Size(548, 357);
            this.dgv_admin_clientes.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Listado de clientes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "MANTENIMIENTO DE CLIENTES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_Clientes
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
            this.Name = "Admin_Clientes";
            this.Text = "Admin_Clientes";
            this.Load += new System.EventHandler(this.Admin_Clientes_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_clt_eliminar;
        private System.Windows.Forms.Button btn_mant_editar;
        private System.Windows.Forms.Button btn_mant_anadir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_admin_clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}