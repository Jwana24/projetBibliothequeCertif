using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace projetBibliothequeCertif
{
    public partial class frmConsultationPersonne : projetBibliothequeCertif.frmAdherents
    {
        private MPersonnes laPersonne;
        private MLivres unLivre;

        public frmConsultationPersonne(MPersonnes personne)
        {
            this.laPersonne = personne;
            InitializeComponent();
        }

        private void frmConsultationPersonne_Load(object sender, EventArgs e)
        {
            this.affichePersonnes(this.laPersonne);
        }

        private void affichePersonnes(MPersonnes laPersonne)
        {
           
            
            
            /* txtbNumPersonne.Text = laPersonne.NumPersonne.ToString();
            txtbNom.Text = laPersonne.Nom;
            txtbPrenom.Text = laPersonne.Prenom;
            txtbCodePostal.Text = laPersonne.CodePostal;
            txtbVille.Text = laPersonne.Ville;
            txtbAdresse.Text = laPersonne.Adresse1;
            dateTimeInscription.Text = laPersonne.Inscription.ToString();
            txtbEmail.Text = laPersonne.Email;
            txtbTelephone.Text = laPersonne.Telephone;
            dateTimeNaissance.Text = laPersonne.Naissance.ToString();*/
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            frmModifierPersonne modifierPersonne = new frmModifierPersonne();
            modifierPersonne.Show();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimerLivre_Click(object sender, EventArgs e)
        {
            grdLivresEmpruntes.Rows.Remove(grdLivresEmpruntes.CurrentRow);
        }

        private void afficheLivres()
        {
           // this.grdLivresEmpruntes.DataSource() = MLivres.ListerLivres("");
        }

        private void btnAjouterLivre_Click(object sender, EventArgs e)
        {
           /* frmNouveauLivre nouveauLivre = new frmNouveauLivre(laPersonne);

            // Si on sort de la saisie par OK, régénère l'affichage du datagrid
            if (nouveauLivre.ShowDialog() == DialogResult.OK)
            {
                this.iLivre = MLivres.NLivres - 1;
            }
            this.Close();*/
        }
    }
}
