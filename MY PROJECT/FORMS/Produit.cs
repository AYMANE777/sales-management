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
    public partial class Produit_Form : Form
    {
        GEST_VENTE_Entities gest = new GEST_VENTE_Entities();
        Produit_prg product = new Produit_prg();
        

        public Produit_Form()
        {
            InitializeComponent();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Remplissage_Combo()
        {
            try
            {
                cb_cat.DataSource = gest.Categories.ToList();
                cb_cat.DisplayMember = "nom_catégorie";
                cb_cat.ValueMember = "id_catégorie";


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           

        }
        public void RemplissageGrid()
        {
            try
            {
                grid_produit.DataSource = (from P in gest.Produits
                                           join C in gest.Categories on P.id_catégorie equals C.id_catégorie
                                           select new
                                           {
                                               Numéro = P.id_Produit,
                                               Produit = P.Nom_Produit,
                                               ACHAT = P.Prix_achat,
                                               VENTE = P.Prix_vent,
                                               Quantité = P.Quantite_Produit_stock,
                                               CATEGORIE = C.nom_catégorie
                                           }).OrderBy(x => x.Numéro).ToList() ;
               
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
           
        }
        public bool testerChamps()
        {
            if (tb_prix_de_vente.Text != "" && tb_nom_produit.Text != "" && tb_prix_achat.Text != "" && tb_quantite_prd.Text != "" && cb_cat.Text != "")
            {
                return true;
            }
            else { return false; }
        }

        private void Produit_Load(object sender, EventArgs e)
        {
            Remplissage_Combo();
            RemplissageGrid();
        }

       
        private void Mettre_a_jour(object sender, EventArgs e)
        {
           
        }

        private void grid_produit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_ajouter_Produit(object sender, EventArgs e)
        {
            try
            {
                if (testerChamps())

                {
                    byte[] byteImage;
                    MemoryStream ms = new MemoryStream();
                    photo_produit.Image.Save(ms, photo_produit.Image.RawFormat);
                    byteImage = ms.ToArray();


                    product.ajouter_Produit(tb_nom_produit.Text, float.Parse(tb_prix_de_vente.Text), float.Parse(tb_prix_achat.Text), float.Parse(tb_quantite_prd.Text), int.Parse(cb_cat.SelectedValue.ToString()), byteImage);
                    RemplissageGrid();
                    tb_nom_produit.Clear(); tb_prix_de_vente.Clear(); tb_quantite_prd.Clear(); cb_cat.Text = ""; tb_prix_achat.Clear();
                }
                else
                {
                    MessageBox.Show("veuillez remplir tous les champs svp !!", "information !!!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Mettre_A_Jour_Produit(object sender, EventArgs e)
        {
            try
            {
                if (testerChamps())

                {
                    byte[] byteImage_ajour;
                    MemoryStream ms = new MemoryStream();
                    photo_produit.Image.Save(ms, photo_produit.Image.RawFormat);
                    byteImage_ajour = ms.ToArray();
                    int id = int.Parse(grid_produit.Rows[grid_produit.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    product.update_produit(id, tb_nom_produit.Text, float.Parse(tb_prix_de_vente.Text), float.Parse(tb_prix_achat.Text), float.Parse(tb_quantite_prd.Text), int.Parse(cb_cat.SelectedValue.ToString()), byteImage_ajour);
                    RemplissageGrid();

                    tb_nom_produit.Clear(); tb_prix_de_vente.Clear(); tb_quantite_prd.Clear(); cb_cat.Text = ""; tb_prix_achat.Clear();
                }
                else
                {
                    MessageBox.Show("veuillez remplir tous les champs svp !!", "information !!!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void tb_rechercher_produit_TextChanged_1(object sender, EventArgs e)
        {
            grid_produit.DataSource = (from P in gest.Produits
                                       join C in gest.Categories on P.id_catégorie equals C.id_catégorie where P.Nom_Produit.Contains(tb_rechercher_produit.Text)
                                       select new
                                       {
                                           Numéro = P.id_Produit,
                                           Produit = P.Nom_Produit,
                                           ACHAT = P.Prix_achat,
                                           VENTE = P.Prix_vent,
                                           Quantité=P.Quantite_Produit_stock,
                                           CATEGORIE = C.nom_catégorie
                                       }).ToList();
         
        }

        private void cb_cat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_cat.SelectedIndex != -1)
            {
                pic_categorie.Visible = true;
            }
            else { pic_categorie.Visible = false; }
        }

        private void tb_prix_de_vente_TextChanged_1(object sender, EventArgs e)
        {
            Regex regex_vente = new Regex(@"^\d+$");
            Regex regex_ventes_float = new Regex(@"[0-9]+\.?[0-9]{1,3}$");
            if (regex_vente.IsMatch(tb_prix_de_vente.Text) || regex_ventes_float.IsMatch(tb_prix_de_vente.Text))
            {
                pic_prix_ventes.Visible = true;
            }
            else
            {
                pic_prix_ventes.Visible = false;
            }
        }

        private void tb_prix_achat_TextChanged(object sender, EventArgs e)
        {
            Regex regex_prix = new Regex(@"^\d+$");
            Regex regex_achat_float = new Regex(@"[0-9]+\.?[0-9]{1,3}$");
            if (regex_prix.IsMatch(tb_prix_achat.Text) || regex_achat_float.IsMatch(tb_prix_achat.Text))
            {
                pic_prix_achat.Visible = true;
            }
            else
            {
                pic_prix_achat.Visible = false;
            }
        }

        private void supprimer_selection(object sender, EventArgs e)
        {
            try
            {
                string select = grid_produit.Rows[grid_produit.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if (select != null)
                {
                    int id = int.Parse(select);
                    product.Delete_Produit(id);
                    RemplissageGrid();
                }
                else
                {
                    MessageBox.Show("Veuillez selectionner le produit ");
                    return;
                }



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void grid_produit_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = grid_produit.Rows[e.RowIndex];
                tb_nom_produit.Text = row.Cells[1].Value.ToString();
                tb_prix_achat.Text = row.Cells[2].Value.ToString();
                tb_prix_de_vente.Text = row.Cells[3].Value.ToString();
                tb_quantite_prd.Text = row.Cells[4].Value.ToString();
                cb_cat.Text = row.Cells[5].Value.ToString();

                int id = int.Parse(row.Cells[0].Value.ToString());
                var Select_image = gest.Produits.Where(x => x.id_Produit == id).Single();
                byte[] img = (byte[])Select_image.Photo_produit;
                //byte[] img = (byte[])row.Cells[6].Value;
                if (img == null) { photo_produit.Image = null; }
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    photo_produit.Image = Image.FromStream(ms);
                }
            }
        }

        private void tb_nom_produit_TextChanged(object sender, EventArgs e)
        {
            Regex nom_Produit = new Regex("^[a-zA-Z0-9è-é]+$");
            Regex regex_produit = new Regex(@"^[A-Z-a-z]{1,10}\s[A-Z-a-z]{1,10}$");
            if (nom_Produit.IsMatch(tb_nom_produit.Text) || regex_produit.IsMatch(tb_nom_produit.Text))
            {
                pic_nom_produit.Visible = true;
            }
            else
            {
                pic_nom_produit.Visible = false;
            }
        }

        private void tb_quantite_prd_TextChanged(object sender, EventArgs e)
        {
            Regex regex_Quantiter = new Regex(@"^\d+$");
            if (regex_Quantiter.IsMatch(tb_quantite_prd.Text))
            {
                pic_quantiter_stock.Visible = true;
            }
            else
            {
                pic_quantiter_stock.Visible = false;
            }
        }

        private void btn_anuller_Click(object sender, EventArgs e)
        {
            try
            {
                tb_prix_achat.Text = string.Empty;
                tb_prix_de_vente.Text = string.Empty;
                cb_cat.SelectedIndex = -1;
                tb_nom_produit.Text = string.Empty;
                tb_quantite_prd.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void img_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images Files|*.JPG; *.PNG; *.GIF; *.BMP";
            if (op.ShowDialog() == DialogResult.OK)
            {
                photo_produit.Image = Image.FromFile(op.FileName);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
