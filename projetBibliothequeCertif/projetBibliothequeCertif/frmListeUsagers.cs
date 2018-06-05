using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    public partial class frmListeUsagers : Form
    {
        private MUsagers unUsager;

        public frmListeUsagers()
        {
            InitializeComponent();
        }

        private SortedDictionary<Int32, MUsagers> lesUsagers;

        private void afficheUsagers()
        {
            MUsagers.SelectUsagers(unUsager);

            // déterminer l'origine des données à afficher : 
            // appel de la méthode de la classe MUsagers 
            // qui alimente et retourne copie de sa 
            // collection de usagers sous forme de datatable
            this.grdUsagers.DataSource = unUsager.ListerUsagers();
            // refraîchir l'affichage
            this.grdUsagers.Refresh();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Ajouter(MUsagers unUsager)
        {
            this.lesUsagers.Add(unUsager.NumUsager, unUsager);
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (this.txtbRecherche != null)
            {
                ((DataView)(this.grdUsagers.DataSource)).RowFilter = "Nom like '%" + this.txtbRecherche.Text + "%'";
            }
        }

        private void btnTous_Click(object sender, EventArgs e)
        {
            // le bouton "tous" est grisé dès l'ouverture de la fenêtre
            this.btnTous.Enabled = false;
            // si l'utilisateur tape une recherche, le bouton "tous" est dégrisé
            if (this.txtbRecherche != null)
            {
                this.btnTous.Enabled = true;
            }
            // à partir du moment où il n'y a pas de recherche, tous les usagers sont affichés
            this.txtbRecherche.Text = null;
            ((DataView)(this.grdUsagers.DataSource)).RowFilter = null;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNouvelUsager nouvelUsager = new frmNouvelUsager();
            //rajouter le changement dans la dataTable

            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            grdUsagers.Rows.Remove(grdUsagers.CurrentRow);
        }
    }
}
