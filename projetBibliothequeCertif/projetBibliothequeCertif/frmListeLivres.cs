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
        /// <summary>
        /// la section du livre gérée par ce form
        /// </summary>
        private MLivres leLivre;

        public frmListeLivres()
        {
            InitializeComponent();
            this.afficheLivres();
        }

        public void afficheLivres()
        {
            // déterminer l'origine des données à afficher : appel de la méthode de la classe MLivres
            // qui alimente et retourne copie de sa collection de livres sous forme de datatable
            this.grdLivres.DataSource = MLivres.ListerLivres();
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
            frmNouveauLivre nouveauLivre = new frmNouveauLivre(this.leLivre);
            if (nouveauLivre.ShowDialog() == DialogResult.OK)
            {
                afficheLivres();
            }

            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // si un livre est pointé dans la datagridview
            if (this.grdLivres.CurrentRow != null)
            {
                // récupère la clé du livre pointé
                Int32 cleLivre;
                cleLivre = (Int32)this.grdLivres.CurrentRow.Cells[0].Value;
                // demande confirmation de la suppression
                if (MessageBox.Show("Voulez-vous supprimer le livre numéro :" + cleLivre.ToString(), "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    MLivres.DeleteLivre(cleLivre.ToString());

                    // réaffiche la datagridview
                    afficheLivres();
                }
            }
        }

        /// <summary>
        /// ouvre la feuille détail en y affichant le livre correspondant à la ligne double-cliquée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdLivres_DoubleClick(object sender, EventArgs e)
        {
            MLivres livre;
            // clé primaire (codeLivre) du livre dans la collection
            Int32 clePrimaire;

            // récupère la clé du livre cliqué en DataGridView
            clePrimaire = (Int32)this.grdLivres.CurrentRow.Cells[0].Value;
            // instancie un objet livre pointant vers le livre d'origine dans la collection
            livre = this.leLivre.RestituerLivre(clePrimaire.ToString());
            // instancie un form détail pour ce livre
            frmConsultationLivre consultationLivre = new frmConsultationLivre(livre);
            // personnalise le titre du form
            consultationLivre.Text = leLivre.ToString();
            // affiche le form détail en modal
            consultationLivre.ShowDialog();

            // en sortie du form détail, rafraîchit la datagridview
            this.afficheLivres();
        }
    }
}
