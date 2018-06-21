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
    public partial class frmListeAdherents : Form
    {
        private MPersonnes unAdherent;
        String leCode, leTitre;
        int idLivre;

        public frmListeAdherents()
        {
            InitializeComponent();
            // affiche la liste des adhérents de la section
            this.afficheAdherents();
        }

        public void afficheAdherents()
        {
            // déterminer l'origine des données à afficher : appel de la méthode de la classe MAdherents qui alimente
            // et retourne une copie de sa collection des adherents sous forme de datatable
            this.grdAdherents.DataSource = MPersonnes.ListerPersonnes(txtbRecherche.Text);
            // rafraîchit l'affichage
            this.grdAdherents.Refresh();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNouvelAdherent nouvelAdherent = new frmNouvelAdherent();

            // si on sort de la saisie par le bouton OK, régénère l'affichage de la datagridview
            if (nouvelAdherent.ShowDialog() == DialogResult.OK)
            {
                this.afficheAdherents();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // si un adhérent est pointé dans la datagridview
            if (this.grdAdherents.CurrentRow != null)
            {
                // récupère la clé de l'adhérent pointé
                Int32 cleAdherent;
                cleAdherent = (Int32)this.grdAdherents.CurrentRow.Cells[0].Value;
                // demande confirmation de la suppression
                if (MessageBox.Show("Voulez-vous supprimer l'adhérent numéro :" + cleAdherent.ToString(), "Suppression", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MPersonnes.DeletePersonne(cleAdherent);
                    // réaffiche la datagridview
                    afficheAdherents();
                }
            }
        }

        private void txtbRecherche_TextChanged(object sender, EventArgs e)
        {
            MPersonnes.ListerPersonnes(txtbRecherche.Text);
            afficheAdherents();
        }

        /// <summary>
        /// ouvre la feuille détail en y affichant l'adhérent correspondant à la ligne double-cliquée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdAdherents_DoubleClick(object sender, EventArgs e)
        {
            Int32 iAdherent;
            iAdherent = this.grdAdherents.CurrentRow.Index;

            MPersonnes adherent = Donnees.getLivreById(iAdherent) as MPersonnes;
            // Instancie form consultation recette

            frmConsultationAdherent frmConsulter = new frmConsultationAdherent(unAdherent);
            // affiche le form de consultation d'une recette
            frmConsulter.ShowDialog();
            // rafaichit la datagriedview quand le form est fermée
            this.afficheAdherents();
        }
    }
}
