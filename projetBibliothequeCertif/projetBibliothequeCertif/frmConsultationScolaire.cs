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
        Int32 leCode;
        String uneVille, uneEcole, uneClasse, unCP, unNom, unPrenom;
       
        private MLivres unLivre;
        private MScolaires leScolaire;

        private MAdherents adherents;

        public frmConsultationScolaire(MScolaires scolaire)
        {
            InitializeComponent();
            this.leScolaire = scolaire;
        }

        private void frmConsultationScolaire_Load(object sender, EventArgs e)
        {
            this.adherents = MAdherents.ChercherAdherent(leScolaire.NumAdherent);
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
            dateTimeInscSco.Value = leScolaire.Inscription;
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
            try
            {
                // crée une référence d'objets MScolaires
                MScolaires modifierScolaire = new MScolaires(leCode, uneVille, uneEcole, uneClasse, unCP, unNom, unPrenom);

                // affecte des variables/propriétés
                modifierScolaire.Code = Int32.Parse(base.txtbCodeSco.Text);
                modifierScolaire.Ville = base.txtbVilleEcole.Text;
                modifierScolaire.CodePostal = base.txtbCP.Text;
                modifierScolaire.Etablissement = base.txtbEcole.Text.ToUpper();
                modifierScolaire.Classe = base.cbbClasse.Text;
                modifierScolaire.Nom = base.txtbNomProf.Text.ToUpper();
                modifierScolaire.Prenom = base.txtbPrenomProf.Text.ToLower();
                modifierScolaire.Inscription = DateTime.Parse(base.dateTimeInscSco.Text);

                // enregistrement de la modification du scolaires dans la BDD
                MScolaires.UpdateScolaire(modifierScolaire);

                // ajoute la référence d'objet MScolaires dans la collection
                Donnees.tableScolaires = MScolaires.ListerScolaires("");
                // incrémentation du compteur de scolaires
                MScolaires.NScolaires = 1;

                this.Close();

                // fermeture de la boite de dialogue par validation
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue \n" + ex.Message);
            }
        }
    }
}
