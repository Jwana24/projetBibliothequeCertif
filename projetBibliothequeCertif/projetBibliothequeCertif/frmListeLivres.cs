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
    public partial class frmListeLivres : Form
    {
        private MBiblio unLivre;

        public frmListeLivres()
        {
            InitializeComponent();
        }

        private SortedDictionary<Int32, MLivres> lesLivres;

        public void afficheLivres()
        {
            MBiblio.SelectLivre(unLivre);

            // déterminer l'origine des données à afficher : appel de la méthode de la classe MLivres
            // qui alimente et retourne copie de sa collection de livres sous forme de datatable
            this.grdLivres.DataSource = unLivre.ListerLivres();
            // refraîchir l'affichage
            this.grdLivres.Refresh();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (this.txtbRecherche != null)
            {
                ((DataView)(this.grdLivres.DataSource)).RowFilter = "Titre like '%" + this.txtbRecherche.Text + "%'";
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
            // à partir du moment où il n'y a pas de recherche, tous les livres sont affichés
            this.txtbRecherche.Text = null;
            ((DataView)(this.grdLivres.DataSource)).RowFilter = null;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNouveauLivre nouveauLivre = new frmNouveauLivre();
            if (nouveauLivre.ShowDialog() == DialogResult.OK)
            {
                this.afficheLivres();
            }

            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            grdLivres.Rows.Remove(grdLivres.CurrentRow);
        }

        private void grdLivres_DoubleClick(object sender, EventArgs e)
        {
            Int32 iLivre;
            iLivre = this.grdLivres.CurrentRow.Index;

            // instancie un objet livre vers le form de consultation livre d'origine dans la collection
            MLivres leLivre = Donnees.getLivreById(iLivre) as MLivres;
            // instancie le form "Nouveau Livre" qui correspond à la création du livre
            frmConsultationLivre consultationLivre = new frmConsultationLivre(leLivre);
            // affiche le form de la création de contact en modal
            consultationLivre.ShowDialog();

            // rafaichit la datagriedview quand le form est fermé
            this.afficheLivres();
        }
    }
}
