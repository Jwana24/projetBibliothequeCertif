using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    public partial class frmNouvelAdherent : projetBibliothequeCertif.frmAdherents
    {
        Int32 leNumero;
        String leNom, lePrenom, leCodePostal, laVille, uneAdresse1, uneAdresse2, leTelephone;

        private void chkScolaires_CheckedChanged(object sender, EventArgs e)
        {
            if(chkScolaires.Checked == true)
            {
                grpScolarite.Visible = true;
                chkAdultes.Visible = false;
            }
            else
            {
                grpScolarite.Visible = false;
                chkAdultes.Visible = true;
            }
        }

        private void chkAdultes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdultes.Checked == true)
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
            MAdherents nouvelAdherent = new MAdherents(leNumero, leNom, lePrenom, leCodePostal, laVille, uneAdresse1, uneAdresse2, leTelephone);

            // affecter des variables/propriétés
            nouvelAdherent.NumAdherent = Int32.Parse(base.txtbNumAdherent.Text);
            nouvelAdherent.Nom = base.txtbNom.Text.ToUpper();
            nouvelAdherent.Prenom = base.txtbPrenom.Text.ToLower();
            nouvelAdherent.CodePostal = base.txtbCodePostal.Text;
            nouvelAdherent.Ville = base.txtbVille.Text.ToUpper();
            nouvelAdherent.Adresse1 = base.txtbAdresse.Text;
            nouvelAdherent.Adresse2 = base.txtbComplAdresse.Text;
            nouvelAdherent.Inscription = DateTime.Parse(base.dateTimeInscription.Text);
            nouvelAdherent.Email = base.txtbEmail.Text;
            nouvelAdherent.Telephone = base.txtbTelephone.Text;
            nouvelAdherent.Naissance = DateTime.Parse(base.dateTimeNaissance.Text);

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
