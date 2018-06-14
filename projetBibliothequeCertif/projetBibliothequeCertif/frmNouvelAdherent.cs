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
    public partial class frmNouvelAdherent : projetBibliothequeCertif.frmAdherents
    {
        Int32 leNumero;
        String leNom, lePrenom, leCodePostal, laVille, uneAdresse1, uneAdresse2, leTelephone, unEmail;

        private void grpCotisations_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtbDateCotisation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chkScolaires_CheckedChanged(object sender, EventArgs e)
        {
            if(chkScolaires.Checked == true)
            {
                grpScolarite.Visible = true;
                chkParticuliers.Visible = false;
            }
            else
            {
                grpScolarite.Visible = false;
                chkParticuliers.Visible = true;
            }
        }

        private void chkParticuliers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParticuliers.Checked == true)
            {
                lblNumAdherent.Visible = true;
                txtbNumAdherent.Visible = true;
                lblNom.Visible = true;
                txtbNom.Visible = true;
                lblPrenom.Visible = true;
                txtbPrenom.Visible = true;
                lblCodePostal.Visible = true;
                txtbCodePostal.Visible = true;
                lblVille.Visible = true;
                txtbVille.Visible = true;
                lblAdresse1.Visible = true;
                txtbAdresse.Visible = true;
                lblAdresse2.Visible = true;
                txtbComplAdresse.Visible = true;
                lblDateInscription.Visible = true;
                dateTimeInscription.Visible = true;
                lblEmail.Visible = true;
                txtbEmail.Visible = true;
                lblTelephone.Visible = true;
                txtbTelephone.Visible = true;
                lblDateNaissance.Visible = true;
                dateTimeNaissance.Visible = true;
                grpCotisations.Visible = true;
                chkScolaires.Visible = false;
            }
            else
            {
                lblNumAdherent.Visible = false;
                txtbNumAdherent.Visible = false;
                lblNom.Visible = false;
                txtbNom.Visible = false;
                lblPrenom.Visible = false;
                txtbPrenom.Visible = false;
                lblCodePostal.Visible = false;
                txtbCodePostal.Visible = false;
                lblVille.Visible = false;
                txtbVille.Visible = false;
                lblAdresse1.Visible = false;
                txtbAdresse.Visible = false;
                lblAdresse2.Visible = false;
                txtbComplAdresse.Visible = false;
                lblDateInscription.Visible = false;
                dateTimeInscription.Visible = false;
                lblEmail.Visible = false;
                txtbEmail.Visible = false;
                lblTelephone.Visible = false;
                txtbTelephone.Visible = false;
                lblDateNaissance.Visible = false;
                dateTimeNaissance.Visible = false;
                grpCotisations.Visible = false;
                chkScolaires.Visible = true;
            }
        }

        private void frmNouvelAdherent_Load(object sender, EventArgs e)
        {
            DateTime myDateTime = DateTime.Parse(mtxtbCotisation.ToString());
            int totalDays = Convert.ToInt32((DateTime.UtcNow.Date - myDateTime.Date).TotalDays);
            MessageBox.Show("Vous avez cotisé il y a " + " jours");
        }

        public frmNouvelAdherent()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // créer une référence d'objets MLivres
            MAdherents nouvelAdherent = new MAdherents(leNumero, leNom, lePrenom, leCodePostal, laVille, uneAdresse1, uneAdresse2, leTelephone, unEmail);

            // affecter des variables/propriétés
            nouvelAdherent.NumAdherent = Int32.Parse(base.txtbNumAdherent.Text);
            nouvelAdherent.Nom = base.txtbNom.Text.ToUpper();
            nouvelAdherent.Prenom = base.txtbPrenom.Text.ToLower();
            nouvelAdherent.CodePostal = base.txtbCodePostal.Text;
            nouvelAdherent.Ville = base.txtbVille.Text.ToUpper();
            nouvelAdherent.Adresse1 = base.txtbAdresse.Text;
            nouvelAdherent.Adresse2 = base.txtbComplAdresse.Text;
            nouvelAdherent.Telephone = base.txtbTelephone.Text;
            nouvelAdherent.Email = base.txtbEmail.Text;

            // numéro du livre
            nouvelAdherent.IAdherent++;

            //ajouter la référence d'objet MLivres dans la collection
            Donnees.arrayAdherents.Add(nouvelAdherent);
            // incrémentation compteur de clients
            MAdherents.NAdherents++;

            frmListeAdherents listeAdherents = new frmListeAdherents();
            listeAdherents.afficheAdherents();
            listeAdherents.Show();
            this.Close();
        }
    }
}
