using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    public partial class frmModifierAdherent : projetBibliothequeCertif.frmAdherents
    {
        private MAdherents unAdherent;

        public frmModifierAdherent()
        {
            InitializeComponent();
        }

        private void afficheAdherent()
        {
            // affecter les textbox
            this.txtbNom.Text = this.unAdherent.Nom.ToString();
            this.txtbPrenom.Text = this.unAdherent.Prenom.ToString();
            this.txtbCodePostal.Text = this.unAdherent.CodePostal.ToString();
            this.txtbVille.Text = this.unAdherent.Ville.ToString();
            this.txtbAdresse.Text = this.unAdherent.Adresse1.ToString();
            this.txtbComplAdresse.Text = this.unAdherent.Adresse2.ToString();
            this.dateTimeInscription.Text = this.unAdherent.Inscription.ToString();
            this.txtbEmail.Text = this.unAdherent.Email.ToString();
            this.txtbTelephone.Text = this.unAdherent.Telephone.ToString();
            this.dateTimeNaissance.Text = this.unAdherent.Naissance.ToString();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmModifierAdherent modifierAdherent = new frmModifierAdherent();
            this.Close();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            // réafficher l'adhérent d'origine
            this.afficheAdherent();
        }
    }
}
