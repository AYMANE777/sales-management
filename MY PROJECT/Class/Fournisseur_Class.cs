using MY_PROJECT.Entity_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_PROJECT.Class
{
    class Fournisseur_Class
    {
        GEST_VENTE_Entities gest = new GEST_VENTE_Entities();

        public void Ajouter_Fournisseur(string nom_complet, string email, string telephone, string cin, string adresse, string ville, byte[] image)
        {
            try
            {

                Fournisseur fournisseur = new Fournisseur();

                fournisseur.Nom_Fourniss = nom_complet;
                fournisseur.adresse_fournisseur = adresse;
                fournisseur.email_Fournisseur = email;
                fournisseur.pays = ville;
                fournisseur.telephone_Fournisseur = telephone;
                fournisseur.CIN_Fournisseur = cin;
                fournisseur.image_Fournisseur = image;
                gest.Fournisseurs.Add(fournisseur);
                gest.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Delete_Fournisseur(int id)
        {
            try
            {
                var cmd_frns = gest.Commande_FOURNISSEUR.Where(x => x.ID_FOURNISS == id).Select(y => y.ID_CMD_FRNS).ToList();
                if (cmd_frns != null)
                {
                    for (int i = 0; i < cmd_frns.Count ; i++)
                    {
                        int select_id_frnss = cmd_frns[i];
                        var detail = gest.DETAIL_CMD_FOURNISS.Where(x => x.ID_CMD_FRNS == select_id_frnss).FirstOrDefault();
                        if (detail != null)
                        {
                            gest.DETAIL_CMD_FOURNISS.Remove(detail);
                            gest.SaveChanges();
                        }
                        else { break; }
                    }
                    //Delete from other table and last step in table Commande_FOURNISSEUR
                    List<Commande_FOURNISSEUR> commande = gest.Commande_FOURNISSEUR.Where(x => x.ID_FOURNISS == id).ToList();

                    foreach (Commande_FOURNISSEUR cmd_frnss in commande)
                    {
                        gest.Commande_FOURNISSEUR.Remove(cmd_frnss);
                        gest.SaveChanges();
                    }

                    Fournisseur delete = gest.Fournisseurs.FirstOrDefault(x => x.id_Fournisseur == id);
                    gest.Fournisseurs.Remove(delete);
                    gest.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void update_Fournisseur(int id, string nom_complet, string email, string telephone, string cin, string adresse, string ville, byte[] image)
        {
            try
            {
                Fournisseur update = gest.Fournisseurs.Where(x => x.id_Fournisseur == id).Single();

                update.Nom_Fourniss = nom_complet;
                update.email_Fournisseur = email;
                update.telephone_Fournisseur = telephone;
                update.CIN_Fournisseur = cin;
                update.adresse_fournisseur = adresse;
                update.pays = ville;
                update.image_Fournisseur = image;
                gest.SaveChanges();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
