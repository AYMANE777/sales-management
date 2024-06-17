
namespace MY_PROJECT
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelleft = new System.Windows.Forms.Panel();
            this.btn_facture = new System.Windows.Forms.Button();
            this.logo_min = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCLICK = new System.Windows.Forms.Panel();
            this.btn_dashb = new System.Windows.Forms.Button();
            this.btn_commade = new System.Windows.Forms.Button();
            this.btn_categorie = new System.Windows.Forms.Button();
            this.btn_pProduit = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.panelheader = new System.Windows.Forms.Panel();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.btn_minimum = new System.Windows.Forms.PictureBox();
            this.btn_maximum = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelleft.SuspendLayout();
            this.logo_min.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximum)).BeginInit();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelleft.Controls.Add(this.btn_facture);
            this.panelleft.Controls.Add(this.logo_min);
            this.panelleft.Controls.Add(this.logo_panel);
            this.panelleft.Controls.Add(this.panelCLICK);
            this.panelleft.Controls.Add(this.btn_dashb);
            this.panelleft.Controls.Add(this.btn_commade);
            this.panelleft.Controls.Add(this.btn_categorie);
            this.panelleft.Controls.Add(this.btn_pProduit);
            this.panelleft.Controls.Add(this.btn_client);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(224, 650);
            this.panelleft.TabIndex = 1;
            this.panelleft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelleft_Paint);
            // 
            // btn_facture
            // 
            this.btn_facture.FlatAppearance.BorderSize = 0;
            this.btn_facture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_facture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facture.ForeColor = System.Drawing.Color.White;
            this.btn_facture.Image = ((System.Drawing.Image)(resources.GetObject("btn_facture.Image")));
            this.btn_facture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_facture.Location = new System.Drawing.Point(5, 426);
            this.btn_facture.Name = "btn_facture";
            this.btn_facture.Size = new System.Drawing.Size(193, 38);
            this.btn_facture.TabIndex = 18;
            this.btn_facture.Text = "  Facture";
            this.btn_facture.UseVisualStyleBackColor = true;
            this.btn_facture.Click += new System.EventHandler(this.btn_commande_Click);
            // 
            // logo_min
            // 
            this.logo_min.Controls.Add(this.gunaPictureBox1);
            this.logo_min.Location = new System.Drawing.Point(-2, -4);
            this.logo_min.Name = "logo_min";
            this.logo_min.Size = new System.Drawing.Size(60, 76);
            this.logo_min.TabIndex = 4;
            this.logo_min.Visible = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(60, 57);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // logo_panel
            // 
            this.logo_panel.Controls.Add(this.label2);
            this.logo_panel.Controls.Add(this.label1);
            this.logo_panel.Controls.Add(this.pictureBox1);
            this.logo_panel.Location = new System.Drawing.Point(0, 1);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(250, 100);
            this.logo_panel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(113, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "PROJECT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "FIN DU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-66, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panelCLICK
            // 
            this.panelCLICK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelCLICK.Location = new System.Drawing.Point(-1, 132);
            this.panelCLICK.Name = "panelCLICK";
            this.panelCLICK.Size = new System.Drawing.Size(8, 38);
            this.panelCLICK.TabIndex = 0;
            // 
            // btn_dashb
            // 
            this.btn_dashb.FlatAppearance.BorderSize = 0;
            this.btn_dashb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_dashb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashb.ForeColor = System.Drawing.Color.White;
            this.btn_dashb.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashb.Image")));
            this.btn_dashb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashb.Location = new System.Drawing.Point(0, 131);
            this.btn_dashb.Name = "btn_dashb";
            this.btn_dashb.Size = new System.Drawing.Size(193, 38);
            this.btn_dashb.TabIndex = 15;
            this.btn_dashb.Text = "Tableau de bord";
            this.btn_dashb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dashb.UseVisualStyleBackColor = true;
            this.btn_dashb.Click += new System.EventHandler(this.btn_dashb_Click);
            // 
            // btn_commade
            // 
            this.btn_commade.FlatAppearance.BorderSize = 0;
            this.btn_commade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_commade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_commade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_commade.ForeColor = System.Drawing.Color.White;
            this.btn_commade.Image = ((System.Drawing.Image)(resources.GetObject("btn_commade.Image")));
            this.btn_commade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_commade.Location = new System.Drawing.Point(0, 367);
            this.btn_commade.Name = "btn_commade";
            this.btn_commade.Size = new System.Drawing.Size(193, 38);
            this.btn_commade.TabIndex = 14;
            this.btn_commade.Text = "           COMMANDES";
            this.btn_commade.UseVisualStyleBackColor = true;
            this.btn_commade.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_categorie
            // 
            this.btn_categorie.FlatAppearance.BorderSize = 0;
            this.btn_categorie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_categorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categorie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categorie.ForeColor = System.Drawing.Color.White;
            this.btn_categorie.Image = ((System.Drawing.Image)(resources.GetObject("btn_categorie.Image")));
            this.btn_categorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categorie.Location = new System.Drawing.Point(0, 308);
            this.btn_categorie.Name = "btn_categorie";
            this.btn_categorie.Size = new System.Drawing.Size(193, 38);
            this.btn_categorie.TabIndex = 13;
            this.btn_categorie.Text = "           CATEGORIE";
            this.btn_categorie.UseVisualStyleBackColor = true;
            this.btn_categorie.Click += new System.EventHandler(this.btn_categorie_Click);
            // 
            // btn_pProduit
            // 
            this.btn_pProduit.FlatAppearance.BorderSize = 0;
            this.btn_pProduit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_pProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pProduit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pProduit.ForeColor = System.Drawing.Color.White;
            this.btn_pProduit.Image = ((System.Drawing.Image)(resources.GetObject("btn_pProduit.Image")));
            this.btn_pProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pProduit.Location = new System.Drawing.Point(0, 249);
            this.btn_pProduit.Name = "btn_pProduit";
            this.btn_pProduit.Size = new System.Drawing.Size(193, 38);
            this.btn_pProduit.TabIndex = 12;
            this.btn_pProduit.Text = "       PRODUITS";
            this.btn_pProduit.UseVisualStyleBackColor = true;
            this.btn_pProduit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_client
            // 
            this.btn_client.FlatAppearance.BorderSize = 0;
            this.btn_client.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client.ForeColor = System.Drawing.Color.White;
            this.btn_client.Image = ((System.Drawing.Image)(resources.GetObject("btn_client.Image")));
            this.btn_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_client.Location = new System.Drawing.Point(6, 190);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(193, 38);
            this.btn_client.TabIndex = 0;
            this.btn_client.Text = "         CLIENT/FOURNIS";
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Black;
            this.panelheader.Controls.Add(this.lb_date);
            this.panelheader.Controls.Add(this.lb_time);
            this.panelheader.Controls.Add(this.btn_minimum);
            this.panelheader.Controls.Add(this.btn_maximum);
            this.panelheader.Controls.Add(this.btn_exit);
            this.panelheader.Controls.Add(this.btn_min);
            this.panelheader.Controls.Add(this.btn_menu);
            this.panelheader.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(224, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1076, 38);
            this.panelheader.TabIndex = 1;
            this.panelheader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelheader_Paint);
            this.panelheader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelheader_MouseDown);
            this.panelheader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelheader_MouseMove);
            this.panelheader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelheader_MouseUp);
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lb_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lb_date.Location = new System.Drawing.Point(542, 10);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(58, 19);
            this.lb_date.TabIndex = 13;
            this.lb_date.Text = "label3";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lb_time.ForeColor = System.Drawing.Color.White;
            this.lb_time.Location = new System.Drawing.Point(287, 10);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(58, 19);
            this.lb_time.TabIndex = 11;
            this.lb_time.Text = "label3";
            // 
            // btn_minimum
            // 
            this.btn_minimum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimum.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimum.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimum.Image")));
            this.btn_minimum.Location = new System.Drawing.Point(982, 9);
            this.btn_minimum.Name = "btn_minimum";
            this.btn_minimum.Size = new System.Drawing.Size(36, 23);
            this.btn_minimum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimum.TabIndex = 10;
            this.btn_minimum.TabStop = false;
            this.btn_minimum.Visible = false;
            this.btn_minimum.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // btn_maximum
            // 
            this.btn_maximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximum.BackColor = System.Drawing.Color.Transparent;
            this.btn_maximum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_maximum.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximum.Image")));
            this.btn_maximum.Location = new System.Drawing.Point(982, 9);
            this.btn_maximum.Name = "btn_maximum";
            this.btn_maximum.Size = new System.Drawing.Size(36, 23);
            this.btn_maximum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximum.TabIndex = 9;
            this.btn_maximum.TabStop = false;
            this.btn_maximum.Click += new System.EventHandler(this.iconmaximizar_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(1032, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(44, 38);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(918, 2);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(49, 38);
            this.btn_min.TabIndex = 8;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.Location = new System.Drawing.Point(6, -1);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(46, 38);
            this.btn_menu.TabIndex = 6;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.button7_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(224, 38);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1076, 612);
            this.mainpanel.TabIndex = 3;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.center_panel_Paint);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.panelleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCEUIL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelleft.ResumeLayout(false);
            this.logo_min.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.logo_panel.ResumeLayout(false);
            this.logo_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panelCLICK;
        private System.Windows.Forms.Button btn_dashb;
        private System.Windows.Forms.Button btn_commade;
        private System.Windows.Forms.Button btn_categorie;
        private System.Windows.Forms.Button btn_pProduit;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.PictureBox btn_minimum;
        private System.Windows.Forms.PictureBox btn_maximum;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel mainpanel;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel logo_min;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Button btn_facture;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_date;
    }
}

