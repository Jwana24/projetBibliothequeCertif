using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace projetBibliothequeCertif
{
    /// <summary>
    /// classe des livres : permet de mémoriser les informations concernant un livre
    /// </summary>
    public class MLivres
    {
        /// <summary>
        /// collection des objets MLivres
        /// </summary>
        private SortedDictionary<String, MLivres> lesLivres;

        public static Int32 NLivres;

        private Int32 iLivre;

        public Int32 ILivre
        {
            get { return iLivre; }
            set { iLivre = value; }
        }

        private String codeLivre;

        public String CodeLivre
        {
            get { return codeLivre; }
            set { codeLivre = value; }
        }

        /// <summary>
        /// constructeur 
        /// </summary>
        /// <param name="leCode">le code de la section</param>
        /// <param name="leNom">le libellé de la section</param>
        public MLivres(String leCode, String leTitre)
        {
            // initialise code et nom de la section
            this.CodeLivre = leCode;
            this.Titre = leTitre;
            // instancie la collection des livres
            lesLivres = new SortedDictionary<string, MLivres>();
        }

        public MLivres(String leCode, String unIsbn, String leTitre, String laCategorie, DateTime laSortie, String unAuteur, String unEditeur)
        {
            // instancie la collection des livres
            lesLivres = new SortedDictionary<string, MLivres>();

            // initialise code et nom de la section
            this.CodeLivre = leCode;
            this.Isbn = unIsbn;
            this.Titre = leTitre;
            this.Categorie = laCategorie;
            this.Auteur = unAuteur;
            this.Editeur = unEditeur;
            this.Sortie = laSortie;
        }

        public MLivres()
        {

        }

        private String isbnLivre;

        public String Isbn
        {
            get { return isbnLivre; }
            set { isbnLivre = value; }
           /* {
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
                        "Erreur classe MLivres", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                    else
                    {
                        // tout est bon, on affecte la propriété
                        isbnLivre = value;
                    }
                }
                // il n'y a pas 13 caractères
                else
                {
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" +
                    "n'est pas un isbn : 13 chiffres, pas plus, pas moins",
                        "ErreurClasse MLivres", System.Windows.Forms.MessageBoxButtons.OK);
                }
            }*/
        }

        private String titreLivre;

        public String Titre
        {
            get { return titreLivre; }
            set { titreLivre = value; }
        }

        private String categorieLivre;

        public String Categorie
        {
            get { return categorieLivre; }
            set { categorieLivre = value; }
        }

        private String auteurLivre;

        public String Auteur { get; set; }

        private String editeurLivre;

        public String Editeur { get; set; }

        private DateTime sortieLivre;

        public DateTime Sortie
        {
            get { return sortieLivre; }
            set { sortieLivre = value; }
        }

        /// <summary>
        /// ajouter un livre à la collection
        /// (reçoit la référence au livre et en déduit la clé (= codeLivre) pour la collection)
        /// </summary>
        /// <param name="unLivre">la référence du livre à ajouter</param>
        public void Ajouter(MLivres unLivre)
        {
            this.lesLivres.Add(unLivre.CodeLivre, unLivre);
        }

        /// <summary>
        /// supprimer un livre de la collection
        /// (reçoit la clé du livre (= codeLivre) pour la collection)
        /// </summary>
        /// <param name="unCodeLivre">la clé (= codeLivre) du livre à supprimer</param>
        /// <exception cref="Exception">Si codeLivre reçu non trouvé en collection</exception>
        public void Supprimer(String unCodeLivre)
        {
            // suppression sécurisée
            if (this.lesLivres.ContainsKey(unCodeLivre))
            {
                this.lesLivres.Remove(unCodeLivre);
            }
            else
            {
                throw new Exception("Erreur : code livre non trouvé dans la collection");
            }
        }

        /// <summary>
        /// modifier les données d'un livre
        /// tout est modifiable sauf le codeLivre (= clé de la collection)
        /// </summary>
        /// <param name="unLivre">la référence au nouvel objet MLivres pour cette clé</param>
        public void Remplacer(MLivres unLivre)
        {
            // modifie la référence du livre stockée dans la collection            
            this.lesLivres[unLivre.CodeLivre] = unLivre;
        }

        /// <summary>
        /// Rechercher un livre dans la liste en connaissant sa clé
        /// </summary>
        /// <param name="unCodeLivre">le codeLivre (=la clé) du livre à rechercher</param>
        /// <exception cref="Exception">Si codeLivre reçu non trouvé en collection</exception>
        /// <returns>la référence à un livre</returns>
        public static MLivres RestituerLivre(String recherche)
        {
            MLivres unLivre = null;
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM livres WHERE code_livre=@recherche";
            cmd.Parameters.AddWithValue("@recherche", recherche);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                unLivre = new MLivres();
                // affectation des 7 lignes
                unLivre.CodeLivre = reader.GetString(0);
                unLivre.Isbn = reader.GetString("isbn");
                unLivre.Titre = reader.GetString("titre");
                unLivre.Categorie = reader.GetString("categorie");
                unLivre.Sortie = reader.GetDateTime("date_sortie");
                unLivre.Auteur = reader.GetString("auteur");
                unLivre.Editeur = reader.GetString("editeur");
            }
            reader.Close();
            if (unLivre == null)
            {
                throw new Exception("Aucun livre pour le numéro " + recherche);
            }
            else
            {
                return unLivre;
            }
        }

        public void SupprimerLivres()
        {
            this.lesLivres.Clear();
        }

        /// <summary>
        /// générer et retourner une datatable
        /// qui liste les codeLivre, titreLivre, categorieLivre et auteurLivre
        /// de tous les livres de la collection
        /// </summary>
        /// <returns>une référence de datatable à 2 colonnes</returns>
        public static DataTable ListerLivres(String recherche)
        {
            DataTable tableLivres = new DataTable();

            // ajoute à la datatable 4 colonnes personnalisées pour les livres
            tableLivres.Columns.Add(new DataColumn("Code livre", typeof(System.String)));
            tableLivres.Columns.Add(new DataColumn("Titre", typeof(System.String)));
            tableLivres.Columns.Add(new DataColumn("Catégorie", typeof(System.String)));
            tableLivres.Columns.Add(new DataColumn("Auteur", typeof(System.String)));

            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM livres WHERE titre like @recherche";
            cmd.Parameters.AddWithValue("@recherche", recherche + '%');
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DataRow dr;
                dr = tableLivres.NewRow();
                // affectation des 4 colonnes
                dr[0] = reader.GetString(0);
                dr[1] = reader.GetString(2);
                dr[2] = reader.GetString(3);
                dr[3] = reader.GetString(5);
                // ajoute la ligne à la datatable
                tableLivres.Rows.Add(dr);
            }
            reader.Close();

            // fin de la boucle de remplissage de la datatable
            // retourne la référence à la datatable
            return tableLivres;
        }

        /// <summary>
        /// méthode pour insérer un livre dans l'application ainsi que dans la base de données
        /// </summary>
        /// <param name="lvr"></param>
        public static void InsertLivre(MLivres lvr)
        {
            // crée la commande sql
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "INSERT INTO livres(code_livre, isbn, titre, categorie, date_sortie, auteur, editeur)" +
                "VALUES (@codeLivre, @isbn, @titre, @categorie, @dateSortie, @auteur, @editeur)";
            // exécute la commande
            cmd.Parameters.AddWithValue("@codeLivre", lvr.CodeLivre);
            cmd.Parameters.AddWithValue("@isbn", lvr.Isbn);
            cmd.Parameters.AddWithValue("@titre", lvr.Titre);
            cmd.Parameters.AddWithValue("@categorie", lvr.Categorie);
            cmd.Parameters.AddWithValue("@dateSortie", lvr.Sortie);
            cmd.Parameters.AddWithValue("@auteur", lvr.Auteur);
            cmd.Parameters.AddWithValue("@editeur", lvr.Editeur);
            // exécute la requête
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// méthode pour mettre à jour le livre dans l'application et également dans la base de données
        /// </summary>
        /// <param name="ad"></param>
        public static void UpdateLivre(MLivres lvr)
        {
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "UPDATE livres SET titre=@Titre, isbn=@Isbn";

            cmd.Parameters.AddWithValue("@Titre", lvr.Titre);
            cmd.Parameters.AddWithValue("@Isbn", lvr.Isbn);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// méthode pour supprimer un livre dans l'application ainsi que dans la base de données
        /// </summary>
        /// <param name="num"></param>
        public static void DeleteLivre(String code)
        {
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "DELETE FROM livres WHERE code_livre=@CodeLivre";

            cmd.Parameters.AddWithValue("@CodeLivre", code);
            cmd.ExecuteNonQuery();
        }
    }
}
