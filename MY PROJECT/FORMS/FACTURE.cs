using MY_PROJECT.Crystal_Report;
using MY_PROJECT.DataSet;
using MY_PROJECT.Entity_Model;
using MY_PROJECT.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_PROJECT
{
    public partial class FACTURE : Form
    {
        GEST_VENTE_Entities gest = new GEST_VENTE_Entities();
        Generation_du_Facture generation = new Generation_du_Facture();
        public FACTURE()
        {
            InitializeComponent();
        }
        public void Remplissage_Chart()
        {
           
            
                GEST_VENTE_Client_DataSet data = new GEST_VENTE_Client_DataSet();
                DataSet.GEST_VENTE_Client_DataSetTableAdapters.DETAIL_CMD_CLIENTTableAdapter client = new DataSet.GEST_VENTE_Client_DataSetTableAdapters.DETAIL_CMD_CLIENTTableAdapter();
                if (cb_id.SelectedValue.ToString() != "")
                {
                    int select_id = int.Parse(cb_id.SelectedValue.ToString());
                    client.Fill_Chart_counting(data.DETAIL_CMD_CLIENT, select_id);

                    chart1.DataSource = data.DETAIL_CMD_CLIENT;
                    chart1.Series[0].XValueMember = "Nom_Produit";
                    chart1.Series[0].YValueMembers = "Qts";
                }
            
     
            
        }
        public void Remplissage_Combo(bool a)
        {
            if (a)
            {
                cb_id.DataSource = gest.Clients.ToList();
                cb_id.ValueMember = "id_client";
                cb_id.DisplayMember = "Nom_client";
            }
            else
            {
                cb_id.DataSource = gest.Fournisseurs.ToList();
                cb_id.ValueMember = "id_Fournisseur";
                cb_id.DisplayMember = "Nom_Fourniss";
            }
        }
        GEST_VENTE_Client_DataSet data = new GEST_VENTE_Client_DataSet();

 

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_date_specifie.Checked)
            {
                cb_id.Enabled = true;
                tb_date_fin.Enabled = false;
                tb_date_debut_sp.Enabled = true;
                lb_date_debut_sp.Text = "Spécifier la date :";
            }
            
           
        }

        private void radio_id_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_nom_id_date.Checked)
            {
                cb_id.Enabled = true;
                tb_date_debut_sp.Enabled = true;
                tb_date_fin.Enabled = true;
                lb_date_debut_sp.Text = "Date Début  :";

            }
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_nom.Checked)
            {
                tb_date_fin.Enabled = false;
                tb_date_debut_sp.Enabled = false;
                cb_id.Enabled = true;
                lb_date_debut_sp.Text = "Date Début  :";

            }
        }

        private void FACTURE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gEST_VENTE_Client_DataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill_By_name_client(this.gEST_VENTE_Client_DataSet.Client);

            Remplissage_Chart();


        }

        private void cb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_id.SelectedValue != null)
            {
                Remplissage_Chart();
                chart1.DataBind();
           


            }
        }

        private void btn_generer_nom_Click(object sender, EventArgs e)
        {

            try
            {
                
                int get_id_client = int.Parse(cb_id.SelectedValue.ToString());
               
                
                    if (radio_nom_id_date.Checked)
                    {
                        if (Regex_validate_date(tb_date_debut_sp.Text, tb_date_fin.Text) && radio_nom_id_date.Checked)
                        {


                            if (generation.Report_Client(get_id_client, tb_date_debut_sp.Text, tb_date_fin.Text))
                            {
                                generation.Show();

                            }
                        }

                    }
                    else if (radio_nom.Checked)
                    {
                        if (generation.Report_Client_With_Nom(get_id_client))
                        {
                            generation.Show();
                        }
                    }
                    else if (radio_date_specifie.Checked)
                    {
                        if (generation.Report_Client_with_date_sp(get_id_client, tb_date_debut_sp.Text))
                        {
                            generation.Show();
                        }
                    }
                    else
                    {
                        lb_cas_erreur.Text = "La date n'est pas Valid !";
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }



        public bool Regex_validate_date(string date_debut ,string date_fin)
        {

            Regex regex = new Regex(@"((0[1-9]|1[0-2])\/((0|1)[0-9]|2[0-9]|3[0-1])/((19|20)\d\d))$");
            if(regex.IsMatch(date_debut) && regex.IsMatch(date_fin))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

     

        private void tb_date_debut_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"((0[1-9]|1[0-2])\/((0|1)[0-9]|2[0-9]|3[0-1])/((19|20)\d\d))$");
            if (regex.IsMatch(tb_date_debut_sp.Text))
            {
                pic_date_debut.Visible = true;
                btn_generer_nom.Enabled = true;
            }
            else { pic_date_debut.Visible = false;btn_generer_nom.Enabled = false; }
        }

        private void tb_date_fin_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"((0[1-9]|1[0-2])\/((0|1)[0-9]|2[0-9]|3[0-1])/((19|20)\d\d))$");
            if (regex.IsMatch(tb_date_fin.Text))
            {
                pic_date_fin.Visible = true;
                btn_generer_nom.Enabled = true;
            }
            else { pic_date_fin.Visible = false;btn_generer_nom.Enabled = false; }
        }

        private void radio_fournisseur_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }

        private void radio_Clients_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
