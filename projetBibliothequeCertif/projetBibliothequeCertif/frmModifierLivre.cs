using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    public partial class frmModifierLivre : projetBibliothequeCertif.frmLivres
    {
        private MLivres unLivre;

        public frmModifierLivre()
        {
            InitializeComponent();
        }

        private void afficheLivre()
        {
            // affecter les textbox
            this.txtbCodeLivre.Text = this.unLivre.CodeLivre.ToString();
            this.txtbISBN.Text = this.unLivre.Isbn.ToString();
            this.txtbTitre.Text = this.unLivre.Titre.ToString();
            this.cbbCategorie.Text = this.unLivre.Categorie.ToString();
            this.txtbAuteur.Text = this.unLivre.Auteur.ToString();
            this.txtbEditeur.Text = this.unLivre.Editeur.ToString();
            this.dateTimeParution.Text = this.unLivre.Parution.ToString();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmModifierLivre modifierLivre = new frmModifierLivre();
            this.Close();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            // réafficher le livre d'origine
            this.afficheLivre();
        }
    }
}
