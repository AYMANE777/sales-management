
namespace MY_PROJECT
{
    partial class generer_facture
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
            this.tb_rechercher_cmd = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_rechercher_cmd
            // 
            this.tb_rechercher_cmd.AnimateReadOnly = false;
            this.tb_rechercher_cmd.BackColor = System.Drawing.Color.White;
            this.tb_rechercher_cmd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_rechercher_cmd.Depth = 0;
            this.tb_rechercher_cmd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_rechercher_cmd.ForeColor = System.Drawing.Color.White;
            this.tb_rechercher_cmd.Hint = "Taper ici id du Commande ";
            this.tb_rechercher_cmd.LeadingIcon = null;
            this.tb_rechercher_cmd.Location = new System.Drawing.Point(68, 3);
            this.tb_rechercher_cmd.MaxLength = 50;
            this.tb_rechercher_cmd.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_rechercher_cmd.Multiline = false;
            this.tb_rechercher_cmd.Name = "tb_rechercher_cmd";
            this.tb_rechercher_cmd.Size = new System.Drawing.Size(241, 50);
            this.tb_rechercher_cmd.TabIndex = 94;
            this.tb_rechercher_cmd.Text = "";
            this.tb_rechercher_cmd.TrailingIcon = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tb_rechercher_cmd);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(380, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 50);
            this.panel1.TabIndex = 96;
            // 
            // generer_facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(902, 516);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "generer_facture";
            this.Text = "Genere Facture";
            this.Load += new System.EventHandler(this.generer_facture_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.generer_facture_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.generer_facture_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.generer_facture_MouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox tb_rechercher_cmd;
        private System.Windows.Forms.Panel panel1;
    }
}