using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    public partial class frmConsultationScolaire : projetBibliothequeCertif.frmScolaires
    {
        private MLivres unLivre;
        private MScolaires leScolaire;

        public frmConsultationScolaire(MScolaires scolaire)
        {
            InitializeComponent();
            this.leScolaire = scolaire;
        }

        private void frmConsultationScolaire_Load(object sender, EventArgs e)
        {
            this.afficheScolaires(this.leScolaire);
        }

        private void afficheScolaires(MScolaires leScolaire)
        {
            txtbCodeSco.Text = leScolaire.Code.ToString();
            txtbVilleEcole.Text = leScolaire.Ville;
            txtbCP.Text = leScolaire.CodePostal;
            txtbEcole.Text = leScolaire.Etablissement;
            cbbClasse.Text = leScolaire.Classe;
            txtbNomProf.Text = leScolaire.Nom;
            txtbPrenomProf.Text = leScolaire.Prenom;
            dateTimeInscSco.Text = leScolaire.Inscription.ToString();
        }

        private void afficheLivres()
        {
           // MLivres.ListerLivres();

            // déterminer l'origine des données à afficher : 
            // appel de la méthode de la classe MLivres qui alimente et retourne copie de sa 
            // collection de livres sous forme de datatable
           // this.grdLivresEmpruntes.DataSource = unLivre.ListerLivres();
            // refraîchir l'affichage
            this.grdLivresEmpruntes.Refresh();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifierScolaire_Click(object sender, EventArgs e)
        {
            if(txtbCodeSco.Enabled == false && txtbVilleEcole.Enabled == false && txtbEcole.Enabled == false && cbbClasse.Enabled == false
                && txtbNomProf.Enabled == false && txtbPrenomProf.Enabled == false)
            {
                txtbCodeSco.Enabled = true;
                txtbVilleEcole.Enabled = true;
                txtbEcole.Enabled = true;
                cbbClasse.Enabled = true;
                txtbNomProf.Enabled = true;
                txtbPrenomProf.Enabled = true;
            }
            else
            {
                txtbCodeSco.Enabled = false;
                txtbVilleEcole.Enabled = false;
                txtbEcole.Enabled = false;
                cbbClasse.Enabled = false;
                txtbNomProf.Enabled = false;
                txtbPrenomProf.Enabled = false;
            }
        }

        private void btnSupprimerLivre_Click(object sender, EventArgs e)
        {
            grdLivresEmpruntes.Rows.Remove(grdLivresEmpruntes.CurrentRow);
        }

        private void btnAjouterLivre_Click(object sender, EventArgs e)
        {
           /* frmNouveauLivre nouveauLivre = new frmNouveauLivre(unLivre);

            // Si on sort de la saisie par OK, régénère l'affichage du datagrid
            if (nouveauLivre.ShowDialog() == DialogResult.OK)
            {
                this.afficheLivres();
            }
            this.Close();*/
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
