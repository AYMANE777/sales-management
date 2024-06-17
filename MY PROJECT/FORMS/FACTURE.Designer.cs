
using System;

namespace MY_PROJECT
{
    partial class FACTURE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FACTURE));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.radio_nom_id_date = new MaterialSkin.Controls.MaterialRadioButton();
            this.radio_date_specifie = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_cas_erreur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_date_fin = new System.Windows.Forms.PictureBox();
            this.lb_date_debut_sp = new System.Windows.Forms.Label();
            this.btn_generer_nom = new Guna.UI.WinForms.GunaButton();
            this.pic_date_debut = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_date_fin = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cb_id = new MaterialSkin.Controls.MaterialComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gEST_VENTE_Client_DataSet = new MY_PROJECT.DataSet.GEST_VENTE_Client_DataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_date_debut_sp = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.radio_nom = new MaterialSkin.Controls.MaterialRadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.clientTableAdapter = new MY_PROJECT.DataSet.GEST_VENTE_Client_DataSetTableAdapters.ClientTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_date_fin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_date_debut)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gEST_VENTE_Client_DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // radio_nom_id_date
            // 
            this.radio_nom_id_date.AutoSize = true;
            this.radio_nom_id_date.Checked = true;
            this.radio_nom_id_date.Depth = 0;
            this.radio_nom_id_date.Location = new System.Drawing.Point(150, 37);
            this.radio_nom_id_date.Margin = new System.Windows.Forms.Padding(0);
            this.radio_nom_id_date.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio_nom_id_date.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio_nom_id_date.Name = "radio_nom_id_date";
            this.radio_nom_id_date.Ripple = true;
            this.radio_nom_id_date.Size = new System.Drawing.Size(261, 37);
            this.radio_nom_id_date.TabIndex = 0;
            this.radio_nom_id_date.TabStop = true;
            this.radio_nom_id_date.Text = "Facture par Nom et interval date";
            this.radio_nom_id_date.UseVisualStyleBackColor = true;
            this.radio_nom_id_date.CheckedChanged += new System.EventHandler(this.radio_id_CheckedChanged);
            // 
            // radio_date_specifie
            // 
            this.radio_date_specifie.AutoSize = true;
            this.radio_date_specifie.Depth = 0;
            this.radio_date_specifie.Location = new System.Drawing.Point(150, 74);
            this.radio_date_specifie.Margin = new System.Windows.Forms.Padding(0);
            this.radio_date_specifie.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio_date_specifie.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio_date_specifie.Name = "radio_date_specifie";
            this.radio_date_specifie.Ripple = true;
            this.radio_date_specifie.Size = new System.Drawing.Size(218, 37);
            this.radio_date_specifie.TabIndex = 2;
            this.radio_date_specifie.TabStop = true;
            this.radio_date_specifie.Text = "Facture par Date Spécifier";
            this.radio_date_specifie.UseVisualStyleBackColor = true;
            this.radio_date_specifie.CheckedChanged += new System.EventHandler(this.materialRadioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lb_cas_erreur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pic_date_fin);
            this.groupBox1.Controls.Add(this.lb_date_debut_sp);
            this.groupBox1.Controls.Add(this.btn_generer_nom);
            this.groupBox1.Controls.Add(this.pic_date_debut);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.radio_nom);
            this.groupBox1.Controls.Add(this.radio_nom_id_date);
            this.groupBox1.Controls.Add(this.radio_date_specifie);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 576);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selectionner La facture";
            // 
            // lb_cas_erreur
            // 
            this.lb_cas_erreur.AutoSize = true;
            this.lb_cas_erreur.ForeColor = System.Drawing.Color.Red;
            this.lb_cas_erreur.Location = new System.Drawing.Point(157, 369);
            this.lb_cas_erreur.Name = "lb_cas_erreur";
            this.lb_cas_erreur.Size = new System.Drawing.Size(0, 19);
            this.lb_cas_erreur.TabIndex = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 135;
            this.label1.Text = "Date Fin  :";
            // 
            // pic_date_fin
            // 
            this.pic_date_fin.Image = ((System.Drawing.Image)(resources.GetObject("pic_date_fin.Image")));
            this.pic_date_fin.Location = new System.Drawing.Point(438, 311);
            this.pic_date_fin.Name = "pic_date_fin";
            this.pic_date_fin.Size = new System.Drawing.Size(31, 27);
            this.pic_date_fin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_date_fin.TabIndex = 137;
            this.pic_date_fin.TabStop = false;
            this.pic_date_fin.Visible = false;
            // 
            // lb_date_debut_sp
            // 
            this.lb_date_debut_sp.AutoSize = true;
            this.lb_date_debut_sp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lb_date_debut_sp.ForeColor = System.Drawing.Color.White;
            this.lb_date_debut_sp.Location = new System.Drawing.Point(18, 254);
            this.lb_date_debut_sp.Name = "lb_date_debut_sp";
            this.lb_date_debut_sp.Size = new System.Drawing.Size(107, 19);
            this.lb_date_debut_sp.TabIndex = 134;
            this.lb_date_debut_sp.Text = "Date Début  :";
            // 
            // btn_generer_nom
            // 
            this.btn_generer_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_generer_nom.AnimationHoverSpeed = 0.07F;
            this.btn_generer_nom.AnimationSpeed = 0.03F;
            this.btn_generer_nom.BackColor = System.Drawing.Color.Transparent;
            this.btn_generer_nom.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_generer_nom.BorderColor = System.Drawing.Color.Lime;
            this.btn_generer_nom.BorderSize = 1;
            this.btn_generer_nom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_generer_nom.FocusedColor = System.Drawing.Color.Empty;
            this.btn_generer_nom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_generer_nom.ForeColor = System.Drawing.Color.Black;
            this.btn_generer_nom.Image = ((System.Drawing.Image)(resources.GetObject("btn_generer_nom.Image")));
            this.btn_generer_nom.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_generer_nom.Location = new System.Drawing.Point(150, 474);
            this.btn_generer_nom.Name = "btn_generer_nom";
            this.btn_generer_nom.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_generer_nom.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_generer_nom.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_generer_nom.OnHoverImage = null;
            this.btn_generer_nom.OnPressedColor = System.Drawing.Color.Black;
            this.btn_generer_nom.Radius = 5;
            this.btn_generer_nom.Size = new System.Drawing.Size(239, 52);
            this.btn_generer_nom.TabIndex = 137;
            this.btn_generer_nom.Text = "Generer une Facture";
            this.btn_generer_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_generer_nom.Click += new System.EventHandler(this.btn_generer_nom_Click);
            // 
            // pic_date_debut
            // 
            this.pic_date_debut.Image = ((System.Drawing.Image)(resources.GetObject("pic_date_debut.Image")));
            this.pic_date_debut.Location = new System.Drawing.Point(438, 248);
            this.pic_date_debut.Name = "pic_date_debut";
            this.pic_date_debut.Size = new System.Drawing.Size(31, 27);
            this.pic_date_debut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_date_debut.TabIndex = 136;
            this.pic_date_debut.TabStop = false;
            this.pic_date_debut.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 134;
            this.label4.Text = "Selectionner  :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.tb_date_fin);
            this.panel3.Location = new System.Drawing.Point(161, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 48);
            this.panel3.TabIndex = 133;
            // 
            // tb_date_fin
            // 
            this.tb_date_fin.AllowPromptAsInput = true;
            this.tb_date_fin.AnimateReadOnly = false;
            this.tb_date_fin.AsciiOnly = false;
            this.tb_date_fin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_date_fin.BeepOnError = false;
            this.tb_date_fin.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tb_date_fin.Depth = 0;
            this.tb_date_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_date_fin.HidePromptOnLeave = false;
            this.tb_date_fin.HideSelection = true;
            this.tb_date_fin.Hint = "MM/dd/yyyy";
            this.tb_date_fin.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.tb_date_fin.LeadingIcon = null;
            this.tb_date_fin.Location = new System.Drawing.Point(0, 0);
            this.tb_date_fin.Mask = "";
            this.tb_date_fin.MaxLength = 32767;
            this.tb_date_fin.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_date_fin.Name = "tb_date_fin";
            this.tb_date_fin.PasswordChar = '\0';
            this.tb_date_fin.PrefixSuffixText = null;
            this.tb_date_fin.PromptChar = '_';
            this.tb_date_fin.ReadOnly = false;
            this.tb_date_fin.RejectInputOnFirstFailure = false;
            this.tb_date_fin.ResetOnPrompt = true;
            this.tb_date_fin.ResetOnSpace = true;
            this.tb_date_fin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_date_fin.SelectedText = "";
            this.tb_date_fin.SelectionLength = 0;
            this.tb_date_fin.SelectionStart = 0;
            this.tb_date_fin.ShortcutsEnabled = true;
            this.tb_date_fin.Size = new System.Drawing.Size(250, 48);
            this.tb_date_fin.SkipLiterals = true;
            this.tb_date_fin.TabIndex = 3;
            this.tb_date_fin.TabStop = false;
            this.tb_date_fin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_date_fin.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tb_date_fin.TrailingIcon = null;
            this.tb_date_fin.UseSystemPasswordChar = false;
            this.tb_date_fin.ValidatingType = null;
            this.tb_date_fin.TextChanged += new System.EventHandler(this.tb_date_fin_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(438, 185);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 136;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.cb_id);
            this.panel5.Location = new System.Drawing.Point(161, 175);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 48);
            this.panel5.TabIndex = 132;
            // 
            // cb_id
            // 
            this.cb_id.AutoResize = false;
            this.cb_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_id.DataSource = this.clientBindingSource;
            this.cb_id.Depth = 0;
            this.cb_id.DisplayMember = "Nom_client";
            this.cb_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_id.DropDownHeight = 174;
            this.cb_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_id.DropDownWidth = 121;
            this.cb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_id.FormattingEnabled = true;
            this.cb_id.Hint = "Selectionner Nom";
            this.cb_id.IntegralHeight = false;
            this.cb_id.ItemHeight = 43;
            this.cb_id.Location = new System.Drawing.Point(0, -1);
            this.cb_id.MaxDropDownItems = 4;
            this.cb_id.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_id.Name = "cb_id";
            this.cb_id.Size = new System.Drawing.Size(250, 49);
            this.cb_id.StartIndex = 0;
            this.cb_id.TabIndex = 0;
            this.cb_id.ValueMember = "id_client";
            this.cb_id.SelectedIndexChanged += new System.EventHandler(this.cb_id_SelectedIndexChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.gEST_VENTE_Client_DataSet;
            // 
            // gEST_VENTE_Client_DataSet
            // 
            this.gEST_VENTE_Client_DataSet.DataSetName = "GEST_VENTE_Client_DataSet";
            this.gEST_VENTE_Client_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tb_date_debut_sp);
            this.panel2.Location = new System.Drawing.Point(161, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 48);
            this.panel2.TabIndex = 132;
            // 
            // tb_date_debut_sp
            // 
            this.tb_date_debut_sp.AllowPromptAsInput = true;
            this.tb_date_debut_sp.AnimateReadOnly = false;
            this.tb_date_debut_sp.AsciiOnly = false;
            this.tb_date_debut_sp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_date_debut_sp.BeepOnError = false;
            this.tb_date_debut_sp.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tb_date_debut_sp.Depth = 0;
            this.tb_date_debut_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_date_debut_sp.HidePromptOnLeave = false;
            this.tb_date_debut_sp.HideSelection = true;
            this.tb_date_debut_sp.Hint = "MM/dd/yyyy";
            this.tb_date_debut_sp.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.tb_date_debut_sp.LeadingIcon = null;
            this.tb_date_debut_sp.Location = new System.Drawing.Point(0, 0);
            this.tb_date_debut_sp.Mask = "";
            this.tb_date_debut_sp.MaxLength = 32767;
            this.tb_date_debut_sp.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_date_debut_sp.Name = "tb_date_debut_sp";
            this.tb_date_debut_sp.PasswordChar = '\0';
            this.tb_date_debut_sp.PrefixSuffixText = null;
            this.tb_date_debut_sp.PromptChar = '_';
            this.tb_date_debut_sp.ReadOnly = false;
            this.tb_date_debut_sp.RejectInputOnFirstFailure = false;
            this.tb_date_debut_sp.ResetOnPrompt = true;
            this.tb_date_debut_sp.ResetOnSpace = true;
            this.tb_date_debut_sp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_date_debut_sp.SelectedText = "";
            this.tb_date_debut_sp.SelectionLength = 0;
            this.tb_date_debut_sp.SelectionStart = 0;
            this.tb_date_debut_sp.ShortcutsEnabled = true;
            this.tb_date_debut_sp.Size = new System.Drawing.Size(250, 48);
            this.tb_date_debut_sp.SkipLiterals = true;
            this.tb_date_debut_sp.TabIndex = 4;
            this.tb_date_debut_sp.TabStop = false;
            this.tb_date_debut_sp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_date_debut_sp.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tb_date_debut_sp.TrailingIcon = null;
            this.tb_date_debut_sp.UseSystemPasswordChar = false;
            this.tb_date_debut_sp.ValidatingType = null;
            this.tb_date_debut_sp.TextChanged += new System.EventHandler(this.tb_date_debut_TextChanged);
            // 
            // radio_nom
            // 
            this.radio_nom.AutoSize = true;
            this.radio_nom.Depth = 0;
            this.radio_nom.Location = new System.Drawing.Point(150, 111);
            this.radio_nom.Margin = new System.Windows.Forms.Padding(0);
            this.radio_nom.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio_nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio_nom.Name = "radio_nom";
            this.radio_nom.Ripple = true;
            this.radio_nom.Size = new System.Drawing.Size(153, 37);
            this.radio_nom.TabIndex = 5;
            this.radio_nom.TabStop = true;
            this.radio_nom.Text = "Facture par Nom";
            this.radio_nom.UseVisualStyleBackColor = true;
            this.radio_nom.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(549, 40);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Nom_Produit";
            series1.YValueMembers = "Qts";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(523, 565);
            this.chart1.TabIndex = 142;
            this.chart1.Text = "chart1";
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // FACTURE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1076, 612);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FACTURE";
            this.Text = "FACTURE";
            this.Load += new System.EventHandler(this.FACTURE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_date_fin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_date_debut)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gEST_VENTE_Client_DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        private void tb_date_debut_sp_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton radio_nom_id_date;
        private MaterialSkin.Controls.MaterialRadioButton radio_date_specifie;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton radio_nom;
        private System.Windows.Forms.PictureBox pic_date_fin;
        private System.Windows.Forms.PictureBox pic_date_debut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_date_debut_sp;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox tb_date_fin;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox tb_date_debut_sp;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialComboBox cb_id;
        private Guna.UI.WinForms.GunaButton btn_generer_nom;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataSet.GEST_VENTE_Client_DataSet gEST_VENTE_Client_DataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSet.GEST_VENTE_Client_DataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Label lb_cas_erreur;
    }
}