using MY_PROJECT.Entity_Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_PROJECT.Class
{
    class Global
    {
        public Global() { }
        GEST_VENTE_Entities gest = new GEST_VENTE_Entities();

        public bool Connection(string user,string password)
        {
            var access = gest.Loginns.SingleOrDefault(x => x.username==user && x.passwoord==password);
            if(access != null)
            {

                Form1 acceuil = new Form1();
                acceuil.Show();


                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkSecure(string modifier,string username,string password)
        {
            
            var search = gest.Loginns.SingleOrDefault(x => x.NAME_SECURE == modifier);
            if(search != null)
            {
                search.username = username;
                search.passwoord = password;
                gest.Loginns.Remove(search);
                gest.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        } 
        public void update(string user,string pass,string verification)
        {
           
            Loginn add = new Loginn();
            add.username=user;
            add.passwoord = pass;
            add.NAME_SECURE = verification;
            gest.Loginns.Add(add);
            gest.SaveChanges();


        }
       
        public void ajouterClient(string nom_complet,string email,string telephone,string cin,string adresse,string ville,byte[] image )
        {
            //var count = gest.Clients.Select(x => x.id_client).Max();
            //count = count + 1;
            Client client = new Client();
             
           
           
            //client.id_client = count;
            client.Nom_client = nom_complet;
            client.email = email;
            client.telephone = telephone;
            client.CIN = cin;
            client.Adresse = adresse;
            client.ville = ville;
            client.image_client = image;
            gest.Clients.Add(client);
            gest.SaveChanges();
        }
        public void updateClient(int id,string nom_complet, string email, string telephone, string cin, string adresse, string ville, byte[] image)
        {
            Client update = gest.Clients.Where(x => x.id_client == id).Single();
    
            update.Nom_client = nom_complet;
            update.email = email;
            update.telephone = telephone;
            update.CIN = cin;
            update.Adresse = adresse;
            update.ville = ville;
            update.image_client = image;
            gest.SaveChanges();
        }

        //function pour affecter dans dgv dans les champs apres click
        public void Delete_Client(int id)
         {
            try
            {
                var get_id_cmd = gest.Commande_Client.Where(x => x.ID_CLIENT == id).Select(y => y.ID_CMD).ToList() ;
                for(int i = 0; i < get_id_cmd.Count; i++)
                {
                    int getting = get_id_cmd[i];
                    DETAIL_CMD_CLIENT detail_cmd_client = gest.DETAIL_CMD_CLIENT.Where(x => x.ID_CMD == getting).FirstOrDefault();
                    gest.DETAIL_CMD_CLIENT.Remove(detail_cmd_client);
                    gest.SaveChanges();
                }
                List<Commande_Client> cmd_client = gest.Commande_Client.Where(x => x.ID_CLIENT == id).ToList();

                foreach(Commande_Client c in cmd_client)
                {
                    gest.Commande_Client.Remove(c);
                    gest.SaveChanges();
                }



                Client delete = gest.Clients.FirstOrDefault(x => x.id_client == id);
                gest.Clients.Remove(delete);
                gest.SaveChanges();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }


      

        
    }
    
}
