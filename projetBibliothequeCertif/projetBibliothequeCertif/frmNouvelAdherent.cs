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
