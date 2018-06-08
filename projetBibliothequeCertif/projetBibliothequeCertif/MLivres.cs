using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace projetBibliothequeCertif
{
    /// <summary>
    /// classe des livres : permet de mémoriser les informations concernant un livre
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

        public MLivres(Int32 leCode, String unISBN, String leTitre, String unAuteur, String unEditeur)
        {
            leCode = this.CodeLivre;
            unISBN = this.isbnLivre;
            leTitre = this.Titre;
            unAuteur = this.Auteur;
            unEditeur = this.Editeur;
        }

        /// <summary>
        /// datatable des livres pour affichages en datagridview et pour exporter/importer en XML
        /// </summary>
        private DataTable dtLivres;

        /// <summary>
        /// collection des livres de cette section sous forme de dictionnaire trié
        /// </summary>
        private SortedDictionary<Int32, MLivres> lesLivres;

        /// <summary>
        /// générer et retourner une datatable qui liste les codes, titre et auteur de tous les livres de la collection
        /// </summary>
        /// <returns></returns>
        public DataTable ListerLivres()
        {
            // vider la datatable pour la régénérer
            this.dtLivres.Clear();
            // boucle de remplissage de la datatable à partir de la collection
            foreach (MLivres unLivre in this.lesLivres.Values)
            {
                // instanciation datarow (=ligne datatable)
                DataRow dr;
                dr = this.dtLivres.NewRow();
                // affectation des 3 colonnes
                dr[0] = unLivre.CodeLivre;
                dr[1] = unLivre.Titre;
                dr[2] = unLivre.Auteur;
                // ajouter la ligne à la datatable
                this.dtLivres.Rows.Add(dr);
            } // fin de boucle remplissage datatable
            // retourne la référence à la datatable
            return this.dtLivres;
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

        public void Ajouter(MLivres unLivre)
        {
            this.lesLivres.Add(unLivre.CodeLivre, unLivre);
        }

        public void SupprimerLivres()
        {
            this.lesLivres.Clear();
        }

        public static void SelectLivres(MLivres unLivre)
        {
            string query = "SELECT * FROM livres";
            unLivre.SupprimerLivres();

            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = query;

            // créé un datareader et exécute la commande
            MySqlDataReader dataReader = cmd.ExecuteReader();

            // lit les données et les garde en mémoire dans la liste
            while (dataReader.Read())
            {
                MLivres nouveauLivre;

                nouveauLivre = new MLivres(
                    int.Parse(dataReader["code"].ToString()),
                    dataReader["isbn"].ToString(),
                    dataReader["titre"].ToString(),
                    dataReader["auteur"].ToString(),
                    dataReader["editeur"].ToString());

                unLivre.Ajouter(nouveauLivre);
                nouveauLivre = null;
            }
            // ferme le datareader
            dataReader.Close();
        }







    }
}
