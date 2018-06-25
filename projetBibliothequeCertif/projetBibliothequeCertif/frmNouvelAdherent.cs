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
        Int32 leNumero, leCode;
        String leNom, lePrenom, leCodePostal, laVille, uneAdresse1, leTelephone, unEmail, uneVille, uneEcole, uneClasse, unNom, unPrenom, unCP;
        DateTime uneDate;

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
                lblNumPersonne.Visible = true;
                txtbNumPersonne.Visible = true;
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
                lblNumPersonne.Visible = false;
                txtbNumPersonne.Visible = false;
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
           if (chkParticuliers.Checked == false && chkScolaires.Checked == false)
            {
                grpScolarite.Visible = false;
            }
           else
            {
                chkScolaires.Checked = true;
                grpScolarite.Visible = true;
            }
            
            
            
            /* DateTime myDateTime = DateTime.Parse(mtxtbCotisation.ToString());
            int totalDays = Convert.ToInt32((DateTime.UtcNow.Date - myDateTime.Date).TotalDays);
            MessageBox.Show("Vous avez cotisé il y a " + " jours");*/
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
            if (chkParticuliers.Checked == true)
            {
                MAdherents nouvelAdherent = new MAdherents();
                nouvelAdherent.dateInscription = DateTime.Parse(base.dateTimeInscription.Text);
                nouvelAdherent.dateCotisation = DateTime.Parse(base.dateTimeCotisation.Text);
                MAdherents.InsertAdherent(nouvelAdherent);

                // crée une référence d'objets MAdherents
                MPersonnes nouvellePersonne = new MPersonnes(leNumero, leNom, lePrenom, uneAdresse1, leTelephone, unEmail, uneDate, leCodePostal, laVille);

                // affecte des variables/propriétés
                nouvellePersonne.NumPersonne = Int32.Parse(base.txtbNumPersonne.Text);
                nouvellePersonne.NumAdherent = (Int32)(MAdherents.LastInsertId());
                nouvellePersonne.Nom = base.txtbNom.Text.ToUpper();
                nouvellePersonne.Prenom = base.txtbPrenom.Text.ToLower();
                nouvellePersonne.CodePostal = base.txtbCodePostal.Text;
                nouvellePersonne.Ville = base.txtbVille.Text.ToUpper();
                nouvellePersonne.Adresse1 = base.txtbAdresse.Text;
                nouvellePersonne.Telephone = base.txtbTelephone.Text;
                nouvellePersonne.Email = base.txtbEmail.Text;
                nouvellePersonne.Naissance = DateTime.Parse(base.dateTimeNaissance.Text);

                // enregistrement de la nouvelle personne dans la BDD
                MPersonnes.InsertPersonne(nouvellePersonne);

                // ajoute la référence d'objet MPersonnes dans la collection
                Donnees.tablePersonnes = MPersonnes.ListerPersonnes("");
                // incrémentation du compteur de personnes
                MPersonnes.NPersonnes += 1;
            }
            else
            {
                chkScolaires.Checked = true;
                MAdherents nouvelAdherent = new MAdherents();
                nouvelAdherent.dateInscription = DateTime.Parse(base.dateTimeInscription.Text);
                MAdherents.InsertAdherent(nouvelAdherent);

                MScolaires nouveauScolaire = new MScolaires(leCode, uneVille, uneEcole, uneClasse, unNom, unPrenom, unCP);

                nouveauScolaire.Code = Int32.Parse(base.txtbCodeSco.Text);
                nouveauScolaire.Ville = base.txtbVilleEcole.Text;
                nouveauScolaire.Etablissement = base.txtbEcole.Text;
                nouveauScolaire.Classe = base.cbbClasse.Text;
                nouveauScolaire.Nom = base.txtbNomProf.Text;
                nouveauScolaire.Prenom = base.txtbPrenomProf.Text;

                MScolaires.InsertScolaire(nouveauScolaire);

                Donnees.tableScolaires = MScolaires.ListerScolaires("");
                MScolaires.NScolaires += 1;
            }
            this.Close();

            // fermeture de la boite de dialogue par validation
            this.DialogResult = DialogResult.OK;
        }
    }
}
