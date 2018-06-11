using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    public partial class frmModifierScolaire : projetBibliothequeCertif.frmScolaires
    {
        private MScolaires unScolaire;

        public frmModifierScolaire()
        {
            InitializeComponent();
        }

        private void afficheScolaire()
        {
            // affecter les textbox
            this.txtbCodeSco.Text = this.unScolaire.Code.ToString();
            this.txtbVilleEcole.Text = this.unScolaire.Ville.ToString();
            this.txtbEcole.Text = this.unScolaire.Etablissement.ToString();
            this.cbbClasse.Text = this.unScolaire.Classe.ToString();
            this.txtbNomProf.Text = this.unScolaire.Nom.ToString();
            this.txtbPrenomProf.Text = this.unScolaire.Prenom.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmModifierScolaire modifierScolaire = new frmModifierScolaire();
            this.Close();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            // réafficher l'adhérent d'origine
            this.afficheScolaire();
        }
    }
}
