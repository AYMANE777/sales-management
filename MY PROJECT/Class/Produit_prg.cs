using MY_PROJECT.Entity_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_PROJECT.Class
{
    class Produit_prg
    {
        public Produit_prg() { }
        GEST_VENTE_Entities gest = new GEST_VENTE_Entities();

        public void ajouter_Produit(string nomProduit, float prix_vente,float prix_achat ,float quantite, int id_categorie, byte[] image)
        {
            try
            {
                Produit produit = new Produit();

                produit.Nom_Produit = nomProduit;
                produit.Prix_vent = (decimal)prix_vente;
                produit.Prix_achat = (decimal)prix_achat;
                produit.Quantite_Produit_stock = quantite;
                produit.id_catégorie = id_categorie;
                produit.Photo_produit = image;
                gest.Produits.Add(produit);
                gest.SaveChanges();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public void update_produit(int id, string nomProduit, float prix_ventes,float prix_achat, float quantite, int id_categorie, byte[] image)
        {
            try
            {
                var update = gest.Produits.Where(x => x.id_Produit == id).Single();

                update.Nom_Produit = nomProduit;
                update.Prix_vent = (decimal)prix_ventes;
                update.Quantite_Produit_stock = quantite;
                update.id_catégorie = id_categorie;
                update.Prix_achat = (decimal)prix_achat;

                update.Photo_produit = image;
                gest.SaveChanges();
                MessageBox.Show("Modification Success");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        public void Delete_Produit(int id)
        {
            try
            {
                var delete = gest.Produits.SingleOrDefault(x => x.id_Produit == id);
                gest.Produits.Remove(delete);
                gest.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
