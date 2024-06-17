
namespace MY_PROJECT
{
    partial class COMMANDES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COMMANDES));
            this.grp_box_donne_commande = new System.Windows.Forms.GroupBox();
            this.lb_commande_numero = new System.Windows.Forms.Label();
            this.lb_commande = new System.Windows.Forms.Label();
            this.btn_supp_cmd_gridview = new Guna.UI.WinForms.GunaButton();
            this.btn_cliquer_ici_Fourniss = new System.Windows.Forms.Button();
            this.btn_cliquer_ici_client = new System.Windows.Forms.Button();
            this.dgv_cmd = new System.Windows.Forms.DataGridView();
            this.id_Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_confirmer_cmd_Client = new Guna.UI.WinForms.GunaButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_annuler_Commande = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_nom_complet = new MaterialSkin.Controls.MaterialComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tb_prix = new MaterialSkin.Controls.MaterialTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_qte = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_produit_commande = new MaterialSkin.Controls.MaterialComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.radio_fournisseur = new MaterialSkin.Controls.MaterialRadioButton();
            this.radio_Clients = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_ajouter_Commande_Client = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.grp_box_donne_commande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cmd)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_qte)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_box_donne_commande
            // 
            this.grp_box_donne_commande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_box_donne_commande.BackColor = System.Drawing.Color.Transparent;
            this.grp_box_donne_commande.Controls.Add(this.lb_commande_numero);
            this.grp_box_donne_commande.Controls.Add(this.lb_commande);
            this.grp_box_donne_commande.Controls.Add(this.btn_supp_cmd_gridview);
            this.grp_box_donne_commande.Controls.Add(this.btn_cliquer_ici_Fourniss);
            this.grp_box_donne_commande.Controls.Add(this.btn_cliquer_ici_client);
            this.grp_box_donne_commande.Controls.Add(this.dgv_cmd);
            this.grp_box_donne_commande.Controls.Add(this.btn_confirmer_cmd_Client);
            this.grp_box_donne_commande.Controls.Add(this.panel5);
            this.grp_box_donne_commande.Controls.Add(this.btn_annuler_Commande);
            this.grp_box_donne_commande.Controls.Add(this.panel1);
            this.grp_box_donne_commande.Controls.Add(this.label11);
            this.grp_box_donne_commande.Controls.Add(this.label4);
            this.grp_box_donne_commande.Controls.Add(this.label3);
            this.grp_box_donne_commande.Controls.Add(this.label1);
            this.grp_box_donne_commande.Controls.Add(this.panel6);
            this.grp_box_donne_commande.Controls.Add(this.panel4);
            this.grp_box_donne_commande.Controls.Add(this.panel2);
            this.grp_box_donne_commande.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_box_donne_commande.ForeColor = System.Drawing.Color.Red;
            this.grp_box_donne_commande.Location = new System.Drawing.Point(7, 45);
            this.grp_box_donne_commande.Name = "grp_box_donne_commande";
            this.grp_box_donne_commande.Size = new System.Drawing.Size(1065, 474);
            this.grp_box_donne_commande.TabIndex = 88;
            this.grp_box_donne_commande.TabStop = false;
            this.grp_box_donne_commande.Text = "Donnée Commande";
            this.grp_box_donne_commande.Enter += new System.EventHandler(this.grp_box_donne_commande_Enter);
            // 
            // lb_commande_numero
            // 
            this.lb_commande_numero.AutoSize = true;
            this.lb_commande_numero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lb_commande_numero.ForeColor = System.Drawing.Color.White;
            this.lb_commande_numero.Location = new System.Drawing.Point(299, 64);
            this.lb_commande_numero.Name = "lb_commande_numero";
            this.lb_commande_numero.Size = new System.Drawing.Size(18, 19);
            this.lb_commande_numero.TabIndex = 148;
            this.lb_commande_numero.Text = "1";
            // 
            // lb_commande
            // 
            this.lb_commande.AutoSize = true;
            this.lb_commande.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lb_commande.ForeColor = System.Drawing.Color.White;
            this.lb_commande.Location = new System.Drawing.Point(168, 64);
            this.lb_commande.Name = "lb_commande";
            this.lb_commande.Size = new System.Drawing.Size(113, 19);
            this.lb_commande.TabIndex = 147;
            this.lb_commande.Text = "Commande :";
            // 
            // btn_supp_cmd_gridview
            // 
            this.btn_supp_cmd_gridview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_supp_cmd_gridview.AnimationHoverSpeed = 0.07F;
            this.btn_supp_cmd_gridview.AnimationSpeed = 0.03F;
            this.btn_supp_cmd_gridview.BackColor = System.Drawing.Color.Transparent;
            this.btn_supp_cmd_gridview.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_supp_cmd_gridview.BorderColor = System.Drawing.Color.Empty;
            this.btn_supp_cmd_gridview.BorderSize = 2;
            this.btn_supp_cmd_gridview.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_supp_cmd_gridview.FocusedColor = System.Drawing.Color.Empty;
            this.btn_supp_cmd_gridview.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_supp_cmd_gridview.ForeColor = System.Drawing.Color.White;
            this.btn_supp_cmd_gridview.Image = null;
            this.btn_supp_cmd_gridview.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_supp_cmd_gridview.Location = new System.Drawing.Point(742, 415);
            this.btn_supp_cmd_gridview.Name = "btn_supp_cmd_gridview";
            this.btn_supp_cmd_gridview.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_supp_cmd_gridview.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_supp_cmd_gridview.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_supp_cmd_gridview.OnHoverImage = null;
            this.btn_supp_cmd_gridview.OnPressedColor = System.Drawing.Color.Black;
            this.btn_supp_cmd_gridview.Radius = 5;
            this.btn_supp_cmd_gridview.Size = new System.Drawing.Size(124, 52);
            this.btn_supp_cmd_gridview.TabIndex = 146;
            this.btn_supp_cmd_gridview.Text = "Supprimer ";
            this.btn_supp_cmd_gridview.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_supp_cmd_gridview.Click += new System.EventHandler(this.Supprimer_row_datagridView);
            // 
            // btn_cliquer_ici_Fourniss
            // 
            this.btn_cliquer_ici_Fourniss.BackColor = System.Drawing.Color.Gray;
            this.btn_cliquer_ici_Fourniss.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_cliquer_ici_Fourniss.FlatAppearance.BorderSize = 0;
            this.btn_cliquer_ici_Fourniss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_cliquer_ici_Fourniss.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cliquer_ici_Fourniss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliquer_ici_Fourniss.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliquer_ici_Fourniss.ForeColor = System.Drawing.Color.White;
            this.btn_cliquer_ici_Fourniss.Location = new System.Drawing.Point(414, 114);
            this.btn_cliquer_ici_Fourniss.Name = "btn_cliquer_ici_Fourniss";
            this.btn_cliquer_ici_Fourniss.Size = new System.Drawing.Size(80, 28);
            this.btn_cliquer_ici_Fourniss.TabIndex = 144;
            this.btn_cliquer_ici_Fourniss.Text = "Cliquer ici";
            this.btn_cliquer_ici_Fourniss.UseVisualStyleBackColor = false;
            this.btn_cliquer_ici_Fourniss.Visible = false;
            this.btn_cliquer_ici_Fourniss.Click += new System.EventHandler(this.btn_cliquer_ici_Fourniss_Click);
            // 
            // btn_cliquer_ici_client
            // 
            this.btn_cliquer_ici_client.BackColor = System.Drawing.Color.Gray;
            this.btn_cliquer_ici_client.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_cliquer_ici_client.FlatAppearance.BorderSize = 0;
            this.btn_cliquer_ici_client.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_cliquer_ici_client.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cliquer_ici_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliquer_ici_client.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliquer_ici_client.ForeColor = System.Drawing.Color.White;
            this.btn_cliquer_ici_client.Location = new System.Drawing.Point(414, 114);
            this.btn_cliquer_ici_client.Name = "btn_cliquer_ici_client";
            this.btn_cliquer_ici_client.Size = new System.Drawing.Size(80, 28);
            this.btn_cliquer_ici_client.TabIndex = 143;
            this.btn_cliquer_ici_client.Text = "Cliquer ici";
            this.btn_cliquer_ici_client.UseVisualStyleBackColor = false;
            this.btn_cliquer_ici_client.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_cmd
            // 
            this.dgv_cmd.AllowUserToAddRows = false;
            this.dgv_cmd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgv_cmd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cmd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cmd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_cmd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cmd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cmd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_cmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Produit,
            this.Produit,
            this.Quantité,
            this.Prix,
            this.Montant});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cmd.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_cmd.Location = new System.Drawing.Point(519, 76);
            this.dgv_cmd.Name = "dgv_cmd";
            this.dgv_cmd.ReadOnly = true;
            this.dgv_cmd.Size = new System.Drawing.Size(543, 333);
            this.dgv_cmd.TabIndex = 139;
            this.dgv_cmd.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_cmd_RowsAdded);
            // 
            // id_Produit
            // 
            this.id_Produit.HeaderText = "ID";
            this.id_Produit.Name = "id_Produit";
            this.id_Produit.ReadOnly = true;
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.Name = "Produit";
            this.Produit.ReadOnly = true;
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.Name = "Quantité";
            this.Quantité.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // Montant
            // 
            this.Montant.HeaderText = "Montant";
            this.Montant.Name = "Montant";
            this.Montant.ReadOnly = true;
            // 
            // btn_confirmer_cmd_Client
            // 
            this.btn_confirmer_cmd_Client.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_confirmer_cmd_Client.AnimationHoverSpeed = 0.07F;
            this.btn_confirmer_cmd_Client.AnimationSpeed = 0.03F;
            this.btn_confirmer_cmd_Client.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirmer_cmd_Client.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_confirmer_cmd_Client.BorderColor = System.Drawing.Color.Lime;
            this.btn_confirmer_cmd_Client.BorderSize = 1;
            this.btn_confirmer_cmd_Client.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_confirmer_cmd_Client.Enabled = false;
            this.btn_confirmer_cmd_Client.FocusedColor = System.Drawing.Color.Empty;
            this.btn_confirmer_cmd_Client.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_confirmer_cmd_Client.ForeColor = System.Drawing.Color.White;
            this.btn_confirmer_cmd_Client.Image = ((System.Drawing.Image)(resources.GetObject("btn_confirmer_cmd_Client.Image")));
            this.btn_confirmer_cmd_Client.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_confirmer_cmd_Client.Location = new System.Drawing.Point(51, 415);
            this.btn_confirmer_cmd_Client.Name = "btn_confirmer_cmd_Client";
            this.btn_confirmer_cmd_Client.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_confirmer_cmd_Client.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_confirmer_cmd_Client.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_confirmer_cmd_Client.OnHoverImage = null;
            this.btn_confirmer_cmd_Client.OnPressedColor = System.Drawing.Color.Black;
            this.btn_confirmer_cmd_Client.Radius = 5;
            this.btn_confirmer_cmd_Client.Size = new System.Drawing.Size(153, 52);
            this.btn_confirmer_cmd_Client.TabIndex = 82;
            this.btn_confirmer_cmd_Client.Text = "Confirmer";
            this.btn_confirmer_cmd_Client.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_confirmer_cmd_Client.Click += new System.EventHandler(this.btn_ajout_commande);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(515, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 386);
            this.panel5.TabIndex = 104;
            // 
            // btn_annuler_Commande
            // 
            this.btn_annuler_Commande.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_annuler_Commande.AnimationHoverSpeed = 0.07F;
            this.btn_annuler_Commande.AnimationSpeed = 0.03F;
            this.btn_annuler_Commande.BackColor = System.Drawing.Color.Transparent;
            this.btn_annuler_Commande.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_annuler_Commande.BorderColor = System.Drawing.Color.Red;
            this.btn_annuler_Commande.BorderSize = 1;
            this.btn_annuler_Commande.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_annuler_Commande.FocusedColor = System.Drawing.Color.Empty;
            this.btn_annuler_Commande.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_annuler_Commande.ForeColor = System.Drawing.Color.White;
            this.btn_annuler_Commande.Image = ((System.Drawing.Image)(resources.GetObject("btn_annuler_Commande.Image")));
            this.btn_annuler_Commande.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_annuler_Commande.Location = new System.Drawing.Point(303, 415);
            this.btn_annuler_Commande.Name = "btn_annuler_Commande";
            this.btn_annuler_Commande.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_annuler_Commande.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_annuler_Commande.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_annuler_Commande.OnHoverImage = null;
            this.btn_annuler_Commande.OnPressedColor = System.Drawing.Color.Black;
            this.btn_annuler_Commande.Radius = 5;
            this.btn_annuler_Commande.Size = new System.Drawing.Size(135, 52);
            this.btn_annuler_Commande.TabIndex = 83;
            this.btn_annuler_Commande.Text = "          Annuler";
            this.btn_annuler_Commande.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_annuler_Commande.Click += new System.EventHandler(this.btn_annuler_Commande_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmb_nom_complet);
            this.panel1.Location = new System.Drawing.Point(172, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 48);
            this.panel1.TabIndex = 131;
            // 
            // cmb_nom_complet
            // 
            this.cmb_nom_complet.AutoResize = false;
            this.cmb_nom_complet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_nom_complet.Depth = 0;
            this.cmb_nom_complet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_nom_complet.DropDownHeight = 174;
            this.cmb_nom_complet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nom_complet.DropDownWidth = 121;
            this.cmb_nom_complet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_nom_complet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_nom_complet.FormattingEnabled = true;
            this.cmb_nom_complet.Hint = "Selectionner Client";
            this.cmb_nom_complet.IntegralHeight = false;
            this.cmb_nom_complet.ItemHeight = 43;
            this.cmb_nom_complet.Location = new System.Drawing.Point(0, -1);
            this.cmb_nom_complet.MaxDropDownItems = 4;
            this.cmb_nom_complet.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_nom_complet.Name = "cmb_nom_complet";
            this.cmb_nom_complet.Size = new System.Drawing.Size(236, 49);
            this.cmb_nom_complet.StartIndex = -1;
            this.cmb_nom_complet.TabIndex = 107;
            this.cmb_nom_complet.SelectedIndexChanged += new System.EventHandler(this.cmb_nom_complet_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 19);
            this.label11.TabIndex = 126;
            this.label11.Text = "NOM COMPLET :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 135;
            this.label4.Text = "Montant :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 134;
            this.label3.Text = "Quantités :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 133;
            this.label1.Text = "Nom Produit  :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.tb_prix);
            this.panel6.Location = new System.Drawing.Point(172, 286);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(234, 48);
            this.panel6.TabIndex = 129;
            // 
            // tb_prix
            // 
            this.tb_prix.AnimateReadOnly = false;
            this.tb_prix.BackColor = System.Drawing.Color.White;
            this.tb_prix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_prix.Depth = 0;
            this.tb_prix.Enabled = false;
            this.tb_prix.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_prix.ForeColor = System.Drawing.Color.White;
            this.tb_prix.Hint = "Prix de Produit";
            this.tb_prix.LeadingIcon = null;
            this.tb_prix.Location = new System.Drawing.Point(0, 0);
            this.tb_prix.MaxLength = 50;
            this.tb_prix.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_prix.Multiline = false;
            this.tb_prix.Name = "tb_prix";
            this.tb_prix.Size = new System.Drawing.Size(236, 50);
            this.tb_prix.TabIndex = 32;
            this.tb_prix.Text = "";
            this.tb_prix.TrailingIcon = null;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.tb_qte);
            this.panel4.Location = new System.Drawing.Point(172, 241);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(109, 29);
            this.panel4.TabIndex = 130;
            // 
            // tb_qte
            // 
            this.tb_qte.Enabled = false;
            this.tb_qte.Location = new System.Drawing.Point(0, 0);
            this.tb_qte.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tb_qte.Name = "tb_qte";
            this.tb_qte.Size = new System.Drawing.Size(110, 29);
            this.tb_qte.TabIndex = 145;
            this.tb_qte.ValueChanged += new System.EventHandler(this.tb_qte_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cb_produit_commande);
            this.panel2.Location = new System.Drawing.Point(172, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 48);
            this.panel2.TabIndex = 132;
            // 
            // cb_produit_commande
            // 
            this.cb_produit_commande.AutoResize = false;
            this.cb_produit_commande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_produit_commande.Depth = 0;
            this.cb_produit_commande.DisplayMember = "id_Produit";
            this.cb_produit_commande.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_produit_commande.DropDownHeight = 174;
            this.cb_produit_commande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_produit_commande.DropDownWidth = 121;
            this.cb_produit_commande.Enabled = false;
            this.cb_produit_commande.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_produit_commande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_produit_commande.FormattingEnabled = true;
            this.cb_produit_commande.Hint = "Selectionner Produit";
            this.cb_produit_commande.IntegralHeight = false;
            this.cb_produit_commande.ItemHeight = 43;
            this.cb_produit_commande.Location = new System.Drawing.Point(0, -1);
            this.cb_produit_commande.MaxDropDownItems = 4;
            this.cb_produit_commande.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_produit_commande.Name = "cb_produit_commande";
            this.cb_produit_commande.Size = new System.Drawing.Size(236, 49);
            this.cb_produit_commande.StartIndex = 0;
            this.cb_produit_commande.TabIndex = 106;
            this.cb_produit_commande.ValueMember = "id_Produit";
            this.cb_produit_commande.SelectedIndexChanged += new System.EventHandler(this.cb_produit_commande_SelectedIndexChanged);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.radio_fournisseur);
            this.panel11.Controls.Add(this.radio_Clients);
            this.panel11.Location = new System.Drawing.Point(402, -5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(223, 29);
            this.panel11.TabIndex = 119;
            // 
            // radio_fournisseur
            // 
            this.radio_fournisseur.AutoSize = true;
            this.radio_fournisseur.BackColor = System.Drawing.Color.White;
            this.radio_fournisseur.Depth = 0;
            this.radio_fournisseur.ForeColor = System.Drawing.Color.White;
            this.radio_fournisseur.Location = new System.Drawing.Point(86, -1);
            this.radio_fournisseur.Margin = new System.Windows.Forms.Padding(0);
            this.radio_fournisseur.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio_fournisseur.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio_fournisseur.Name = "radio_fournisseur";
            this.radio_fournisseur.Ripple = true;
            this.radio_fournisseur.Size = new System.Drawing.Size(126, 37);
            this.radio_fournisseur.TabIndex = 119;
            this.radio_fournisseur.TabStop = true;
            this.radio_fournisseur.Text = "Fournisseurs";
            this.radio_fournisseur.UseVisualStyleBackColor = false;
            this.radio_fournisseur.CheckedChanged += new System.EventHandler(this.radio_fournisseur_CheckedChanged);
            // 
            // radio_Clients
            // 
            this.radio_Clients.AutoSize = true;
            this.radio_Clients.Checked = true;
            this.radio_Clients.Depth = 0;
            this.radio_Clients.Location = new System.Drawing.Point(-5, -1);
            this.radio_Clients.Margin = new System.Windows.Forms.Padding(0);
            this.radio_Clients.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio_Clients.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio_Clients.Name = "radio_Clients";
            this.radio_Clients.Ripple = true;
            this.radio_Clients.Size = new System.Drawing.Size(83, 37);
            this.radio_Clients.TabIndex = 117;
            this.radio_Clients.TabStop = true;
            this.radio_Clients.Text = "Clients";
            this.radio_Clients.UseVisualStyleBackColor = true;
            this.radio_Clients.CheckedChanged += new System.EventHandler(this.radio_Clients_CheckedChanged);
            // 
            // btn_ajouter_Commande_Client
            // 
            this.btn_ajouter_Commande_Client.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajouter_Commande_Client.AnimationHoverSpeed = 0.07F;
            this.btn_ajouter_Commande_Client.AnimationSpeed = 0.03F;
            this.btn_ajouter_Commande_Client.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajouter_Commande_Client.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_ajouter_Commande_Client.BorderColor = System.Drawing.Color.Lime;
            this.btn_ajouter_Commande_Client.BorderSize = 1;
            this.btn_ajouter_Commande_Client.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ajouter_Commande_Client.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ajouter_Commande_Client.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajouter_Commande_Client.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter_Commande_Client.Image = null;
            this.btn_ajouter_Commande_Client.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ajouter_Commande_Client.Location = new System.Drawing.Point(154, 548);
            this.btn_ajouter_Commande_Client.Name = "btn_ajouter_Commande_Client";
            this.btn_ajouter_Commande_Client.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_ajouter_Commande_Client.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ajouter_Commande_Client.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ajouter_Commande_Client.OnHoverImage = null;
            this.btn_ajouter_Commande_Client.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ajouter_Commande_Client.Radius = 4;
            this.btn_ajouter_Commande_Client.Size = new System.Drawing.Size(209, 40);
            this.btn_ajouter_Commande_Client.TabIndex = 121;
            this.btn_ajouter_Commande_Client.Text = "Ajouter Commandes";
            this.btn_ajouter_Commande_Client.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ajouter_Commande_Client.Click += new System.EventHandler(this.btn_ajouter_Commande_Client_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Lime;
            this.gunaButton1.BorderSize = 1;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(813, 548);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 4;
            this.gunaButton1.Size = new System.Drawing.Size(209, 40);
            this.gunaButton1.TabIndex = 122;
            this.gunaButton1.Text = "Nouvelle Commande";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.Nouvelle_Commande);
            // 
            // COMMANDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1076, 612);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.btn_ajouter_Commande_Client);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.grp_box_donne_commande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "COMMANDES";
            this.Text = "COMMANDES";
            this.Load += new System.EventHandler(this.COMMANDES_Load);
            this.grp_box_donne_commande.ResumeLayout(false);
            this.grp_box_donne_commande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cmd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_qte)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_cmd;
        private Guna.UI.WinForms.GunaButton btn_confirmer_cmd_Client;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaButton btn_annuler_Commande;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialComboBox cmb_nom_complet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialTextBox tb_prix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialComboBox cb_produit_commande;
        private System.Windows.Forms.Panel panel11;
        private MaterialSkin.Controls.MaterialRadioButton radio_fournisseur;
        private MaterialSkin.Controls.MaterialRadioButton radio_Clients;
        private System.Windows.Forms.GroupBox grp_box_donne_commande;
        private System.Windows.Forms.NumericUpDown tb_qte;
        private System.Windows.Forms.Button btn_cliquer_ici_client;
        private System.Windows.Forms.Button btn_cliquer_ici_Fourniss;
        private Guna.UI.WinForms.GunaButton btn_supp_cmd_gridview;
        private Guna.UI.WinForms.GunaButton btn_ajouter_Commande_Client;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label lb_commande_numero;
        private System.Windows.Forms.Label lb_commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
    }
}