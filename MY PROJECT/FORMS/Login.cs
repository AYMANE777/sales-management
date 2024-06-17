using MY_PROJECT.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_PROJECT
{
    public partial class Login : Form
    {


        Global global = new Global();
        
        
        //Mouvement
        bool drag = false; Point start_point = new Point(0, 0);

        public void verification()
        {
            if (tb_utilisateur.Text=="" || tb_password.Text=="")
            {
                btn_connecter_ici.BorderColor = Color.Red;
                btn_connection.BorderColor = Color.Red;
                btn_connection.Enabled = false;
                btn_connecter_ici.Enabled = false;
            }
            else
            {
                btn_connecter_ici.Enabled = true;
                btn_connecter_ici.BorderColor = Color.Lime;
                btn_connection.Enabled = true;
                btn_connection.BorderColor = Color.Lime;
            }
        }
       public void IsEnabled(bool enable)
        {
            if (enable == false)
            {
                lb_ajour.Hide();
                tb_mettreajour.Hide();
                btn_lastmodifier.Hide();
            }
            else
            {
                lb_ajour.Show();
                tb_mettreajour.Show();
                btn_lastmodifier.Show();

            }
           
        }

        public Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void switch_mode_CheckedChanged_2(object sender, EventArgs e)
        {
          
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

      
        private void gunaButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            verification();
            IsEnabled(false);
        }
 
        private void btn_connection_Click(object sender, EventArgs e)
        {
            try
            {
                if (global.Connection(tb_utilisateur.Text.Trim(), tb_password.Text.Trim()))
                {
                   
                    lb_erreur.Text = "Login Success";
                    this.Hide();
                   
                }
                else
                {
                    lb_erreur.ForeColor = Color.Red;
                    lb_erreur.Text = "l'utilisateur ou password est incorrect";
                    return;
                }
            }
            catch(Exception ex)
            {
                lb_erreur.Text = "Un erreur s'est produit "+ex.Message;
            }
           
           
        }

        private void tb_utilisateur_TextChanged_1(object sender, EventArgs e)
        {
            verification();
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            verification();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            IsEnabled(true);
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_lastmodifier_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (global.checkSecure(tb_mettreajour.Text.Trim(),tb_utilisateur.Text,tb_password.Text))
                {
                    tb_mettreajour.ReadOnly = true;
                    lb_erreur.ForeColor = Color.Lime;
                    lb_erreur.Text = "Nom secure est correct";

                    tb_mettreajour.ReadOnly = false;
                    btn_connection.Visible = false;
                    btn_connecter_ici.Visible = true;
                    
                    IsEnabled(false);
                }
                else
                {
                    lb_erreur.ForeColor = Color.Red;
                    lb_erreur.Text = "Le nom de secure est incorrect";
                    IsEnabled(true);
                }


            }
            catch(Exception ex)
            {
                lb_erreur.Text = ex.Message;
            }
            
        }

        private void btn_connecter_ici_Click(object sender, EventArgs e)
        {
            if (this.btn_connecter_ici.Visible == true)
            {
                global.update(tb_utilisateur.Text.Trim(), tb_password.Text.Trim(),tb_mettreajour.Text);
                tb_mettreajour.ReadOnly = true;
                this.Hide();
                Form1 acceuil = new Form1();
                acceuil.Show();
            }
            else
            {
                return;
            }
        }
    }
}
