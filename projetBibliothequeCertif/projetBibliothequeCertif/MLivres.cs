using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetBibliothequeCertif
{
    /// <summary>
    /// classe des livres :
    /// permet de mémoriser les informations concernant un livre
    /// </summary>
    public class MLivres
    {
        public static Int32 NLivres;

        private Int32 iLivre;

        public Int32 ILivre
        {
            get { return iLivre; }
            set { value = iLivre; }
        }

        private Int32 codeLivre;

        public Int32 CodeLivre
        {
            get { return codeLivre; }
            set { value = codeLivre; }
        }

        private String isbnLivre;

        public String Isbn
        {
            get { return isbnLivre; }
            set
            {
                int i;
                Boolean erreur = false;

                // 13 caractères attendus : OK
                if (value.Length == 13)
                {
                    // controle chiffres par boucle
                    for (i = 0; i < value.Length; i++)
                    {
                        if (!(Char.IsDigit(value[i])))
                        { erreur = true; }
                    }
                    // on a rencontre autre chose qu'un chiffre
                    if (erreur)
                    {
                        System.Windows.Forms.MessageBox.Show(value.ToString() +
                        "\n"
                        + "n'est pas un isbn valide : uniquement des chiffres",
                        "Erreur Classe MLivres", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                    else
                    {
                        // tout est bon, on affecte la propriété
                        isbnLivre = value.ToString();
                    }
                }
                // il n'y a pas 13 caractères
                else
                {
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" +
                    "n'est pas un isbn : 13 chiffres, pas plus, pas moins",
                        "ErreurClasse MLivres", System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }

        private String titreLivre;

        public String Titre
        {
            get { return titreLivre; }
            set { value = titreLivre; }
        }

        private String categorieLivre;

        public String Categorie
        {
            get { return categorieLivre; }
            set { value = categorieLivre; }
        }

        private String auteurLivre;

        public String Auteur
        {
            get { return auteurLivre; }
            set { auteurLivre = value.Trim().ToUpper(); }
        }

        private String editeurLivre;

        public String Editeur
        {
            get { return editeurLivre; }
            set { editeurLivre = value.Trim().ToUpper(); }
        }

        private DateTime parutionLivre;

        public DateTime Parution
        {
            get { return parutionLivre; }
            set { value = parutionLivre; }
        }
    }
}
