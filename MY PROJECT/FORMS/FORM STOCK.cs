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
    public partial class generer_facture : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);

        GEST_VENTE_Entities gest = new GEST_VENTE_Entities();
        public generer_facture()
        {
            InitializeComponent();
        }

        private void generer_facture_Load(object sender, EventArgs e)
        {
           
        }

        private void generer_facture_MouseDown(object sender, MouseEventArgs e)
        {

            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void generer_facture_MouseMove(object sender, MouseEventArgs e)
        {

            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void generer_facture_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
