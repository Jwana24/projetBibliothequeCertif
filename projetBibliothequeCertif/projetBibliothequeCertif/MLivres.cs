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
        public static Int32 NLivres;

        private Int32 iLivre;

        public Int32 ILivre
        {
            get { return iLivre; }
            set { value = iLivre; }
        }

        private String codeLivre;

        public String CodeLivre
        {
            get { return codeLivre; }
            set { value = codeLivre; }
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

            // prépare la DataTable pour restituer la liste des livres
            dtLivres = new DataTable();

            // ajoute à la datatable 2 colonnes personnalisées pour les livres
            this.dtLivres.Columns.Add(new DataColumn("Code livre", typeof(System.String)));
            this.dtLivres.Columns.Add(new DataColumn("Titre", typeof(System.String)));
        }

        public MLivres(String leCode, String unIsbn, String leTitre, String laCategorie, String unAuteur, String unEditeur, DateTime laSortie)
        {
            // initialise code et nom de la section
            this.CodeLivre = leCode;
            this.Isbn = unIsbn;
            this.Titre = leTitre;
            this.Categorie = laCategorie;
            this.Auteur = unAuteur;
            this.Editeur = unEditeur;
            this.Sortie = laSortie;

            // instancie la collection des livres
            lesLivres = new SortedDictionary<string, MLivres>();

            // prépare la DataTable pour restituer la liste des livres
            dtLivres = new DataTable();

            // ajoute à la datatable 2 colonnes personnalisées pour les livres
            this.dtLivres.Columns.Add(new DataColumn("Code livre", typeof(System.String)));
            this.dtLivres.Columns.Add(new DataColumn("Titre", typeof(System.String)));
            this.dtLivres.Columns.Add(new DataColumn("Categorie", typeof(System.String)));
            this.dtLivres.Columns.Add(new DataColumn("Auteur", typeof(System.String)));
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

        private DateTime sortieLivre;

        public DateTime Sortie
        {
            get { return sortieLivre; }
            set { value = sortieLivre; }
        }

        /// <summary>
        /// collection des objets MLivres
        /// </summary>
        private SortedDictionary<String, MLivres> lesLivres;

        /// <summary>
        /// DataTable à 2 colonnes pour restituer la liste des livres
        /// </summary>
        private DataTable dtLivres;

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
        public MLivres RestituerLivre(String codeLivre)
        {
            MLivres leLivre;
            leLivre = this.lesLivres[codeLivre] as MLivres;
            if (leLivre == null)
            {
                throw new Exception("Aucun livre trouvé pour le code livre " + codeLivre);
            }
            else
            {
                return leLivre;
            }
        }

        public void SupprimerLivres()
        {
            this.lesLivres.Clear();
        }

        public static void AlimenterCombobox(string query, ComboBox cbbCategorie, string contenuAAfficher)
        {
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = query;
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cbbCategorie.Items.Add(dataReader[contenuAAfficher]);
            }
            dataReader.Close();
        }

        /// <summary>
        /// générer et retourner une datatable
        /// qui liste les codeLivre, titreLivre, categorieLivre et auteurLivre
        /// de tous les livres de la collection
        /// </summary>
        /// <returns>une référence de datatable à 2 colonnes</returns>
        public static DataTable ListerLivres()
        {
            DataTable dtLvr = new DataTable();

            // ajoute à la datatable 4 colonnes personnalisées pour les livres
            dtLvr.Columns.Add(new DataColumn("Code livre", typeof(System.String)));
            dtLvr.Columns.Add(new DataColumn("Titre", typeof(System.String)));
            dtLvr.Columns.Add(new DataColumn("Categorie", typeof(System.String)));
            dtLvr.Columns.Add(new DataColumn("Auteur", typeof(System.String)));

            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM livres";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DataRow dr;
                dr = dtLvr.NewRow();
                // affectation des 4 colonnes
                dr[0] = reader.GetString(0);
                dr[1] = reader.GetString(2);
                dr[2] = reader.GetString(3);
                dr[3] = reader.GetString(4);
                // ajoute la ligne à la datatable
                dtLvr.Rows.Add(dr);
            }
            reader.Close();

            // fin de la boucle de remplissage de la datatable
            // retourne la référence à la datatable
            return dtLvr;
        }

        public static void SelectLivre(MLivres livres)
        {
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM livres WHERE num_categorie=@NumCategorie AND num_editeur=@NumEditeur";
            livres.SupprimerLivres();
            cmd.Parameters.AddWithValue("@NumCategorie", livres.CodeLivre);
            cmd.Parameters.AddWithValue("@NumEditeur", livres.CodeLivre);
            // crée un dataReader et exécute la commande
            MySqlDataReader dataReader = cmd.ExecuteReader();

            // lit les données et les stocks dans la liste
            while (dataReader.Read())
            {
                MLivres nvLivre = new MLivres(
                dataReader["code"].ToString(),
                dataReader["isbn"].ToString(),
                dataReader["titre"].ToString(),
                dataReader["categorie"].ToString(),
                dataReader["auteur"].ToString(),
                dataReader["editeur"].ToString(),
                DateTime.ParseExact(dataReader["date_sortie"].ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture));

                // ajout du nouveau livre
                livres.Ajouter(nvLivre);
                nvLivre = null;
            }
            // ferme le dataReader
            dataReader.Close();
        }

        /// <summary>
        /// méthode pour insérer un livre dans l'application ainsi que dans la base de données
        /// </summary>
        /// <param name="ad"></param>
        public static void InsertLivre(MLivres lvr)
        {
            // crée la commande sql
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "INSERT INTO livres(`code_livre`, `isbn`, `titre`, `date_sortie`) VALUES (@codeLivre, @isbn, @titre, @dateSortie)";
            // exécute la commande
            cmd.Parameters.AddWithValue("@codeLivre", lvr.CodeLivre);
            cmd.Parameters.AddWithValue("@isbn", lvr.Isbn);
            cmd.Parameters.AddWithValue("@titre", lvr.Titre);
            cmd.Parameters.AddWithValue("@dateSortie", lvr.Sortie);
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
            cmd.CommandText = "UPDATE livres SET titre=@Titre, isbn=@Isbn WHERE num_categorie=@NumCategorie AND num_editeur=@NumEditeur";

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
