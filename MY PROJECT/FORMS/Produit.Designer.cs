
namespace MY_PROJECT
{
    partial class Produit_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produit_Form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_produit = new System.Windows.Forms.DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tb_rechercher_produit = new MaterialSkin.Controls.MaterialTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pic_categorie = new System.Windows.Forms.PictureBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.cb_cat = new MaterialSkin.Controls.MaterialComboBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.tb_nom_produit = new MaterialSkin.Controls.MaterialTextBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.tb_quantite_prd = new MaterialSkin.Controls.MaterialTextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.tb_prix_achat = new MaterialSkin.Controls.MaterialTextBox();
            this.pic_prix_ventes = new System.Windows.Forms.PictureBox();
            this.pic_prix_achat = new System.Windows.Forms.PictureBox();
            this.pic_quantiter_stock = new System.Windows.Forms.PictureBox();
            this.pic_nom_produit = new System.Windows.Forms.PictureBox();
            this.btn_anuller = new Guna.UI.WinForms.GunaButton();
            this.btn_ajouterP = new Guna.UI.WinForms.GunaButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tb_prix_de_vente = new MaterialSkin.Controls.MaterialTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.photo_produit = new System.Windows.Forms.PictureBox();
            this.img_upload = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_produit)).BeginInit();
            this.panel13.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_categorie)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prix_ventes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prix_achat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_quantiter_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nom_produit)).BeginInit();
            this.panel9.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo_produit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.grid_produit);
            this.groupBox1.Controls.Add(this.panel14);
            this.groupBox1.Controls.Add(this.panel11);
            this.groupBox1.Controls.Add(this.gunaButton4);
            this.groupBox1.Controls.Add(this.gunaButton3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.panel13);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(3, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 272);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des Produit";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grid_produit
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.grid_produit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_produit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_produit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_produit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_produit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_produit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_produit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_produit.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_produit.Location = new System.Drawing.Point(9, 72);
            this.grid_produit.Name = "grid_produit";
            this.grid_produit.Size = new System.Drawing.Size(805, 194);
            this.grid_produit.TabIndex = 109;
            this.grid_produit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_produit_CellClick_1);
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(872, 171);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(150, 1);
            this.panel14.TabIndex = 108;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(825, 70);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1, 190);
            this.panel11.TabIndex = 95;
            // 
            // gunaButton4
            // 
            this.gunaButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton4.BorderColor = System.Drawing.Color.DarkViolet;
            this.gunaButton4.BorderSize = 2;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton4.Image")));
            this.gunaButton4.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton4.Location = new System.Drawing.Point(867, 190);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 5;
            this.gunaButton4.Size = new System.Drawing.Size(160, 51);
            this.gunaButton4.TabIndex = 107;
            this.gunaButton4.Text = "       Modifier";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.Mettre_A_Jour_Produit);
            // 
            // gunaButton3
            // 
            this.gunaButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.DarkViolet;
            this.gunaButton3.BorderSize = 2;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton3.Location = new System.Drawing.Point(867, 101);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 5;
            this.gunaButton3.Size = new System.Drawing.Size(160, 51);
            this.gunaButton3.TabIndex = 106;
            this.gunaButton3.Text = "    Supprimer";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.supprimer_selection);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(863, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 19);
            this.label8.TabIndex = 105;
            this.label8.Text = "Selectionner pour :";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.tb_rechercher_produit);
            this.panel13.Location = new System.Drawing.Point(284, 20);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(416, 48);
            this.panel13.TabIndex = 103;
            // 
            // tb_rechercher_produit
            // 
            this.tb_rechercher_produit.AnimateReadOnly = false;
            this.tb_rechercher_produit.BackColor = System.Drawing.Color.White;
            this.tb_rechercher_produit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_rechercher_produit.Depth = 0;
            this.tb_rechercher_produit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_rechercher_produit.ForeColor = System.Drawing.Color.White;
            this.tb_rechercher_produit.Hint = "Taper ici Nom du Produit";
            this.tb_rechercher_produit.LeadingIcon = null;
            this.tb_rechercher_produit.Location = new System.Drawing.Point(3, 0);
            this.tb_rechercher_produit.MaxLength = 50;
            this.tb_rechercher_produit.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_rechercher_produit.Multiline = false;
            this.tb_rechercher_produit.Name = "tb_rechercher_produit";
            this.tb_rechercher_produit.Size = new System.Drawing.Size(416, 50);
            this.tb_rechercher_produit.TabIndex = 33;
            this.tb_rechercher_produit.Text = "";
            this.tb_rechercher_produit.TrailingIcon = null;
            this.tb_rechercher_produit.TextChanged += new System.EventHandler(this.tb_rechercher_produit_TextChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(87, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 19);
            this.label13.TabIndex = 102;
            this.label13.Text = "Entrer pour rechercher :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pic_categorie);
            this.groupBox2.Controls.Add(this.panel17);
            this.groupBox2.Controls.Add(this.panel18);
            this.groupBox2.Controls.Add(this.panel19);
            this.groupBox2.Controls.Add(this.panel15);
            this.groupBox2.Controls.Add(this.pic_prix_ventes);
            this.groupBox2.Controls.Add(this.pic_prix_achat);
            this.groupBox2.Controls.Add(this.pic_quantiter_stock);
            this.groupBox2.Controls.Add(this.pic_nom_produit);
            this.groupBox2.Controls.Add(this.btn_anuller);
            this.groupBox2.Controls.Add(this.btn_ajouterP);
            this.groupBox2.Controls.Add(this.panel9);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.gunaGroupBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1044, 331);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajouter un Produit :";
            // 
            // pic_categorie
            // 
            this.pic_categorie.Image = ((System.Drawing.Image)(resources.GetObject("pic_categorie.Image")));
            this.pic_categorie.Location = new System.Drawing.Point(480, 40);
            this.pic_categorie.Name = "pic_categorie";
            this.pic_categorie.Size = new System.Drawing.Size(31, 27);
            this.pic_categorie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_categorie.TabIndex = 134;
            this.pic_categorie.TabStop = false;
            this.pic_categorie.Visible = false;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.Controls.Add(this.cb_cat);
            this.panel17.Location = new System.Drawing.Point(209, 28);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(252, 50);
            this.panel17.TabIndex = 2;
            // 
            // cb_cat
            // 
            this.cb_cat.AutoResize = false;
            this.cb_cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_cat.Depth = 0;
            this.cb_cat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_cat.DropDownHeight = 174;
            this.cb_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cat.DropDownWidth = 121;
            this.cb_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_cat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Hint = "Cliquer pour selectionner";
            this.cb_cat.IntegralHeight = false;
            this.cb_cat.ItemHeight = 43;
            this.cb_cat.Location = new System.Drawing.Point(0, 1);
            this.cb_cat.MaxDropDownItems = 4;
            this.cb_cat.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(252, 49);
            this.cb_cat.StartIndex = 0;
            this.cb_cat.TabIndex = 109;
            this.cb_cat.SelectedIndexChanged += new System.EventHandler(this.cb_cat_SelectedIndexChanged_1);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.White;
            this.panel18.Controls.Add(this.tb_nom_produit);
            this.panel18.Location = new System.Drawing.Point(209, 83);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(252, 50);
            this.panel18.TabIndex = 2;
            // 
            // tb_nom_produit
            // 
            this.tb_nom_produit.AnimateReadOnly = false;
            this.tb_nom_produit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nom_produit.Depth = 0;
            this.tb_nom_produit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_nom_produit.Hint = "Ex : Produit";
            this.tb_nom_produit.LeadingIcon = null;
            this.tb_nom_produit.Location = new System.Drawing.Point(0, 0);
            this.tb_nom_produit.MaxLength = 50;
            this.tb_nom_produit.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_nom_produit.Multiline = false;
            this.tb_nom_produit.Name = "tb_nom_produit";
            this.tb_nom_produit.Size = new System.Drawing.Size(252, 50);
            this.tb_nom_produit.TabIndex = 104;
            this.tb_nom_produit.Text = "";
            this.tb_nom_produit.TrailingIcon = null;
            this.tb_nom_produit.TextChanged += new System.EventHandler(this.tb_nom_produit_TextChanged);
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel19.Controls.Add(this.tb_quantite_prd);
            this.panel19.Location = new System.Drawing.Point(209, 139);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(252, 50);
            this.panel19.TabIndex = 3;
            // 
            // tb_quantite_prd
            // 
            this.tb_quantite_prd.AnimateReadOnly = false;
            this.tb_quantite_prd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_quantite_prd.Depth = 0;
            this.tb_quantite_prd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_quantite_prd.Hint = "Ex :123455...";
            this.tb_quantite_prd.LeadingIcon = null;
            this.tb_quantite_prd.Location = new System.Drawing.Point(0, 0);
            this.tb_quantite_prd.MaxLength = 50;
            this.tb_quantite_prd.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_quantite_prd.Multiline = false;
            this.tb_quantite_prd.Name = "tb_quantite_prd";
            this.tb_quantite_prd.Size = new System.Drawing.Size(252, 50);
            this.tb_quantite_prd.TabIndex = 105;
            this.tb_quantite_prd.Text = "";
            this.tb_quantite_prd.TrailingIcon = null;
            this.tb_quantite_prd.TextChanged += new System.EventHandler(this.tb_quantite_prd_TextChanged);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Controls.Add(this.tb_prix_achat);
            this.panel15.Location = new System.Drawing.Point(209, 200);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(252, 50);
            this.panel15.TabIndex = 1;
            // 
            // tb_prix_achat
            // 
            this.tb_prix_achat.AnimateReadOnly = false;
            this.tb_prix_achat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_prix_achat.Depth = 0;
            this.tb_prix_achat.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_prix_achat.Hint = "Ex: 21,13...";
            this.tb_prix_achat.LeadingIcon = null;
            this.tb_prix_achat.Location = new System.Drawing.Point(0, 0);
            this.tb_prix_achat.MaxLength = 50;
            this.tb_prix_achat.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_prix_achat.Multiline = false;
            this.tb_prix_achat.Name = "tb_prix_achat";
            this.tb_prix_achat.Size = new System.Drawing.Size(252, 50);
            this.tb_prix_achat.TabIndex = 106;
            this.tb_prix_achat.Text = "";
            this.tb_prix_achat.TrailingIcon = null;
            this.tb_prix_achat.TextChanged += new System.EventHandler(this.tb_prix_achat_TextChanged);
            // 
            // pic_prix_ventes
            // 
            this.pic_prix_ventes.Image = ((System.Drawing.Image)(resources.GetObject("pic_prix_ventes.Image")));
            this.pic_prix_ventes.Location = new System.Drawing.Point(480, 273);
            this.pic_prix_ventes.Name = "pic_prix_ventes";
            this.pic_prix_ventes.Size = new System.Drawing.Size(31, 27);
            this.pic_prix_ventes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_prix_ventes.TabIndex = 133;
            this.pic_prix_ventes.TabStop = false;
            this.pic_prix_ventes.Visible = false;
            // 
            // pic_prix_achat
            // 
            this.pic_prix_achat.Image = ((System.Drawing.Image)(resources.GetObject("pic_prix_achat.Image")));
            this.pic_prix_achat.Location = new System.Drawing.Point(480, 212);
            this.pic_prix_achat.Name = "pic_prix_achat";
            this.pic_prix_achat.Size = new System.Drawing.Size(31, 27);
            this.pic_prix_achat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_prix_achat.TabIndex = 132;
            this.pic_prix_achat.TabStop = false;
            this.pic_prix_achat.Visible = false;
            // 
            // pic_quantiter_stock
            // 
            this.pic_quantiter_stock.Image = ((System.Drawing.Image)(resources.GetObject("pic_quantiter_stock.Image")));
            this.pic_quantiter_stock.Location = new System.Drawing.Point(480, 153);
            this.pic_quantiter_stock.Name = "pic_quantiter_stock";
            this.pic_quantiter_stock.Size = new System.Drawing.Size(31, 27);
            this.pic_quantiter_stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_quantiter_stock.TabIndex = 131;
            this.pic_quantiter_stock.TabStop = false;
            this.pic_quantiter_stock.Visible = false;
            // 
            // pic_nom_produit
            // 
            this.pic_nom_produit.Image = ((System.Drawing.Image)(resources.GetObject("pic_nom_produit.Image")));
            this.pic_nom_produit.Location = new System.Drawing.Point(480, 96);
            this.pic_nom_produit.Name = "pic_nom_produit";
            this.pic_nom_produit.Size = new System.Drawing.Size(31, 27);
            this.pic_nom_produit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_nom_produit.TabIndex = 130;
            this.pic_nom_produit.TabStop = false;
            this.pic_nom_produit.Visible = false;
            // 
            // btn_anuller
            // 
            this.btn_anuller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_anuller.AnimationHoverSpeed = 0.07F;
            this.btn_anuller.AnimationSpeed = 0.03F;
            this.btn_anuller.BackColor = System.Drawing.Color.Transparent;
            this.btn_anuller.BaseColor = System.Drawing.Color.White;
            this.btn_anuller.BorderColor = System.Drawing.Color.Red;
            this.btn_anuller.BorderSize = 1;
            this.btn_anuller.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_anuller.FocusedColor = System.Drawing.Color.Empty;
            this.btn_anuller.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_anuller.ForeColor = System.Drawing.Color.Black;
            this.btn_anuller.Image = ((System.Drawing.Image)(resources.GetObject("btn_anuller.Image")));
            this.btn_anuller.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_anuller.Location = new System.Drawing.Point(880, 149);
            this.btn_anuller.Name = "btn_anuller";
            this.btn_anuller.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_anuller.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_anuller.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_anuller.OnHoverImage = null;
            this.btn_anuller.OnPressedColor = System.Drawing.Color.Black;
            this.btn_anuller.Radius = 5;
            this.btn_anuller.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_anuller.Size = new System.Drawing.Size(128, 55);
            this.btn_anuller.TabIndex = 119;
            this.btn_anuller.Text = "ANNULER";
            this.btn_anuller.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_anuller.Click += new System.EventHandler(this.btn_anuller_Click);
            // 
            // btn_ajouterP
            // 
            this.btn_ajouterP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajouterP.AnimationHoverSpeed = 0.07F;
            this.btn_ajouterP.AnimationSpeed = 0.03F;
            this.btn_ajouterP.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajouterP.BaseColor = System.Drawing.Color.White;
            this.btn_ajouterP.BorderColor = System.Drawing.Color.Red;
            this.btn_ajouterP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ajouterP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ajouterP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajouterP.ForeColor = System.Drawing.Color.Black;
            this.btn_ajouterP.Image = ((System.Drawing.Image)(resources.GetObject("btn_ajouterP.Image")));
            this.btn_ajouterP.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_ajouterP.Location = new System.Drawing.Point(861, 56);
            this.btn_ajouterP.Name = "btn_ajouterP";
            this.btn_ajouterP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_ajouterP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ajouterP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ajouterP.OnHoverImage = null;
            this.btn_ajouterP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ajouterP.Radius = 5;
            this.btn_ajouterP.Size = new System.Drawing.Size(161, 55);
            this.btn_ajouterP.TabIndex = 118;
            this.btn_ajouterP.Text = "    AJOUTER ";
            this.btn_ajouterP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ajouterP.Click += new System.EventHandler(this.btn_ajouter_Produit);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.tb_prix_de_vente);
            this.panel9.Location = new System.Drawing.Point(209, 264);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(252, 48);
            this.panel9.TabIndex = 102;
            // 
            // tb_prix_de_vente
            // 
            this.tb_prix_de_vente.AnimateReadOnly = false;
            this.tb_prix_de_vente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_prix_de_vente.Depth = 0;
            this.tb_prix_de_vente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_prix_de_vente.Hint = "Ex: 21,13...";
            this.tb_prix_de_vente.LeadingIcon = null;
            this.tb_prix_de_vente.Location = new System.Drawing.Point(0, -2);
            this.tb_prix_de_vente.MaxLength = 50;
            this.tb_prix_de_vente.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_prix_de_vente.Multiline = false;
            this.tb_prix_de_vente.Name = "tb_prix_de_vente";
            this.tb_prix_de_vente.Size = new System.Drawing.Size(252, 50);
            this.tb_prix_de_vente.TabIndex = 123;
            this.tb_prix_de_vente.Text = "";
            this.tb_prix_de_vente.TrailingIcon = null;
            this.tb_prix_de_vente.TextChanged += new System.EventHandler(this.tb_prix_de_vente_TextChanged_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(832, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 290);
            this.panel7.TabIndex = 117;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(530, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 290);
            this.panel5.TabIndex = 116;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(262, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 1);
            this.panel4.TabIndex = 114;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(262, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 1);
            this.panel3.TabIndex = 115;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(262, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 1);
            this.panel2.TabIndex = 113;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(262, 85);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 1);
            this.panel6.TabIndex = 112;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Red;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.panel8);
            this.gunaGroupBox1.Controls.Add(this.photo_produit);
            this.gunaGroupBox1.Controls.Add(this.img_upload);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Blue;
            this.gunaGroupBox1.Location = new System.Drawing.Point(551, 26);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(260, 263);
            this.gunaGroupBox1.TabIndex = 101;
            this.gunaGroupBox1.Text = "IMAGE DU PRODUIT";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(54, 200);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(150, 1);
            this.panel8.TabIndex = 93;
            // 
            // photo_produit
            // 
            this.photo_produit.Image = ((System.Drawing.Image)(resources.GetObject("photo_produit.Image")));
            this.photo_produit.Location = new System.Drawing.Point(30, 33);
            this.photo_produit.Name = "photo_produit";
            this.photo_produit.Size = new System.Drawing.Size(195, 163);
            this.photo_produit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo_produit.TabIndex = 54;
            this.photo_produit.TabStop = false;
            // 
            // img_upload
            // 
            this.img_upload.AnimationHoverSpeed = 0.07F;
            this.img_upload.AnimationSpeed = 0.03F;
            this.img_upload.BackColor = System.Drawing.Color.Transparent;
            this.img_upload.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.img_upload.BorderColor = System.Drawing.Color.Transparent;
            this.img_upload.BorderSize = 1;
            this.img_upload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.img_upload.FocusedColor = System.Drawing.Color.Empty;
            this.img_upload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.img_upload.ForeColor = System.Drawing.Color.White;
            this.img_upload.Image = null;
            this.img_upload.ImageSize = new System.Drawing.Size(20, 20);
            this.img_upload.Location = new System.Drawing.Point(47, 209);
            this.img_upload.Name = "img_upload";
            this.img_upload.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.img_upload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.img_upload.OnHoverForeColor = System.Drawing.Color.White;
            this.img_upload.OnHoverImage = null;
            this.img_upload.OnPressedColor = System.Drawing.Color.Black;
            this.img_upload.Radius = 4;
            this.img_upload.Size = new System.Drawing.Size(170, 34);
            this.img_upload.TabIndex = 73;
            this.img_upload.Text = "Importer photo";
            this.img_upload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.img_upload.Click += new System.EventHandler(this.img_upload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 111;
            this.label3.Text = "Prix d\'achat  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 110;
            this.label2.Text = "Categorie Du Produit  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 108;
            this.label7.Text = "Prix de Vente :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(26, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 19);
            this.label12.TabIndex = 107;
            this.label12.Text = "Quantité Du Stock :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 103;
            this.label1.Text = "Nom du Produit  :";
            // 
            // Produit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1050, 612);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produit_Form";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.Produit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_produit)).EndInit();
            this.panel13.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_categorie)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_prix_ventes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prix_achat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_quantiter_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nom_produit)).EndInit();
            this.panel9.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photo_produit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_produit;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel11;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel13;
        private MaterialSkin.Controls.MaterialTextBox tb_rechercher_produit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pic_categorie;
        private System.Windows.Forms.Panel panel17;
        private MaterialSkin.Controls.MaterialComboBox cb_cat;
        private System.Windows.Forms.Panel panel18;
        private MaterialSkin.Controls.MaterialTextBox tb_nom_produit;
        private System.Windows.Forms.Panel panel19;
        private MaterialSkin.Controls.MaterialTextBox tb_quantite_prd;
        private System.Windows.Forms.Panel panel15;
        private MaterialSkin.Controls.MaterialTextBox tb_prix_achat;
        private System.Windows.Forms.PictureBox pic_prix_ventes;
        private System.Windows.Forms.PictureBox pic_prix_achat;
        private System.Windows.Forms.PictureBox pic_quantiter_stock;
        private System.Windows.Forms.PictureBox pic_nom_produit;
        private Guna.UI.WinForms.GunaButton btn_anuller;
        private Guna.UI.WinForms.GunaButton btn_ajouterP;
        private System.Windows.Forms.Panel panel9;
        private MaterialSkin.Controls.MaterialTextBox tb_prix_de_vente;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox photo_produit;
        private Guna.UI.WinForms.GunaButton img_upload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
    }
}