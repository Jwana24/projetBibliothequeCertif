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
            this.afficheScolaires();
        }

        private void afficheScolaires()
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

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifierScolaire_Click(object sender, EventArgs e)
        {
            if(txtbCodeSco.Enabled == false && txtbVilleEcole.Enabled == false && txtbCP.Enabled == false && txtbEcole.Enabled == false &&
                cbbClasse.Enabled == false && txtbNomProf.Enabled == false && txtbPrenomProf.Enabled == false && dateTimeInscSco.Enabled == false)
            {
                txtbCodeSco.Enabled = true;
                txtbVilleEcole.Enabled = true;
                txtbCP.Enabled = true;
                txtbEcole.Enabled = true;
                cbbClasse.Enabled = true;
                txtbNomProf.Enabled = true;
                txtbPrenomProf.Enabled = true;
                dateTimeInscSco.Enabled = true;
            }
            else
            {
                txtbCodeSco.Enabled = false;
                txtbVilleEcole.Enabled = false;
                txtbCP.Enabled = false;
                txtbEcole.Enabled = false;
                cbbClasse.Enabled = false;
                txtbNomProf.Enabled = false;
                txtbPrenomProf.Enabled = false;
                dateTimeInscSco.Enabled = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
