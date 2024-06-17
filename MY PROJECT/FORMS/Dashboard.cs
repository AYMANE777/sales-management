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
    public partial class Dashboard : Form
    {
        GEST_VENTE_Entities gest = new GEST_VENTE_Entities();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gEST_VENTEDataSet.Top_Produit_Vendu' table. You can move, or remove it, as needed.
            this.top_Produit_VenduTableAdapter.Fill(this.gEST_VENTEDataSet.Top_Produit_Vendu);
            // TODO: This line of code loads data into the 'gEST_VENTE_DataSet.DETAIL_CMD_CLIENT' table. You can move, or remove it, as needed.
            chart1.DataSource = (from P in gest.Produits  select new { P.Nom_Produit, P.Quantite_Produit_stock }).Distinct().ToList();
            chart1.Series[0].XValueMember = "Nom_Produit";
            chart1.Series[0].YValueMembers = "Quantite_Produit_stock";



            lblNombreClient.Text =  gest.Clients.Select(x => x.id_client).DefaultIfEmpty(0).Count().ToString();
            lblNombreFrns.Text= gest.Fournisseurs.Select(x => x.id_Fournisseur).DefaultIfEmpty(0).Count().ToString();
            lblNumProducts.Text= gest.Produits.Select(x => x.id_Produit).DefaultIfEmpty(0).Count().ToString();
            lblNombreCmd.Text = (gest.Commande_Client.Select(x => x.ID_CMD).DefaultIfEmpty(0).Count()+ gest.Commande_FOURNISSEUR.Select(x => x.ID_CMD_FRNS).DefaultIfEmpty(0).Count()).ToString();
            //lb_commande.Text ="+ "+gest.DETAIL_CMD_FOURNISS.Select(x => x.ID_CMD_FRNS).DefaultIfEmpty(0).Count();
            var GAIN = gest.DETAIL_CMD_CLIENT.Select(x => x.PRICE).DefaultIfEmpty(0).Sum() - gest.DETAIL_CMD_FOURNISS.Select(x => x.PRICE).DefaultIfEmpty(0).Sum();

            if (GAIN > 0)
            {
                lblTotalRevenue.ForeColor = Color.Black;
                lblTotalRevenue.Text =  GAIN + "DH" ;
            }
            else
            {
                lblTotalRevenue.ForeColor = Color.Red;
                lblTotalRevenue.Text = GAIN + "DH";
            }

            dgvUnderstock.DataSource = gest.Produits.Select(x => new { ID = x.id_Produit, NOM = x.Nom_Produit, Quantité = x.Quantite_Produit_stock, PRIX = x.Prix_vent }).Where(x => x.Quantité < 50).ToList();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void lb_time_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
