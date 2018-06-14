using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    public partial class frmNouveauLivre : projetBibliothequeCertif.frmLivres
    {
        private MLivres unLivre;
        private String unISBN, leTitre, unAuteur, unEditeur, leCode;
        private DateTime laSortie;
        private int idLivre;

        public frmNouveauLivre()
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
            MLivres nouveauLivre = new MLivres(leCode, unISBN, leTitre, unAuteur, unEditeur, laSortie, idLivre);

            // affecter des variables/propriétés
            nouveauLivre.CodeLivre = base.txtbCodeLivre.Text;
            nouveauLivre.Isbn = base.txtbISBN.Text;
            nouveauLivre.Titre = base.txtbTitre.Text;
            nouveauLivre.Categorie = base.cbbCategorie.Text;
            nouveauLivre.Auteur = base.txtbAuteur.Text.ToUpper();
            nouveauLivre.Editeur = base.txtbEditeur.Text.ToUpper();
            nouveauLivre.Sortie = DateTime.Parse(base.dateTimeSortie.Text);
            nouveauLivre.IdLivre = int.Parse(base.txtbIdLivre.Text);

            if (!(base.cbbCategorie.Items.Contains(base.cbbCategorie.Text)))
            {
                base.cbbCategorie.Items.Add(base.cbbCategorie.Text);
            }

            // numéro du livre
            nouveauLivre.ILivre++;

            //ajouter la référence d'objet MLivres dans la collection
            Donnees.arrayLivres.Add(nouveauLivre);
            // incrémentation compteur de clients
            MLivres.NLivres++;

            frmListeLivres listeLivres = new frmListeLivres();
            listeLivres.afficheLivres();
            listeLivres.Show();
            this.Close();
        }
    }
}
