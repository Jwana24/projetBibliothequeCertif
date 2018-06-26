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
        String leNom, lePrenom, uneAdresse1, leTelephone, unEmail, leCodePostal, laVille;
        Int32 leNumero;
        DateTime uneDate;

        private MPersonnes laPersonne;
        private MLivres unLivre;

        public frmConsultationPersonne(MPersonnes personne)
        {
            this.laPersonne = personne;
            InitializeComponent();
        }

        private void grpCotisations_Enter(object sender, EventArgs e)
        {
            //  DateTime adhesion =new DateTime(2016, 1, 18);
            DateTime adhesion = new DateTime(2018, 1, 18);
            DateTime now = DateTime.Now;
            DateTime after = adhesion.AddYears(1);
            Console.WriteLine(adhesion + "  " + now + "  " + after);

            if (now > after)
            {
                MessageBox.Show("vous devez vous réabonner");
                lblRetard.Visible = true;
            }
            else
            {
                MessageBox.Show("votre abonnement est valide");
                lblRetard.Visible = false;
            }
        }

        private void frmConsultationPersonne_Load(object sender, EventArgs e)
        {
            this.affichePersonnes(this.laPersonne);
        }

        private void affichePersonnes(MPersonnes laPersonne)
        {
            txtbNumPersonne.Text = laPersonne.NumPersonne.ToString();
            txtbNom.Text = laPersonne.Nom;
            txtbPrenom.Text = laPersonne.Prenom;
            txtbCodePostal.Text = laPersonne.CodePostal;
            txtbVille.Text = laPersonne.Ville;
            txtbAdresse.Text = laPersonne.Adresse1;
            dateTimeInscription.Value = laPersonne.Inscription;
            txtbEmail.Text = laPersonne.Email;
            txtbTelephone.Text = laPersonne.Telephone;
            dateTimeNaissance.Value = laPersonne.Naissance;
            MessageBox.Show(dateTimeNaissance.Value.ToString());
            dateTimeCotisation.Value = laPersonne.Cotisation;
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
            MAdherents modifierAdherent = new MAdherents();
            modifierAdherent.dateInscription = DateTime.Parse(base.dateTimeInscription.Text);
            modifierAdherent.dateCotisation = DateTime.Parse(base.dateTimeCotisation.Text);
            MAdherents.UpdateAdherent(modifierAdherent);

            // crée une référence d'objets MPersonnes
            MPersonnes modifierPersonne = new MPersonnes(leNumero, leNom, lePrenom, uneAdresse1, leTelephone, unEmail, uneDate, leCodePostal, laVille);

            // affecte des variables/propriétés
            modifierPersonne.NumPersonne = Int32.Parse(base.txtbNumPersonne.Text);
            modifierPersonne.NumAdherent = (Int32)(MAdherents.LastUpdateID());
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
    }
}
