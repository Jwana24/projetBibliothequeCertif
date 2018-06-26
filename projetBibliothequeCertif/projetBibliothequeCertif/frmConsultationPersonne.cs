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

        private MAdherents adherents;
        DateTime now;
        DateTime valide;

        public frmConsultationPersonne(MPersonnes personne)
        {
            this.laPersonne = personne;
            InitializeComponent();
        }

        private void frmConsultationPersonne_Load(object sender, EventArgs e)
        {
            this.adherents = MAdherents.ChercherAdherent(laPersonne.NumAdherent);
            this.affichePersonnes();
            now = DateTime.Now;
            valide = adherents.dateCotisation.AddYears(1);

            if (now > valide)
            {

                lblRetard.Visible = true;
            }
            else
            {

                lblRetard.Visible = false;
            }
        }

        private void affichePersonnes()
        {
            txtbNumPersonne.Text = laPersonne.NumPersonne.ToString();
            txtbNom.Text = laPersonne.Nom;
            txtbPrenom.Text = laPersonne.Prenom;
            txtbCodePostal.Text = laPersonne.CodePostal;
            txtbVille.Text = laPersonne.Ville;
            txtbAdresse.Text = laPersonne.Adresse1;
            dateTimeInscription.Value = adherents.dateInscription;
            txtbEmail.Text = laPersonne.Email;
            txtbTelephone.Text = laPersonne.Telephone;
            dateTimeNaissance.Value = laPersonne.Naissance;
            dateTimeCotisation.Value = adherents.dateCotisation;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (txtbNumPersonne.Enabled == false && txtbNom.Enabled == false && txtbPrenom.Enabled == false && txtbCodePostal.Enabled == false
               && txtbVille.Enabled == false && txtbAdresse.Enabled == false && dateTimeInscription.Enabled == false && txtbEmail.Enabled == false
               && txtbTelephone.Enabled == false && dateTimeNaissance.Enabled == false && dateTimeCotisation.Enabled == false)
            {
                txtbNumPersonne.Enabled = true;
                txtbNom.Enabled = true;
                txtbPrenom.Enabled = true;
                txtbCodePostal.Enabled = true;
                txtbVille.Enabled = true;
                txtbAdresse.Enabled = true;
                dateTimeInscription.Enabled = true;
                txtbEmail.Enabled = true;
                txtbTelephone.Enabled = true;
                dateTimeNaissance.Enabled = true;
                dateTimeCotisation.Enabled = true;
            }
            else
            {
                txtbNumPersonne.Enabled = false;
                txtbNom.Enabled = false;
                txtbPrenom.Enabled = false;
                txtbCodePostal.Enabled = false;
                txtbVille.Enabled = false;
                txtbAdresse.Enabled = false;
                dateTimeInscription.Enabled = false;
                txtbEmail.Enabled = false;
                txtbTelephone.Enabled = false;
                dateTimeNaissance.Enabled = false;
                dateTimeCotisation.Enabled = false;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                MAdherents modifierAdherent = new MAdherents();
                modifierAdherent.dateCotisation = DateTime.Parse(base.dateTimeCotisation.Text);
                modifierAdherent.numAdherent = (MPersonnes.RestituerPersonne(Int32.Parse(base.txtbNumPersonne.Text))).NumAdherent;
                MAdherents.UpdateCotisation(modifierAdherent);

                // crée une référence d'objets MPersonnes
                MPersonnes modifierPersonne = new MPersonnes();

                // affecte des variables/propriétés
                modifierPersonne.NumPersonne = Int32.Parse(base.txtbNumPersonne.Text);
                modifierPersonne.Nom = base.txtbNom.Text.ToUpper();
                modifierPersonne.Prenom = base.txtbPrenom.Text.ToLower();
                modifierPersonne.CodePostal = base.txtbCodePostal.Text;
                modifierPersonne.Ville = base.txtbVille.Text.ToUpper();
                modifierPersonne.Adresse1 = base.txtbAdresse.Text;
                modifierPersonne.Email = base.txtbEmail.Text;
                modifierPersonne.Telephone = base.txtbTelephone.Text;
                modifierPersonne.Naissance = DateTime.Parse(base.dateTimeNaissance.Text);

                // enregistrement de la modification de la personne dans la BDD
                MPersonnes.UpdatePersonne(modifierPersonne);

                // ajoute la référence d'objet MPersonnes dans la collection
                Donnees.tablePersonnes = MPersonnes.ListerPersonnes("");
                // incrémentation du compteur de personnes
                MPersonnes.NPersonnes = 1;

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
