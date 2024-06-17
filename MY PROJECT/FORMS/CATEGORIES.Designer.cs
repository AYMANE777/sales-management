
namespace MY_PROJECT
{
    partial class form_cat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.idcatégorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.groupe_gridview = new System.Windows.Forms.GroupBox();
            this.grid_categorie = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_description_categorie = new System.Windows.Forms.Panel();
            this.tb_description_categorie = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_nom_categorie = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupe_gridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_categorie)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_description_categorie.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idcatégorieDataGridViewTextBoxColumn
            // 
            this.idcatégorieDataGridViewTextBoxColumn.DataPropertyName = "idatégorie";
            this.idcatégorieDataGridViewTextBoxColumn.HeaderText = "ID Catégorie";
            this.idcatégorieDataGridViewTextBoxColumn.Name = "idcatégorieDataGridViewTextBoxColumn";
            this.idcatégorieDataGridViewTextBoxColumn.Width = 129;
            // 
            // gunaButton2
            // 
            this.gunaButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.White;
            this.gunaButton2.BorderColor = System.Drawing.Color.Lime;
            this.gunaButton2.BorderSize = 1;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(50, 50);
            this.gunaButton2.Location = new System.Drawing.Point(704, 328);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 5;
            this.gunaButton2.Size = new System.Drawing.Size(230, 52);
            this.gunaButton2.TabIndex = 82;
            this.gunaButton2.Text = "            Nouveau Catégorie";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.Nouveau_categorie);
            // 
            // groupe_gridview
            // 
            this.groupe_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupe_gridview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.groupe_gridview.Controls.Add(this.grid_categorie);
            this.groupe_gridview.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupe_gridview.ForeColor = System.Drawing.Color.Red;
            this.groupe_gridview.Location = new System.Drawing.Point(0, 11);
            this.groupe_gridview.Name = "groupe_gridview";
            this.groupe_gridview.Size = new System.Drawing.Size(572, 401);
            this.groupe_gridview.TabIndex = 81;
            this.groupe_gridview.TabStop = false;
            this.groupe_gridview.Text = "Listes des Catégorie :";
            // 
            // grid_categorie
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.grid_categorie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_categorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_categorie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_categorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_categorie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_categorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_categorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_categorie.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_categorie.Location = new System.Drawing.Point(6, 63);
            this.grid_categorie.Name = "grid_categorie";
            this.grid_categorie.Size = new System.Drawing.Size(560, 332);
            this.grid_categorie.TabIndex = 110;
            this.grid_categorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_categorie_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel_description_categorie);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(580, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 219);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données Catégorie";
            // 
            // panel_description_categorie
            // 
            this.panel_description_categorie.BackColor = System.Drawing.Color.White;
            this.panel_description_categorie.Controls.Add(this.tb_description_categorie);
            this.panel_description_categorie.Location = new System.Drawing.Point(194, 149);
            this.panel_description_categorie.Name = "panel_description_categorie";
            this.panel_description_categorie.Size = new System.Drawing.Size(263, 64);
            this.panel_description_categorie.TabIndex = 33;
            // 
            // tb_description_categorie
            // 
            this.tb_description_categorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_description_categorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_description_categorie.Depth = 0;
            this.tb_description_categorie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.tb_description_categorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_description_categorie.Hint = "Entrer votre Description";
            this.tb_description_categorie.Location = new System.Drawing.Point(0, 0);
            this.tb_description_categorie.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_description_categorie.Name = "tb_description_categorie";
            this.tb_description_categorie.Size = new System.Drawing.Size(263, 64);
            this.tb_description_categorie.TabIndex = 31;
            this.tb_description_categorie.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tb_nom_categorie);
            this.panel1.Location = new System.Drawing.Point(194, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 48);
            this.panel1.TabIndex = 31;
            // 
            // tb_nom_categorie
            // 
            this.tb_nom_categorie.AnimateReadOnly = false;
            this.tb_nom_categorie.BackColor = System.Drawing.Color.White;
            this.tb_nom_categorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nom_categorie.Depth = 0;
            this.tb_nom_categorie.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_nom_categorie.ForeColor = System.Drawing.Color.White;
            this.tb_nom_categorie.Hint = "Entrer Nom Categorie";
            this.tb_nom_categorie.LeadingIcon = null;
            this.tb_nom_categorie.Location = new System.Drawing.Point(0, 0);
            this.tb_nom_categorie.MaxLength = 50;
            this.tb_nom_categorie.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_nom_categorie.Multiline = false;
            this.tb_nom_categorie.Name = "tb_nom_categorie";
            this.tb_nom_categorie.Size = new System.Drawing.Size(236, 50);
            this.tb_nom_categorie.TabIndex = 32;
            this.tb_nom_categorie.Text = "";
            this.tb_nom_categorie.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom de Catégorie :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description Catégorie :";
            // 
            // gunaButton3
            // 
            this.gunaButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.White;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.BorderSize = 2;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton3.ForeColor = System.Drawing.Color.Black;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(50, 50);
            this.gunaButton3.Location = new System.Drawing.Point(331, 485);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 5;
            this.gunaButton3.Size = new System.Drawing.Size(133, 52);
            this.gunaButton3.TabIndex = 84;
            this.gunaButton3.Text = "             Modifier";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.Update_Categorie);
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.BorderSize = 2;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.gunaButton1.Location = new System.Drawing.Point(90, 485);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 5;
            this.gunaButton1.Size = new System.Drawing.Size(150, 52);
            this.gunaButton1.TabIndex = 83;
            this.gunaButton1.Text = "Supprimer ";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton1.Click += new System.EventHandler(this.Supprimer_Categorie);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(209, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 19);
            this.label8.TabIndex = 106;
            this.label8.Text = "Selectionner pour :";
            // 
            // form_cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.groupe_gridview);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_cat";
            this.Text = "CATEGORIES";
            this.Load += new System.EventHandler(this.CATEGORIES_Load);
            this.groupe_gridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_categorie)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_description_categorie.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idcatégorieDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.GroupBox groupe_gridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_description_categorie;
        private MaterialSkin.Controls.MaterialMultiLineTextBox tb_description_categorie;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox tb_nom_categorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView grid_categorie;
    }
}