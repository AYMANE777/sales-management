using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_PROJECT
{
    public partial class Form1 : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

      
     



        public void loadform(Object Form)
        {
            if (mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form add = Form as Form;
            add.TopLevel = false;
            add.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(add);
            this.mainpanel.Tag = add;
            add.Show();

        }


        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_minimum.Visible = true;
            btn_maximum.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_minimum.Visible = false;
            btn_maximum.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_dashb_Click(null, e);
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (panelleft.Width == 224)
            {
                logo_panel.Visible = false;
                logo_min.Visible = true;
                panelleft.Width = 55;
                btn_dashb.Text = "";
                btn_client.Text = "";
                btn_pProduit.Text = "";
            }
            else
            {
                panelleft.Width = 224;
                logo_panel.Visible = true;
                logo_min.Visible = false;
                btn_dashb.Text = "Tableau de bord";
                btn_client.Text = "CLIENTS";
                btn_pProduit.Text = "PRODUITS";
            }
              
        }
       


       
        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void center_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelheader_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelheader_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panelheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panelheader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void btn_dashb_Click(object sender, EventArgs e)
        {
            panelCLICK.Top = btn_dashb.Top;
            loadform(new Dashboard());
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            panelCLICK.Top = btn_client.Top;
          
            loadform(new Clients());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelCLICK.Top = btn_pProduit.Top;
            loadform(new Produit_Form());
        }

        private void btn_categorie_Click(object sender, EventArgs e)
        {
            panelCLICK.Top = btn_categorie.Top;
            loadform(new form_cat());
        }

      
        private void btn_propos_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelCLICK.Top = btn_commade.Top;
            loadform(new COMMANDES());
        }

        private void btn_commande_Click(object sender, EventArgs e)
        {
            panelCLICK.Top = btn_facture.Top;
            loadform(new FACTURE());
        }

        private void panelleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToLongTimeString();
            lb_date.Text = DateTime.Now.ToLongDateString();
        }
    }
}
