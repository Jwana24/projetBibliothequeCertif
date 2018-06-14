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
        private MLivres unAdherent;

        public frmListeAdherents()
        {
            InitializeComponent();
        }

        private SortedDictionary<Int32, MAdherents> lesAdherents;

        public void afficheAdherents()
        {
            MLivres.SelectAdherents(unAdherent);

            // déterminer l'origine des données à afficher : 
            // appel de la méthode de la classe MAdherents
            // qui alimente et retourne copie de sa 
            // collection des adherents sous forme de datatable
            this.grdAdherents.DataSource = unAdherent.ListerAdherents();
            // refraîchir l'affichage
            this.grdAdherents.Refresh();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Ajouter(MAdherents unAdherent)
        {
            this.lesAdherents.Add(unAdherent.NumAdherent, unAdherent);
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

            // Si on sort de la saisie par OK, regenere l'affichage du datagrid
            if (nouvelAdherent.ShowDialog() == DialogResult.OK)
            {
                this.afficheAdherents();
            }
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            grdAdherents.Rows.Remove(grdAdherents.CurrentRow);
        }

        private void grdAdherents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdAdherents_DoubleClick(object sender, EventArgs e)
        {
            Int32 iAdherent;
            iAdherent = this.grdAdherents.CurrentRow.Index;

            // instancie un objet livre vers le form de consultation livre d'origine dans la collection
            MAdherents unAdherent = Donnees.getAdherentById(iAdherent) as MAdherents;
            // instancie le form "Nouveau Livre" qui correspond à la création du livre
            frmConsultationAdherent consultationAdherent = new frmConsultationAdherent(unAdherent);
            // affiche le form de la création de contact en modal
            consultationAdherent.ShowDialog();

            // rafaichit la datagriedview quand le form est fermé
            this.afficheAdherents();
        }
    }
}
