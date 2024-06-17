using MY_PROJECT.Entity_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_PROJECT.Class
{
    class Categorieees
    {
        public Categorieees() { }
        GEST_VENTE_Entities gest = new GEST_VENTE_Entities();


        public void update_Categorie(int id, string nom_complet, string description)
        {
            var update = gest.Categories.Where(x => x.id_catégorie == id).Single();
            update.nom_catégorie = nom_complet;
            update.Description = description;
            gest.SaveChanges();
        }

        public void Delete_Categorie(int id)
        {
            try
            {
                var delete = gest.Categories.SingleOrDefault(x => x.id_catégorie == id);
                gest.Categories.Remove(delete);
                gest.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Ajouter_Categorie(string nom_categorie, string description)
        {
            Categorie cat = new Categorie();
            cat.nom_catégorie = nom_categorie;
            cat.Description = description;
            gest.Categories.Add(cat);
            gest.SaveChanges();



        }
    }
}
