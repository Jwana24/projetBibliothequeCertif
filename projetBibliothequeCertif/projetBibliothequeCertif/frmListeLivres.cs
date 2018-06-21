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
            this.grdLivres.DataSource = MLivres.ListerLivres(txtbRecherche.Text);
            // refraîchir l'affichage
            this.grdLivres.Refresh();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNouveauLivre nouveauLivre = new frmNouveauLivre(this.leLivre);
            if (nouveauLivre.ShowDialog() == DialogResult.OK)
            {
                afficheLivres();
            }
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
            Int32 iLivre;
            iLivre = this.grdLivres.CurrentRow.Index;

            MLivres livre = Donnees.getLivreById(iLivre) as MLivres;
            // Instancie form consultation recette

            frmConsultationLivre frmConsulter = new frmConsultationLivre(leLivre);
            // affiche le form de consultation d'une recette
            frmConsulter.ShowDialog();
            // rafaichit la datagriedview quand le form est fermée
            this.afficheLivres();
        }

        private void txtbRecherche_TextChanged(object sender, EventArgs e)
        {
            MLivres.ListerLivres(txtbRecherche.Text);
            afficheLivres();
        }
    }
}
