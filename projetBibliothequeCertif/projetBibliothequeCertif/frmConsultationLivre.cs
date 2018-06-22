using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    public partial class frmConsultationLivre : projetBibliothequeCertif.frmLivres
    {
        protected MLivres leLivre;

        public frmConsultationLivre(MLivres livre)
        {
            // on crée une référence d'objet livre pointant vers le livre d'origine de la collection
            this.leLivre = livre;
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if(txtbCodeLivre.Enabled == false && txtbISBN.Enabled == false && txtbTitre.Enabled == false && cbbCategorie.Enabled == false &&
                txtbAuteur.Enabled == false && txtbEditeur.Enabled == false && dateTimeSortie.Enabled == false)
            {
                txtbCodeLivre.Enabled = true;
                txtbISBN.Enabled = true;
                txtbTitre.Enabled = true;
                cbbCategorie.Enabled = true;
                txtbAuteur.Enabled = true;
                txtbEditeur.Enabled = true;
                dateTimeSortie.Enabled = true;
            }
            else
            {
                txtbCodeLivre.Enabled = false;
                txtbISBN.Enabled = false;
                txtbTitre.Enabled = false;
                cbbCategorie.Enabled = false;
                txtbAuteur.Enabled = false;
                txtbEditeur.Enabled = false;
                dateTimeSortie.Enabled = false;
            }
        }

        private void frmConsultationLivre_Load(object sender, EventArgs e)
        {
            this.afficheLivres();
        }

        public void afficheLivres()
        {
            // affecter les textbox
            this.txtbCodeLivre.Text = this.leLivre.CodeLivre;
            this.txtbISBN.Text = this.leLivre.Isbn;
            this.txtbTitre.Text = this.leLivre.Titre;
            this.cbbCategorie.Text = this.leLivre.Categorie;
            this.txtbAuteur.Text = this.leLivre.Auteur;
            this.txtbEditeur.Text = this.leLivre.Editeur;
            this.dateTimeSortie.Text = this.leLivre.Sortie.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
