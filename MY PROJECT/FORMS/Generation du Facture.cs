using MY_PROJECT.Crystal_Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_PROJECT.FORMS
{
    public partial class Generation_du_Facture : Form
    {
        public Generation_du_Facture()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        public bool Report_Client(int id ,string Date_debut,string Date_fin)
        {
           
            
                Facture facture = new Facture();

                Crystal_Report.FactureTableAdapters.Get_Report_cmd_client  report = new Crystal_Report.FactureTableAdapters.Get_Report_cmd_client();

            report.FillFactureClient(facture.DataTable1, Date_debut,Date_fin, id) ;
                if (facture.DataTable1.Rows.Count != 0)
                {

                    Repot_Etat_client generer_facture = new Repot_Etat_client();
                    generer_facture.SetDataSource(facture);
                    crystalReportViewer1.ReportSource = generer_facture;
                    crystalReportViewer1.Refresh();
                    return true;

                }
                else
                {
                    MessageBox.Show("Cette Client n'a aucune commande", "Information !");
                    return false;
                }

            
          
           
        }

        public bool Report_Client_with_date_sp(int id_client,string date)
        {


            Facture facture = new Facture();

            Crystal_Report.FactureTableAdapters.DataTable_Client_dateTableAdapter all = new Crystal_Report.FactureTableAdapters.DataTable_Client_dateTableAdapter();

            all.Fill_Client_date_sp(facture.DataTable_Client_date,date,id_client);
            if (facture.DataTable_Client_date.Rows.Count != 0)
            {

                Repot_Etat_client_Avec_date_sp generer_facture = new Repot_Etat_client_Avec_date_sp();
                generer_facture.SetDataSource(facture);
                crystalReportViewer1.ReportSource = generer_facture;
                crystalReportViewer1.Refresh();
                return true;

            }
            else
            {
                MessageBox.Show("aucune commande", "Information !");
                return false;
            }




        }
        public bool Report_Client_With_Nom(int id)
        {
            Facture facture = new Facture();
            Crystal_Report.FactureTableAdapters.DataTable_by_nom_TableAdapter all = new Crystal_Report.FactureTableAdapters.DataTable_by_nom_TableAdapter();
            all.Fill_by_nom_client(facture.DataTable_by_id_client, id);
            if (facture.DataTable_by_id_client.Count != 0)
            {
                Repot_Etat_client_par_nom report = new Repot_Etat_client_par_nom();
                report.SetDataSource(facture);
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
                return true;
            }
            else
            {
                MessageBox.Show("aucune commande", "Information !");
                return false;
            }
        }

        public bool Report_Frns_with_id(int id_client)
        {


            Facture_frns facture = new Facture_frns();

            Crystal_Report.Facture_frnsTableAdapters.DataTable1_FRNS_IDTableAdapter all = new Crystal_Report.Facture_frnsTableAdapters.DataTable1_FRNS_IDTableAdapter();

            all.Fill_with_id_frns(facture.DataTable1_FRNS_ID, id_client);
            if (facture.DataTable1_FRNS_ID.Rows.Count != 0)
            {

                Repot_Etat_FRNS_par_nom_ generer_facture = new Repot_Etat_FRNS_par_nom_();
                generer_facture.SetDataSource(facture);
                crystalReportViewer1.ReportSource = generer_facture;
                crystalReportViewer1.Refresh();
                return true;

            }
            else
            {
                MessageBox.Show("aucune commande", "Information !");
                return false;
            }




        }
        public bool Report_Frns_with_date_sp(string date)
        {


            Facture_frns facture = new Facture_frns();

            Crystal_Report.Facture_frnsTableAdapters.DataTable1TableAdapter_date_sp all = new Crystal_Report.Facture_frnsTableAdapters.DataTable1TableAdapter_date_sp();

            all.Fill(facture.Data_date_sp, date);
            if (facture.DataTable1_FRNS_ID.Rows.Count != 0)
            {

                Repot_Etat_FRNS_par_nom__Avec_dare_sp generer_facture = new Repot_Etat_FRNS_par_nom__Avec_dare_sp();
                generer_facture.SetDataSource(facture);
                crystalReportViewer1.ReportSource = generer_facture;
                crystalReportViewer1.Refresh();
                return true;

            }
            else
            {
                MessageBox.Show("aucune commande", "Information !");
                return false;
            }




        }
    }
}
