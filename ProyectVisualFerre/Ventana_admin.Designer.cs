
namespace ProyectVisualFerre
{
    partial class Ventana_admin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_admin));
            this.pl_barra_superior = new System.Windows.Forms.Panel();
            this.btn_max = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.pl_menu_izq = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_admin_CatgMarc = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_admin_ventas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_admin_estadi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_admin_clt = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.btn_inicio_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_admin_prod = new System.Windows.Forms.Button();
            this.btn_inicio_ferre = new System.Windows.Forms.PictureBox();
            this.pl_contenedor = new System.Windows.Forms.Panel();
            this.pl_barra_titulo = new System.Windows.Forms.Panel();
            this.btn_menu_slide = new System.Windows.Forms.PictureBox();
            this.pl_barra_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.pl_menu_izq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_inicio_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_inicio_ferre)).BeginInit();
            this.pl_barra_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu_slide)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_barra_superior
            // 
            this.pl_barra_superior.BackColor = System.Drawing.Color.SteelBlue;
            this.pl_barra_superior.Controls.Add(this.btn_max);
            this.pl_barra_superior.Controls.Add(this.btn_minimizar);
            this.pl_barra_superior.Controls.Add(this.btn_restaurar);
            this.pl_barra_superior.Controls.Add(this.btn_cerrar);
            this.pl_barra_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_barra_superior.Location = new System.Drawing.Point(0, 0);
            this.pl_barra_superior.Name = "pl_barra_superior";
            this.pl_barra_superior.Size = new System.Drawing.Size(1000, 30);
            this.pl_barra_superior.TabIndex = 0;
            this.pl_barra_superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_barra_superior_MouseDown);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.Image")));
            this.btn_max.Location = new System.Drawing.Point(941, 3);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(25, 25);
            this.btn_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_max.TabIndex = 0;
            this.btn_max.TabStop = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(910, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(25, 25);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 0;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_restaurar.Image")));
            this.btn_restaurar.Location = new System.Drawing.Point(941, 3);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(25, 25);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 0;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(972, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // pl_menu_izq
            // 
            this.pl_menu_izq.BackColor = System.Drawing.Color.Teal;
            this.pl_menu_izq.Controls.Add(this.panel6);
            this.pl_menu_izq.Controls.Add(this.btn_admin_CatgMarc);
            this.pl_menu_izq.Controls.Add(this.panel5);
            this.pl_menu_izq.Controls.Add(this.button1);
            this.pl_menu_izq.Controls.Add(this.panel4);
            this.pl_menu_izq.Controls.Add(this.btn_admin_ventas);
            this.pl_menu_izq.Controls.Add(this.panel3);
            this.pl_menu_izq.Controls.Add(this.btn_admin_estadi);
            this.pl_menu_izq.Controls.Add(this.panel2);
            this.pl_menu_izq.Controls.Add(this.btn_admin_clt);
            this.pl_menu_izq.Controls.Add(this.btn_salir);
            this.pl_menu_izq.Controls.Add(this.btn_inicio_logo);
            this.pl_menu_izq.Controls.Add(this.panel1);
            this.pl_menu_izq.Controls.Add(this.btn_admin_prod);
            this.pl_menu_izq.Controls.Add(this.btn_inicio_ferre);
            this.pl_menu_izq.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_menu_izq.Location = new System.Drawing.Point(0, 30);
            this.pl_menu_izq.Name = "pl_menu_izq";
            this.pl_menu_izq.Size = new System.Drawing.Size(220, 570);
            this.pl_menu_izq.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.Location = new System.Drawing.Point(1, 150);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 35);
            this.panel6.TabIndex = 16;
            // 
            // btn_admin_CatgMarc
            // 
            this.btn_admin_CatgMarc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_CatgMarc.FlatAppearance.BorderSize = 0;
            this.btn_admin_CatgMarc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_admin_CatgMarc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_CatgMarc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_CatgMarc.ForeColor = System.Drawing.Color.White;
            this.btn_admin_CatgMarc.Image = ((System.Drawing.Image)(resources.GetObject("btn_admin_CatgMarc.Image")));
            this.btn_admin_CatgMarc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin_CatgMarc.Location = new System.Drawing.Point(4, 150);
            this.btn_admin_CatgMarc.Name = "btn_admin_CatgMarc";
            this.btn_admin_CatgMarc.Size = new System.Drawing.Size(216, 35);
            this.btn_admin_CatgMarc.TabIndex = 15;
            this.btn_admin_CatgMarc.Text = "  Categorías y Marcas";
            this.btn_admin_CatgMarc.UseVisualStyleBackColor = true;
            this.btn_admin_CatgMarc.Click += new System.EventHandler(this.btn_admin_CatgMarc_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Location = new System.Drawing.Point(0, 314);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 35);
            this.panel5.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Proveedores";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Location = new System.Drawing.Point(0, 273);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 35);
            this.panel4.TabIndex = 12;
            // 
            // btn_admin_ventas
            // 
            this.btn_admin_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_ventas.FlatAppearance.BorderSize = 0;
            this.btn_admin_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_admin_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_ventas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_ventas.ForeColor = System.Drawing.Color.White;
            this.btn_admin_ventas.Image = ((System.Drawing.Image)(resources.GetObject("btn_admin_ventas.Image")));
            this.btn_admin_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin_ventas.Location = new System.Drawing.Point(3, 273);
            this.btn_admin_ventas.Name = "btn_admin_ventas";
            this.btn_admin_ventas.Size = new System.Drawing.Size(216, 35);
            this.btn_admin_ventas.TabIndex = 11;
            this.btn_admin_ventas.Text = "Ventas";
            this.btn_admin_ventas.UseVisualStyleBackColor = true;
            this.btn_admin_ventas.Click += new System.EventHandler(this.btn_admin_ventas_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Location = new System.Drawing.Point(0, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 35);
            this.panel3.TabIndex = 10;
            // 
            // btn_admin_estadi
            // 
            this.btn_admin_estadi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_estadi.FlatAppearance.BorderSize = 0;
            this.btn_admin_estadi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_admin_estadi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_estadi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_estadi.ForeColor = System.Drawing.Color.White;
            this.btn_admin_estadi.Image = ((System.Drawing.Image)(resources.GetObject("btn_admin_estadi.Image")));
            this.btn_admin_estadi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin_estadi.Location = new System.Drawing.Point(3, 232);
            this.btn_admin_estadi.Name = "btn_admin_estadi";
            this.btn_admin_estadi.Size = new System.Drawing.Size(216, 35);
            this.btn_admin_estadi.TabIndex = 9;
            this.btn_admin_estadi.Text = "Estadísticas";
            this.btn_admin_estadi.UseVisualStyleBackColor = true;
            this.btn_admin_estadi.Click += new System.EventHandler(this.btn_admin_estadi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 35);
            this.panel2.TabIndex = 8;
            // 
            // btn_admin_clt
            // 
            this.btn_admin_clt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_clt.FlatAppearance.BorderSize = 0;
            this.btn_admin_clt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_admin_clt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_clt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_clt.ForeColor = System.Drawing.Color.White;
            this.btn_admin_clt.Image = ((System.Drawing.Image)(resources.GetObject("btn_admin_clt.Image")));
            this.btn_admin_clt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin_clt.Location = new System.Drawing.Point(3, 191);
            this.btn_admin_clt.Name = "btn_admin_clt";
            this.btn_admin_clt.Size = new System.Drawing.Size(216, 35);
            this.btn_admin_clt.TabIndex = 7;
            this.btn_admin_clt.Text = "Clientes";
            this.btn_admin_clt.UseVisualStyleBackColor = true;
            this.btn_admin_clt.Click += new System.EventHandler(this.btn_admin_clt_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(0, 530);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(220, 40);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 6;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_inicio_logo
            // 
            this.btn_inicio_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inicio_logo.Image = ((System.Drawing.Image)(resources.GetObject("btn_inicio_logo.Image")));
            this.btn_inicio_logo.Location = new System.Drawing.Point(0, 3);
            this.btn_inicio_logo.Name = "btn_inicio_logo";
            this.btn_inicio_logo.Size = new System.Drawing.Size(65, 65);
            this.btn_inicio_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_inicio_logo.TabIndex = 5;
            this.btn_inicio_logo.TabStop = false;
            this.btn_inicio_logo.Click += new System.EventHandler(this.btn_inicio_logo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(1, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 35);
            this.panel1.TabIndex = 2;
            // 
            // btn_admin_prod
            // 
            this.btn_admin_prod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_prod.FlatAppearance.BorderSize = 0;
            this.btn_admin_prod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_admin_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_prod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_prod.ForeColor = System.Drawing.Color.White;
            this.btn_admin_prod.Image = ((System.Drawing.Image)(resources.GetObject("btn_admin_prod.Image")));
            this.btn_admin_prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin_prod.Location = new System.Drawing.Point(4, 109);
            this.btn_admin_prod.Name = "btn_admin_prod";
            this.btn_admin_prod.Size = new System.Drawing.Size(216, 35);
            this.btn_admin_prod.TabIndex = 1;
            this.btn_admin_prod.Text = "Productos";
            this.btn_admin_prod.UseVisualStyleBackColor = true;
            this.btn_admin_prod.Click += new System.EventHandler(this.btn_admin_prod_Click);
            // 
            // btn_inicio_ferre
            // 
            this.btn_inicio_ferre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inicio_ferre.Image = ((System.Drawing.Image)(resources.GetObject("btn_inicio_ferre.Image")));
            this.btn_inicio_ferre.Location = new System.Drawing.Point(65, 0);
            this.btn_inicio_ferre.Name = "btn_inicio_ferre";
            this.btn_inicio_ferre.Size = new System.Drawing.Size(155, 71);
            this.btn_inicio_ferre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_inicio_ferre.TabIndex = 0;
            this.btn_inicio_ferre.TabStop = false;
            this.btn_inicio_ferre.Click += new System.EventHandler(this.btn_inicio_ferre_Click);
            // 
            // pl_contenedor
            // 
            this.pl_contenedor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pl_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_contenedor.Location = new System.Drawing.Point(220, 30);
            this.pl_contenedor.Name = "pl_contenedor";
            this.pl_contenedor.Size = new System.Drawing.Size(780, 570);
            this.pl_contenedor.TabIndex = 2;
            // 
            // pl_barra_titulo
            // 
            this.pl_barra_titulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pl_barra_titulo.Controls.Add(this.btn_menu_slide);
            this.pl_barra_titulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_barra_titulo.Location = new System.Drawing.Point(220, 30);
            this.pl_barra_titulo.Name = "pl_barra_titulo";
            this.pl_barra_titulo.Size = new System.Drawing.Size(46, 570);
            this.pl_barra_titulo.TabIndex = 3;
            // 
            // btn_menu_slide
            // 
            this.btn_menu_slide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu_slide.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_slide.Image")));
            this.btn_menu_slide.Location = new System.Drawing.Point(0, 0);
            this.btn_menu_slide.Name = "btn_menu_slide";
            this.btn_menu_slide.Size = new System.Drawing.Size(45, 45);
            this.btn_menu_slide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_menu_slide.TabIndex = 0;
            this.btn_menu_slide.TabStop = false;
            this.btn_menu_slide.Click += new System.EventHandler(this.btn_menu_slide_Click);
            // 
            // Ventana_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pl_barra_titulo);
            this.Controls.Add(this.pl_contenedor);
            this.Controls.Add(this.pl_menu_izq);
            this.Controls.Add(this.pl_barra_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventana_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ventana_admin_Load);
            this.pl_barra_superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.pl_menu_izq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_inicio_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_inicio_ferre)).EndInit();
            this.pl_barra_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu_slide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_barra_superior;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.Panel pl_menu_izq;
        private System.Windows.Forms.Panel pl_contenedor;
        private System.Windows.Forms.PictureBox btn_max;
        private System.Windows.Forms.Button btn_admin_prod;
        private System.Windows.Forms.PictureBox btn_inicio_ferre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_inicio_logo;
        private System.Windows.Forms.Panel pl_barra_titulo;
        private System.Windows.Forms.PictureBox btn_menu_slide;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_admin_clt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_admin_ventas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_admin_estadi;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_admin_CatgMarc;
    }
}

