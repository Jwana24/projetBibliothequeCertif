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
        private MAdherents unAdherent;
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
            this.grdAdherents.DataSource = MAdherents.ListerAdherents();
            // rafraîchit l'affichage
            this.grdAdherents.Refresh();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (this.txtbRecherche != null)
            {
                ((DataView)(this.grdAdherents.DataSource)).RowFilter = "Nom, Titre like '%" + this.txtbRecherche.Text + "%'";
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
            // à partir du moment où il n'y a pas de recherche, tous les adherents sont affichés
            this.txtbRecherche.Text = null;
            ((DataView)(this.grdAdherents.DataSource)).RowFilter = null;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNouvelAdherent nouvelAdherent = new frmNouvelAdherent();

            // si on sort de la saisie par le bouton OK, régénère l'affichage de la datagridview
            if (nouvelAdherent.ShowDialog() == DialogResult.OK)
            {
                this.afficheAdherents();
            }
            //this.Close();
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
                    MAdherents.DeleteAdherent(cleAdherent);
                    // réaffiche la datagridview
                    afficheAdherents();
                }
            }
        }

        private void grdAdherents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// ouvre la feuille détail en y affichant l'adhérent correspondant à la ligne double-cliquée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdAdherents_DoubleClick(object sender, EventArgs e)
        {
            MAdherents adherent;
            // clé primaire (numAdherent) de l'adhérent dans la collection
            Int32 clePrimaire;

            // récupère la clé de l'adhérent cliqué en DataGridView
            clePrimaire = (Int32)this.grdAdherents.CurrentRow.Cells[0].Value;
            // instancie un objet adherant pointant vers l'adhérent d'origine dans la collection
            adherent = this.unAdherent.RestituerAdherent(clePrimaire);
            // instancie un form détail pour cet adhérent
            frmConsultationAdherent consultationAdherent = new frmConsultationAdherent(adherent);
            // personnalise le titre du form
            consultationAdherent.Text = unAdherent.ToString();
            // affiche le form détail en modal
            consultationAdherent.ShowDialog();

            // en sortie du form détail, rafraîchit la datagridview
            this.afficheAdherents();
        }
    }
}
