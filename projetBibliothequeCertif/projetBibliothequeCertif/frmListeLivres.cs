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
        private MLivres livre;

        public frmListeLivres()
        {
            InitializeComponent();
            this.afficheLivres();
        }

        public void afficheLivres()
        {
            // détermine l'origine des données à afficher : appel de la méthode de la classe MLivres
            // qui alimente et retourne la copie de sa collection de livres sous forme de datatable
            this.grdLivres.DataSource = MLivres.ListerLivres(txtbRecherche.Text);
            // rafraîchit l'affichage
            this.grdLivres.Refresh();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNouveauLivre nouveauLivre = new frmNouveauLivre();
            if (nouveauLivre.ShowDialog() == DialogResult.OK)
            {
                afficheLivres();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // si un livre est pointé dans la datagridview
                if (this.grdLivres.CurrentRow != null)
                {
                    // récupère la clé du livre pointé
                    String cleLivre;
                    cleLivre = (String)this.grdLivres.CurrentRow.Cells[0].Value;
                    // demande confirmation de la suppression
                    if (MessageBox.Show("Voulez-vous supprimer le livre numéro :" + cleLivre.ToString(), "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        MLivres.DeleteLivre(cleLivre.ToString());

                        // réaffiche la datagridview
                        afficheLivres();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue \n" + ex.Message);
            }
        }

        /// <summary>
        /// ouvre la feuille détail en y affichant le livre correspondant à la ligne double-cliquée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdLivres_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                String iLivre;
                iLivre = (String)this.grdLivres.CurrentRow.Cells[0].Value;

                livre = MLivres.RestituerLivre(iLivre); // as MPersonnes;
                                                        // instancie le form consultation personne
                frmConsultationLivre frmConsulter = new frmConsultationLivre(livre);
                // affiche le form de consultation d'une personne
                frmConsulter.ShowDialog();
                // rafraîchit la datagridview quand le form est fermé
                this.afficheLivres();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue \n" + ex.Message);
            }
        }

        private void txtbRecherche_TextChanged(object sender, EventArgs e)
        {
            MLivres.ListerLivres(txtbRecherche.Text);
            afficheLivres();
        }
    }
}
