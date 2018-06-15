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
        private MLivres leLivre;
        private String unISBN, leTitre, unAuteur, unEditeur, leCode;
        private DateTime laSortie;
        private int idLivre;

        public frmNouveauLivre(MLivres unLivre)
        {
            InitializeComponent();
            this.leLivre = unLivre;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // contrôle les données saisies sur le form
            if (this.controle())
            {
                //  instancie le bon objet MLivres et l'ajoute à la collection de sa section  
                if (this.instancie())
                {
                    // si l'instanciation livres et son ajout en collection est OK : fermeture de la boite de dialogue par validation
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        /// <summary>
        /// fonction qui instancie un nouvel objet MLivres puis tente d'affecter ses membres (attributs ou propriété)
        /// avec interception d'une erreur éventuelle levée par la classe MLivres et ajoute la référence de ce livre dans la collection de sa section
        /// </summary>
        /// <returns>Boolean : true = OK, false = erreur</returns>
        private Boolean instancie()
        {
            // créer une référence d'objet MLivres
            MLivres nouveauLivre;
            try
            {
                // instancie un livre spécialisé DE et lui affecter toutes ses propriétés
                nouveauLivre = new MLivres(
                base.txtbCodeLivre.Text,
                base.txtbISBN.Text,
                base.txtbTitre.Text,
                base.cbbCategorie.Text,
                base.txtbAuteur.Text,
                base.txtbEditeur.Text,
                DateTime.Parse(base.dateTimeSortie.Text));

                MLivres.InsertLivre(nouveauLivre);

                return true;
            }
            catch (Exception ex)
            {
                nouveauLivre = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de livre");
                return false;
            }
        }

        /// <summary>
        /// fonction de contrôle de vraissemblance des différents champs du form
        /// (appelée avant d'instancier un objet MLivres et d'affecter ses membres)
        /// </summary>
        /// <returns>Boolean : true = OK, false = erreurs de saisie sur isbn ou numosia</returns>
        private Boolean controle()
        {
            // contrôler la vraissemblance des champs saisis
            Boolean code = true; // le code de retour ; OK a priori
            // controle nom obligatoire
            if (this.txtbCodeLivre.Text == "")
            {
                code = false;
                MessageBox.Show("Le code livre est obligatoire", "ERREUR", MessageBoxButtons.OK);
            }

            if (this.txtbISBN.Text == "")
            {
                code = false;
                MessageBox.Show("L'ISBN est obligatoire", "ERREUR", MessageBoxButtons.OK);
            }

            if (this.txtbTitre.Text == "")
            {
                code = false;
                MessageBox.Show("Le titre du livre est obligatoire", "ERREUR", MessageBoxButtons.OK);
            }

            return code;
        }
    }
}
