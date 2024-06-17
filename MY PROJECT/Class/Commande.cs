using MY_PROJECT.Entity_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_PROJECT.Class
{
    class Commande
    {
        GEST_VENTE_Entities gest = new GEST_VENTE_Entities();
        public Commande()
        {

        }
        public void Ajouter_Commande_Client(DateTime date,int id_client)
        {
            try
            {
                var Count = gest.Commande_Client.Select(x => x.ID_CMD).DefaultIfEmpty(0).Max();
                int a = Count + 1;
                Commande_Client commande_Client = new Commande_Client();
                commande_Client.ID_CMD = a;
                commande_Client.ID_CLIENT =id_client;
                commande_Client.DATE_CMD = date;
               
                gest.Commande_Client.Add(commande_Client);
                gest.SaveChanges();


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Ajouter_Detail_Commande_Client(int id_Produit, int id_commande, int quantité, float prix)
        {
            try
            {
                
                DETAIL_CMD_CLIENT dETAIL_CMD_CLIENT = new DETAIL_CMD_CLIENT();
           
                dETAIL_CMD_CLIENT.ID_PRODUIT = id_Produit;
                dETAIL_CMD_CLIENT.ID_CMD = id_commande;
                dETAIL_CMD_CLIENT.QUANTITE = quantité;
                dETAIL_CMD_CLIENT.PRICE = (decimal?)prix;

                gest.DETAIL_CMD_CLIENT.Add(dETAIL_CMD_CLIENT);
                gest.SaveChanges();
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        public void Ajouter_Commande_Fournisseur(DateTime date, int id_fourniss)
        {
            try
            {

                
                var Count = gest.Commande_FOURNISSEUR.Select(x => x.ID_CMD_FRNS).DefaultIfEmpty(0).Max();
                int a = Count + 1;
                Commande_FOURNISSEUR commande_Fourniss = new Commande_FOURNISSEUR();
                commande_Fourniss.ID_CMD_FRNS = a;
                commande_Fourniss.ID_FOURNISS = id_fourniss;
                commande_Fourniss.DATE_CMD = date;
                

                gest.Commande_FOURNISSEUR.Add(commande_Fourniss);
                gest.SaveChanges();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Ajouter_Detail_Commande_FOURNISSEUR(int id_Produit, int id_commande_frns, int quantité, float prix)
        {
            try
            {
                DETAIL_CMD_FOURNISS dETAIL_CMD_FOURNISS = new DETAIL_CMD_FOURNISS();

                dETAIL_CMD_FOURNISS.ID_PRODUIT = id_Produit;
                dETAIL_CMD_FOURNISS.ID_CMD_FRNS = id_commande_frns;
                dETAIL_CMD_FOURNISS.QUANTITE = quantité;
                dETAIL_CMD_FOURNISS.PRICE = (decimal?)prix;

                gest.DETAIL_CMD_FOURNISS.Add(dETAIL_CMD_FOURNISS);
                gest.SaveChanges();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Produit GetProduit(int id)
        {
            Produit produit = gest.Produits.Where(x => x.id_Produit == id).Single();

            return produit;
        }
    }
}
