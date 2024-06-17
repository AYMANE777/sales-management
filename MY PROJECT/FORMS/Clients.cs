using MY_PROJECT.Class;
using MY_PROJECT.Entity_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_PROJECT
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }
        Global global = new Global();
        GEST_VENTE_Entities gest = new GEST_VENTE_Entities();
        Fournisseur_Class fournisseur = new Fournisseur_Class();

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        public void RemplissageGrid(bool test)
        {
            if (test == true)
            {
                dgv_client.DataSource = gest.Clients.Select(x => new { ID = x.id_client, NOM = x.Nom_client, Email = x.email, Tél = x.telephone, CIN = x.CIN, Adresse = x.Adresse, Ville = x.ville}).OrderBy(x => x.ID).ToList();
            }
            else
            {
                dgv_client.DataSource = gest.Fournisseurs.Select(x => new { ID = x.id_Fournisseur, NOM = x.Nom_Fourniss, Email = x.email_Fournisseur, Tél = x.telephone_Fournisseur, CIN = x.CIN_Fournisseur, Adresse = x.adresse_fournisseur, Ville = x.pays }).OrderBy(x=>x.ID).ToList();
            }
        }

        private void Clients_Load(object sender, EventArgs e)
        {
           
            RemplissageGrid(true);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_id_Click(object sender, EventArgs e)
        {

        }
        


        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool testerChamps()
        {
            if(tb_nom_complet.Text != string.Empty && tb_email.Text != string.Empty && tb_telephone.Text != string.Empty && tb_cin_client.Text != string.Empty && tb_adresse.Text != string.Empty && tb_ville_pays.Text != string.Empty)
            {
                return true;
            }
            else { return false; }
        }
        byte[] byteImage;
        private void btn_ajouterP_Click(object sender, EventArgs e)
        {
           
           
           
        }
      
       
        private void tb_telephone_Validated(object sender, EventArgs e)
        {

        }

       
         
        public void Update_Client()
        {
            try
            {
                int id = int.Parse(dgv_client.Rows[dgv_client.CurrentCell.RowIndex].Cells[0].Value.ToString());
               
                    MemoryStream ms = new MemoryStream();
                    client_photo.Image.Save(ms, client_photo.Image.RawFormat);
                    byteImage = ms.ToArray();
                    global.updateClient(id,tb_nom_complet.Text, tb_email.Text, tb_telephone.Text, tb_cin_client.Text, tb_adresse.Text, tb_ville_pays.Text, byteImage);
                   
                    MessageBox.Show("Il a Mise à Jour avec succès", "Processus Mise à Jour", MessageBoxButtons.OK, MessageBoxIcon.Information);          
                RemplissageGrid(true);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void Update_Fournisseur()
        {
            try
            {
                int id = int.Parse(dgv_client.Rows[dgv_client.CurrentCell.RowIndex].Cells[0].Value.ToString());

                MemoryStream ms = new MemoryStream();
                client_photo.Image.Save(ms, client_photo.Image.RawFormat);
                byteImage = ms.ToArray();
                fournisseur.update_Fournisseur(id, tb_nom_complet.Text, tb_email.Text, tb_telephone.Text, tb_cin_client.Text, tb_adresse.Text, tb_ville_pays.Text, byteImage);

                MessageBox.Show("Il a Mise à Jour avec succès", "Processus Mise à Jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RemplissageGrid(true);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radio_fournisseur_CheckedChanged(object sender, EventArgs e)
        {
            grb_client.Text = "Ajouter un Fournisseur";
            grb_liste_client.Text = "Liste Fournisseurs";
            tb_rechercher_client.Hint = "Taper ici Nom du Fournisseur";
            btn_ajouter_fourniss.Visible = true;
            btn_ajouter_fourniss.Enabled = true;
            btn_ajouter_Client.Visible = false;
            btn_sup_client.Visible = false;
            btn_supp_fourniss.Visible = true;
            btn_modifier_Client.Visible = false;
            btn_modif_fournisseur.Visible = true;
            RemplissageGrid(false);
            
          
        }

        private void radio_Clients_CheckedChanged(object sender, EventArgs e)
        {
            grb_client.Text = "Ajouter un Client";
            grb_liste_client.Text = "Liste Clients";
            tb_rechercher_client.Hint = "Taper ici Nom du Client";
            btn_ajouter_fourniss.Visible = false;
            btn_ajouter_Client.Visible = true;
            btn_sup_client.Visible = true;
            btn_supp_fourniss.Visible = false;
            btn_modifier_Client.Visible = true;
            btn_supp_fourniss.Visible = false;
            RemplissageGrid(true);

        }
        public bool Tester_Tous_Champs()
        {
            Regex Adresse = new Regex(@"^[A-Za-z0-9]+(?:\s[A-Za-z0-9'_-]+)+$");
            Regex regex_nom_compler = new Regex(@"^[A-Z]{1}[A-Z-a-z]{1,10}\s[A-Z-a-z]{1}[a-z]{1,10}$");
            Regex regex_cin = new Regex(@"^[A-Z]{1}[0-9]{3,10}$");
            Regex regex_email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Regex regex_tele = new Regex(@"^[0-9]{10}$");
            Regex regex_pays = new Regex(@"^[A-Z-a-z]{3,10}$");
            if (Adresse.IsMatch(tb_adresse.Text) && regex_nom_compler.IsMatch(tb_nom_complet.Text) && regex_cin.IsMatch(tb_cin_client.Text) && regex_email.IsMatch(tb_email.Text) && regex_tele.IsMatch(tb_telephone.Text) && regex_pays.IsMatch(tb_ville_pays.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_ajouter_fourniss_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tester_Tous_Champs())

                {

                    MemoryStream ms = new MemoryStream();
                    client_photo.Image.Save(ms, client_photo.Image.RawFormat);
                    byteImage = ms.ToArray();

                    fournisseur.Ajouter_Fournisseur(tb_nom_complet.Text, tb_email.Text, tb_telephone.Text, tb_cin_client.Text, tb_adresse.Text, tb_ville_pays.Text, byteImage);
                    RemplissageGrid(false);
                    tb_nom_complet.Clear(); tb_email.Clear(); tb_telephone.Clear(); tb_cin_client.Clear(); tb_adresse.Clear(); tb_ville_pays.Clear();


                }
                else
                {
                    MessageBox.Show("veuillez remplir tous les champs svp !!", "information !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Modifier(object sender, EventArgs e)
        {
            if (Tester_Tous_Champs())
            {
                Update_Client();
                RemplissageGrid(true);
            }
            else
                MessageBox.Show("Champs invalid !");
        }

        private void img_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images Files|*.JPG; *.PNG; *.GIF; *.BMP";
            if (op.ShowDialog() == DialogResult.OK)
            {
                client_photo.Image = Image.FromFile(op.FileName);
            }
        }

        private void tb_rechercher_client_TextChanged(object sender, EventArgs e)
        {
            var test = gest.Clients.Where(x => x.Nom_client.Contains(tb_rechercher_client.Text)).Select(x => new {
                Num_Client = x.id_client,
                NOM = x.Nom_client,
                Email = x.email,
                Tél = x.telephone,
                CIN = x.CIN,
                Adresse = x.Adresse,
                Ville = x.ville,
                Image = x.image_client
            }).ToList();
            dgv_client.DataSource = test;
        }


        //affecter au controle les champs selectionee au grid view 
        private void dgv_client_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btn_ajouter_Client_Click(object sender, EventArgs e)
        {
            try
            {
                if (testerChamps())

                {

                    MemoryStream ms = new MemoryStream();
                    client_photo.Image.Save(ms, client_photo.Image.RawFormat);
                    byteImage = ms.ToArray();

                    global.ajouterClient(tb_nom_complet.Text, tb_email.Text, tb_telephone.Text, tb_cin_client.Text, tb_adresse.Text, tb_ville_pays.Text, byteImage);
                    RemplissageGrid(true);
                    tb_nom_complet.Clear(); tb_email.Clear(); tb_telephone.Clear(); tb_cin_client.Clear(); tb_adresse.Clear(); tb_ville_pays.Clear();


                }
                else
                {
                    MessageBox.Show("veuillez remplir tous les champs svp !!", "information !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Supprimer_Client(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("La suppression de ce client mener à supprimer tous les Commandes de cette Client !", "Important !", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dgv_client.Rows[dgv_client.CurrentCell.RowIndex].Cells[0].Value.ToString() != null)
                {
                    global.Delete_Client(int.Parse(dgv_client.Rows[dgv_client.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                    RemplissageGrid(true);
                    MessageBox.Show("Suppression Client Effectuer");
                }
                else
                {
                    MessageBox.Show("Veuillez selectionner pour supprimer");
                }
            }
        }

        private void Supprimer_Fourniss(object sender, EventArgs e)
        {
          DialogResult result=  MessageBox.Show("La suppression de ce client mener à supprimer tous les Commandes de cette Fournisseur ! ", "Important !", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dgv_client.Rows[dgv_client.CurrentCell.RowIndex].Cells[0].Value.ToString() != null)
                {
                    fournisseur.Delete_Fournisseur(int.Parse(dgv_client.Rows[dgv_client.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                    RemplissageGrid(false);
                    MessageBox.Show("Suppression du Fournisseur Effectuer");
                }
                else
                {
                    MessageBox.Show("Veuillez selectionner pour supprimer");
                }
            }
        }

        private void btn_modif_fournisseur_Click(object sender, EventArgs e)
        {
            if (Tester_Tous_Champs())
            {
                Update_Fournisseur();
                RemplissageGrid(false);
            }
            else
            {
                MessageBox.Show("Champs invalid !");
            }
        }

        private void tb_nom_complet_TextChanged(object sender, EventArgs e)
        {
            Regex regex_nom_compler = new Regex(@"^[A-Z]{1}[A-Z-a-z]{1,10}\s[A-Z-a-z]{1}[a-z]{1,10}$");
           if(regex_nom_compler.IsMatch(tb_nom_complet.Text))
            {
                pic_nom_complet.Visible = true;
            }
            else
            {
                pic_nom_complet.Visible = false ;
            }
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            Regex regex_email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex_email.IsMatch(tb_email.Text))
            {
                pic_email.Visible = true;
            }
            else
            {
                pic_email.Visible = false;
            }
        }

        private void tb_cin_client_TextChanged(object sender, EventArgs e)
        {
            Regex regex_cin = new Regex(@"^[A-Z]{1}[0-9]{3,10}$");
            if (regex_cin.IsMatch(tb_cin_client.Text))
            {
                pic_cin_client.Visible = true;
            }
            else
            {
                pic_cin_client.Visible = false;
            }
        }

        private void tb_adresse_TextChanged(object sender, EventArgs e)
        {
            Regex Adresse = new Regex(@"^[A-Za-z0-9]+(?:\s[A-Za-z0-9'_-]+)+$");
            if (Adresse.IsMatch(tb_adresse.Text))
            {
                pic_adress.Visible = true;
            }
            else
            {
                pic_adress.Visible = false;
            }
        }

        private void tb_telephone_TextChanged(object sender, EventArgs e)
        {
            Regex regex_tele = new Regex(@"^[0-9]{10}$");
            if (regex_tele.IsMatch(tb_telephone.Text))
            {
                pic_tele.Visible = true;
            }
            else
            {
                pic_tele.Visible = false;
            }
        }

        private void tb_ville_pays_TextChanged(object sender, EventArgs e)
        {
            Regex regex_pays = new Regex(@"^[A-Z-a-z]{3,10}$");
            if (regex_pays.IsMatch(tb_ville_pays.Text))
            {
                pic_ville.Visible = true;
            }
            else
            {
                pic_ville.Visible = false;
            }
        }

        private void dgv_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgv_client.Rows[e.RowIndex];
                tb_nom_complet.Text = row.Cells[1].Value.ToString();
                tb_email.Text = row.Cells[2].Value.ToString();
                tb_telephone.Text = row.Cells[3].Value.ToString();
                tb_cin_client.Text = row.Cells[4].Value.ToString();
                tb_adresse.Text = row.Cells[5].Value.ToString();
                tb_ville_pays.Text = row.Cells[6].Value.ToString();
                int id = int.Parse(row.Cells[0].Value.ToString());
                var Select_image = gest.Clients.Where(x => x.id_client == id).Single();
                //byte[] img = (byte[])row.Cells[7].Value;
                byte[] img = (byte[])Select_image.image_client;
                if (img == null) { client_photo.Image = null; }
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    client_photo.Image = Image.FromStream(ms);
                }


            }
        }
    }
}
