using MY_PROJECT.Class;
using MY_PROJECT.Entity_Model;
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
    public partial class COMMANDES : Form
    {

        GEST_VENTE_Entities gest = new GEST_VENTE_Entities();
        Commande cmd = new Commande();
     
        
        

        public COMMANDES()
        {
            InitializeComponent();
        }
        public bool testerchamps()
        {
            if ( cmb_nom_complet.Text == "" && cb_produit_commande.Text == "" && tb_qte.Text == "" && tb_prix.Text == "")
            {
                return false;
            }
            else { return true; }
        }
        public void lister_cmb_Commande_client(bool cas)
        {
            if (cas)
            {
               
                var cli = (gest.Clients).ToList();
               
                cmb_nom_complet.DataSource = cli;
                cmb_nom_complet.DisplayMember = "Nom_client";
                cmb_nom_complet.ValueMember = "id_client";
            }
            else
            {
                var pdt = (gest.Produits).ToList();
                cb_produit_commande.DataSource = pdt;
                cb_produit_commande.DisplayMember = "Nom_Produit";
                cb_produit_commande.ValueMember = "id_Produit";
            }

        }
        public void lister_cmb_Commande_Fournisseur(bool cas)
        {
            if (cas)
            {
                var cli = (gest.Fournisseurs).ToList();
                cmb_nom_complet.DataSource = cli;
                cmb_nom_complet.DisplayMember = "Nom_Fourniss";
                cmb_nom_complet.ValueMember = "id_Fournisseur";
            }
            else
            {
                var pdt = (gest.Produits).ToList();
                cb_produit_commande.DataSource = pdt;
                cb_produit_commande.DisplayMember = "Nom_Produit";
                cb_produit_commande.ValueMember = "id_Produit";
            }

        }
       

        private void COMMANDES_Load(object sender, EventArgs e)
        {
            lister_cmb_Commande_client(false);
            //this.produitTableAdapter.Fill(this.gEST_VENTEDataSet1.Produit);
            if (radio_Clients.Checked)
            {
                var counting_clt = gest.Commande_Client.Select(x => x.ID_CMD).DefaultIfEmpty(0).Max();
                lb_commande_numero.Text = counting_clt.ToString();
            }
          
            lister_cmb_Commande_client(true);
 
           
        }
        
        private void cb_produit_commande_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radio_Clients.Checked)
            {
                if (cb_produit_commande.SelectedValue != null)
                {
                    int a = int.Parse(cb_produit_commande.SelectedValue.ToString());
                    tb_qte.Maximum = (decimal)cmd.GetProduit(a).Quantite_Produit_stock;

                }
            }else if (radio_fournisseur.Checked)
            {
                tb_qte.Maximum = decimal.MaxValue;
            }

        }

        private void btn_annuler_Commande_Click(object sender, EventArgs e)
        {
            try
            {
                cmb_nom_complet.SelectedIndex =0; cb_produit_commande.SelectedIndex = -1; tb_qte.Value=0; tb_prix.Text = string.Empty;               
            }
            catch(Exception EX) { MessageBox.Show(EX.Message); }
            
        }

        private void btn_generer_Click(object sender, EventArgs e)
        {
           
        }

        private void grp_box_donne_commande_Enter(object sender, EventArgs e)
        {
           
        }


      
        private void btn_ajout_commande(object sender, EventArgs e)
        {
            try
            {
             
                if (cb_produit_commande.SelectedIndex != -1 && tb_qte.Value != 0)
                {

                    int a = int.Parse(cb_produit_commande.SelectedValue.ToString());
                    var result = gest.Produits.Where(x => x.id_Produit == a).Single();


                    float prix_total = (float)(int.Parse(tb_qte.Value.ToString()) * result.Prix_vent);
                    float price = (float)result.Prix_vent;
                  
                    bool exist = false;
                    int posI = 0;
                    if (dgv_cmd.Rows.Count > 0)
                    {

                        for (int i = 0; i < dgv_cmd.Rows.Count; i++)
                        {

                            if (dgv_cmd.Rows[i].Cells[1].Value.ToString() == cb_produit_commande.Text)
                            {


                                exist = true;
                                posI = i;
                                break;

                            }

                        }
                        if (exist == true)
                        {
                            dgv_cmd.Rows[posI].Cells[2].Value = int.Parse(dgv_cmd.Rows[posI].Cells[2].Value.ToString()) + int.Parse(tb_qte.Value.ToString());
                            dgv_cmd.Rows[posI].Cells[4].Value = int.Parse(dgv_cmd.Rows[posI].Cells[2].Value.ToString()) * float.Parse(dgv_cmd.Rows[posI].Cells[3].Value.ToString());

                        }
                        else
                        {
                            dgv_cmd.Rows.Add(cb_produit_commande.SelectedValue, cb_produit_commande.Text, tb_qte.Value.ToString(), price.ToString(), prix_total.ToString());
                        }
                    }
                    else if (dgv_cmd.Rows.Count == 0)
                    {
                        dgv_cmd.Rows.Add(cb_produit_commande.SelectedValue, cb_produit_commande.Text, tb_qte.Value.ToString(), price.ToString(), prix_total.ToString());
                    }
                    tb_qte.Value = 0;
                }

                else
                {
                    MessageBox.Show("Veuillez Saisir La Quantité");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void radio_Clients_CheckedChanged(object sender, EventArgs e)
        {
            lister_cmb_Commande_client(true);
            lister_cmb_Commande_client(false);
            cmb_nom_complet.Hint = "Selectionner Client";
            btn_confirmer_cmd_Client.Visible = true;
            btn_cliquer_ici_client.Visible = true;
            btn_cliquer_ici_Fourniss.Visible = false;

            dgv_cmd.Rows.Clear();
            var counting_clt = gest.Commande_Client.Select(x => x.ID_CMD).DefaultIfEmpty(0).Max();
            lb_commande_numero.Text = counting_clt.ToString();

        }

        private void radio_fournisseur_CheckedChanged(object sender, EventArgs e)
        {
            lister_cmb_Commande_Fournisseur(true);
            lister_cmb_Commande_Fournisseur(false);
            cmb_nom_complet.Hint = "Selectionner Fournisseur";
            btn_cliquer_ici_client.Enabled = true;
            btn_confirmer_cmd_Client.Enabled = false;
            cmb_nom_complet.Enabled = true;
            cb_produit_commande.Enabled = false;
            tb_qte.Enabled = false;
           // date_cmd.Enabled = false;
            btn_cliquer_ici_client.Visible = false;
            btn_cliquer_ici_Fourniss.Visible = true;
            dgv_cmd.Rows.Clear();
            var counting_frns = gest.Commande_FOURNISSEUR.Select(x => x.ID_CMD_FRNS).DefaultIfEmpty(0).Max();
            lb_commande_numero.Text =counting_frns.ToString();




        }

        private void Generer_Fourniss(object sender, EventArgs e)
        {
          
        }

       

      

        private void cmb_nom_complet_SelectedIndexChanged(object sender, EventArgs e)
        {
          
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radio_Clients.Checked)
                {
                   

                    
                    DialogResult dialog = MessageBox.Show("Voulez-vous vraiment choisissez Client :" + cmb_nom_complet.Text + "", "Information", MessageBoxButtons.OKCancel);
                    if (dialog == DialogResult.OK)
                    {
                        cmb_nom_complet.Enabled = false;
                        cb_produit_commande.Enabled = true;
                        tb_qte.Enabled = true;
                       // date_cmd.Enabled = true;
                        btn_confirmer_cmd_Client.Enabled = true;

                        if (cmb_nom_complet.Enabled == false)
                        {
                            btn_cliquer_ici_client.Enabled = false;
                        }


                    }
                   
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void tb_qte_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (radio_Clients.Checked && cb_produit_commande.SelectedIndex!=-1)
                {
                    int a = int.Parse(cb_produit_commande.SelectedValue.ToString());
                    var result = gest.Produits.Where(x => x.id_Produit == a).Single();

                    float prix_total = (float)(int.Parse(tb_qte.Value.ToString()) * result.Prix_vent);
                    tb_prix.Text = prix_total.ToString();
                }
                else if(radio_fournisseur.Checked && cb_produit_commande.SelectedIndex != -1)
                {

                    
                        int a = int.Parse(cb_produit_commande.SelectedValue.ToString());

                      var result = gest.Produits.Where(x => x.id_Produit == a).Single();
                    float prix_total = (float)(int.Parse(tb_qte.Value.ToString()) * result.Prix_vent);
                       tb_prix.Text = prix_total.ToString();
                    

                }
                

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_cliquer_ici_Fourniss_Click(object sender, EventArgs e)
        {
           if (radio_fournisseur.Checked)
           {
                DialogResult dialog1 = MessageBox.Show("Voulez-vous vraiment choisissez Fournisseur :" + cmb_nom_complet.Text + "", "Information", MessageBoxButtons.OKCancel);
                if (dialog1 == DialogResult.OK)
                {
                    btn_cliquer_ici_client.Enabled = false;
                    cmb_nom_complet.Enabled = false;
                    cb_produit_commande.Enabled = true;
                    tb_qte.Enabled = true;
                  //  date_cmd.Enabled = true;
                    btn_confirmer_cmd_Client.Enabled = true;

                    if (cmb_nom_complet.Enabled == false)
                    {
                        btn_cliquer_ici_client.Enabled = false;
                    }
                }
                else
                {
                    return;
                }
           }
        }

        private void btn_generer_facture_Click(object sender, EventArgs e)
        {
          DialogResult dialog=  MessageBox.Show("Voulez-vous vraiment Generer La facture du Client : " + cmb_nom_complet.Text, "Alert", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (dgv_cmd.Rows.Count > 0)
                {
                    for (int i = 0; i < dgv_cmd.Rows.Count; i++)
                    {
                       // cmd.Ajouter_Commande_Client(Convert.ToDateTime(dgv_cmd.Rows[i].Cells[5].Value), int.Parse(dgv_cmd.Rows[i].Cells[2].Value.ToString()), int.Parse(cmb_nom_complet.SelectedValue.ToString()), int.Parse(dgv_cmd.Rows[i].Cells[0].Value.ToString()));
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez Ajouter une Commande","Information");
                }
                   
            }
        }

     
        private void Supprimer_row_datagridView(object sender, EventArgs e)
        {
            if (dgv_cmd.Rows.Count >0)
            {
                DialogResult dialog = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Alert !", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    dgv_cmd.Rows.RemoveAt(dgv_cmd.CurrentCell.RowIndex);
                }
            }
        
        }

        private void btn_ajouter_Commande_Client_Click(object sender, EventArgs e)
        {
            try
            {
                if (radio_Clients.Checked)
                {
                    if (dgv_cmd.Rows.Count != 0)
                    {
                        DialogResult dialog = MessageBox.Show("Êtes-vous sûr !", "Information", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            bool success = false;
                            cmd.Ajouter_Commande_Client(Convert.ToDateTime(DateTime.Now), int.Parse(cmb_nom_complet.SelectedValue.ToString()));
                            var count = gest.Commande_Client.Select(x => x.ID_CMD).DefaultIfEmpty(0).Max();

                            for (int i = 0; i < dgv_cmd.Rows.Count; i++)
                            {

                                cmd.Ajouter_Detail_Commande_Client(int.Parse(dgv_cmd.Rows[i].Cells[0].Value.ToString()), count, int.Parse(dgv_cmd.Rows[i].Cells[2].Value.ToString()), float.Parse(dgv_cmd.Rows[i].Cells[3].Value.ToString()));
                                var count2 = gest.DETAIL_CMD_CLIENT.Select(x => x.ID_CMD).DefaultIfEmpty(0).Max();
                                lb_commande_numero.Text = string.Empty;
                                int somme = count2 + 1;
                                lb_commande_numero.Text = somme.ToString();
                                success = true;
                            }
                            if (success == true)
                            {
                                MessageBox.Show("Ajout Success");
                                dgv_cmd.Rows.Clear();

                            }
                        }

                    }
                }
                else
                {
                    //DialogResult dialog1 = MessageBox.Show("Are you Sure !", "Information", MessageBoxButtons.YesNo);
                    if (dgv_cmd.Rows.Count != 0)
                    {
                        DialogResult dialog = MessageBox.Show("Êtes-vous sûr !", "Information", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            bool success = false;
                            cmd.Ajouter_Commande_Fournisseur(Convert.ToDateTime(DateTime.Now), int.Parse(cmb_nom_complet.SelectedValue.ToString()));
                            var count = gest.Commande_FOURNISSEUR.Select(x => x.ID_CMD_FRNS).DefaultIfEmpty(0).Max();

                            for (int i = 0; i < dgv_cmd.Rows.Count; i++)
                            {
                                cmd.Ajouter_Detail_Commande_FOURNISSEUR(int.Parse(dgv_cmd.Rows[i].Cells[0].Value.ToString()), count, int.Parse(dgv_cmd.Rows[i].Cells[2].Value.ToString()), float.Parse(dgv_cmd.Rows[i].Cells[3].Value.ToString()));
                                var count2 = gest.Commande_FOURNISSEUR.Select(x => x.ID_CMD_FRNS).DefaultIfEmpty(0).Max();
                                lb_commande_numero.Text = "";
                                int somme = count2 + 1;
                                lb_commande_numero.Text = somme.ToString();
                                success = true;
                            }
                            if (success == true)
                            {
                                MessageBox.Show("Ajout Success");
                                dgv_cmd.Rows.Clear();
                            }
                        }
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_cmd_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void Nouvelle_Commande(object sender, EventArgs e)
        {
            try
            {
                dgv_cmd.Rows.Clear();
                if (radio_Clients.Checked)
                {
                    cmb_nom_complet.Hint = "Selectionner Client";
                    btn_cliquer_ici_client.Enabled = true;
                    cmb_nom_complet.Enabled = true;
                    cb_produit_commande.Enabled = false;
                   
                    tb_qte.Enabled = false;
                    tb_prix.Enabled = false;
                    cb_produit_commande.SelectedIndex = -1;

                    tb_qte.Value = 0;
                    tb_prix.Text = string.Empty;
                    dgv_cmd.Rows.Clear();
                    var counting_clt = gest.Commande_Client.Select(x => x.ID_CMD).DefaultIfEmpty(0).Max();
                    lb_commande_numero.Text = counting_clt.ToString();
                }
                else if(radio_fournisseur.Checked)
                {
                    cmb_nom_complet.Hint = "Selectionner Fournisseur";
                    btn_cliquer_ici_Fourniss.Enabled = true;
                    cmb_nom_complet.Enabled = true;
                    cb_produit_commande.Enabled = false;
                    tb_qte.Enabled = false;
                    // date_cmd.Enabled = false;
                    tb_prix.Enabled = false;
                    cb_produit_commande.SelectedIndex = -1;
                    tb_qte.Value = 0;

                    tb_prix.Text = string.Empty;
                    dgv_cmd.Rows.Clear();
                    var counting_frns = gest.Commande_FOURNISSEUR.Select(x => x.ID_CMD_FRNS).DefaultIfEmpty(0).Max();
                    lb_commande_numero.Text = counting_frns.ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }

        private void Testing(object sender, EventArgs e)
        {
            try
            {
                //generer_facture generer = new generer_facture();
              
                //generer.ShowDialog();
                //string index = generer.dgv_liste_cmd.Rows[dgv_cmd.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
