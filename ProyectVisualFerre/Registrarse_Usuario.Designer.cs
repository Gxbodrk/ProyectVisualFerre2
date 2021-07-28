
namespace ProyectVisualFerre
{
    partial class Registrarse_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrarse_Usuario));
            this.pl_barras = new System.Windows.Forms.Panel();
            this.btn_maximi = new System.Windows.Forms.PictureBox();
            this.btn_mini = new System.Windows.Forms.PictureBox();
            this.btn_restau = new System.Windows.Forms.PictureBox();
            this.btn_sale = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pl_barras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sale)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_barras
            // 
            this.pl_barras.BackColor = System.Drawing.Color.SteelBlue;
            this.pl_barras.Controls.Add(this.btn_maximi);
            this.pl_barras.Controls.Add(this.btn_mini);
            this.pl_barras.Controls.Add(this.btn_restau);
            this.pl_barras.Controls.Add(this.btn_sale);
            this.pl_barras.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_barras.Location = new System.Drawing.Point(0, 0);
            this.pl_barras.Name = "pl_barras";
            this.pl_barras.Size = new System.Drawing.Size(800, 30);
            this.pl_barras.TabIndex = 2;
            this.pl_barras.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_barras_Paint);
            this.pl_barras.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pl_barras_MouseClick);
            // 
            // btn_maximi
            // 
            this.btn_maximi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximi.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximi.Image")));
            this.btn_maximi.Location = new System.Drawing.Point(741, 2);
            this.btn_maximi.Name = "btn_maximi";
            this.btn_maximi.Size = new System.Drawing.Size(25, 25);
            this.btn_maximi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximi.TabIndex = 0;
            this.btn_maximi.TabStop = false;
            this.btn_maximi.Click += new System.EventHandler(this.btn_maximi_Click);
            // 
            // btn_mini
            // 
            this.btn_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mini.Image = ((System.Drawing.Image)(resources.GetObject("btn_mini.Image")));
            this.btn_mini.Location = new System.Drawing.Point(710, 3);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(25, 25);
            this.btn_mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_mini.TabIndex = 0;
            this.btn_mini.TabStop = false;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // btn_restau
            // 
            this.btn_restau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restau.Image = ((System.Drawing.Image)(resources.GetObject("btn_restau.Image")));
            this.btn_restau.Location = new System.Drawing.Point(741, 3);
            this.btn_restau.Name = "btn_restau";
            this.btn_restau.Size = new System.Drawing.Size(25, 25);
            this.btn_restau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restau.TabIndex = 0;
            this.btn_restau.TabStop = false;
            this.btn_restau.Visible = false;
            this.btn_restau.Click += new System.EventHandler(this.btn_restau_Click);
            // 
            // btn_sale
            // 
            this.btn_sale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sale.Image = ((System.Drawing.Image)(resources.GetObject("btn_sale.Image")));
            this.btn_sale.Location = new System.Drawing.Point(772, 3);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.Size = new System.Drawing.Size(25, 25);
            this.btn_sale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_sale.TabIndex = 0;
            this.btn_sale.TabStop = false;
            this.btn_sale.Click += new System.EventHandler(this.btn_sale_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 420);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(503, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 420);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Registrarse_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pl_barras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrarse_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarse_Usuario";
            this.pl_barras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sale)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_barras;
        private System.Windows.Forms.PictureBox btn_maximi;
        private System.Windows.Forms.PictureBox btn_mini;
        private System.Windows.Forms.PictureBox btn_restau;
        private System.Windows.Forms.PictureBox btn_sale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}