using MaterialSkin;
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
    public partial class form_cat : Form
    {
        public form_cat()
        {
            InitializeComponent();
        }
        Global global = new Global();
        GEST_VENTE_Entities gest = new GEST_VENTE_Entities();
        Categorieees categories = new Categorieees();

        public void Remplissage_Grid()
        {
            grid_categorie.DataSource = gest.Categories.Select(x => new { Categorie = x.id_catégorie, NOM = x.nom_catégorie, Description = x.Description }).ToList();
        }
        private void CATEGORIES_Load(object sender, EventArgs e)
        {

            Remplissage_Grid();
           
        }

        private void Nouveau_categorie(object sender, EventArgs e)
        {
            try
            {
                if (tb_description_categorie.Text != string.Empty && tb_nom_categorie.Text != string.Empty)
                {
                    categories.Ajouter_Categorie(tb_nom_categorie.Text, tb_description_categorie.Text);
                    MessageBox.Show("Success");
                    Remplissage_Grid();
                }
                else
                {
                    MessageBox.Show("veuillez remplir tous les champs !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Supprimer_Categorie(object sender, EventArgs e)
        {
            if (grid_categorie.Rows.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Alert !", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    string select = grid_categorie.Rows[grid_categorie.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    if (select != null)
                    {
                        int id = int.Parse(select);
                        categories.Delete_Categorie(id);
                        tb_description_categorie.Text = string.Empty; tb_nom_categorie.Text = string.Empty;
                        Remplissage_Grid();
                    }
                    else
                    {
                        MessageBox.Show("Veuillez selectionner le produit ");
                        return;
                    }
                   
                }
            }
        }

        private void Update_Categorie(object sender, EventArgs e)
        {
            try
            {
                if (grid_categorie.Rows.Count > 0)
                    if (MessageBox.Show("Voulez-vous vraiment Modifier ?", "Alert !", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        categories.update_Categorie(int.Parse(grid_categorie.Rows[grid_categorie.CurrentCell.RowIndex].Cells[0].Value.ToString()), tb_nom_categorie.Text, tb_description_categorie.Text) ;
                            tb_description_categorie.Text = string.Empty;tb_nom_categorie.Text = string.Empty;
                                 Remplissage_Grid();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

   
        private void grid_categorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    tb_nom_categorie.Text = grid_categorie.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_description_categorie.Text = grid_categorie.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
