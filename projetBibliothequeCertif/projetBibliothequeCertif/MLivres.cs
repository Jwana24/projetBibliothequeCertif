using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

        public int idLivre;

        public int IdLivre
        {
            get { return idLivre; }
            set { idLivre = value; }
        }

        /// <summary>
        /// constructeur 
        /// </summary>
        /// <param name="leCode">le code de la section</param>
        /// <param name="leNom">le libellé de la section</param>
        public MLivres(String leCode, String leTitre, int idLivre)
        {
            // initialise code et nom de la section
            this.CodeLivre = leCode;
            this.Titre = leTitre;
            this.IdLivre = idLivre;
            // instancie un dictionnaire vide pour les stagiaires de cette section
            lesAdherents = new SortedDictionary<int, MAdherents>();
            // datatable : pour y copier les données stagiaires
            // et à fournir aux composants de présentation 
            dtAdherents = new DataTable();

            // ajout à la datatable de 3 colonnes personnalisées 
            this.dtAdherents.Columns.Add(new DataColumn("Numéro adhérent", typeof(System.Int32)));
            this.dtAdherents.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            this.dtAdherents.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
        }

        public MLivres(String leCode, String unIsbn, String leTitre, String unAuteur, String unEditeur, DateTime laSortie, int idLivre)
        {
            // initialise code et nom de la section
            this.CodeLivre = leCode;
            this.Isbn = unIsbn;
            this.Titre = leTitre;
            this.Auteur = unAuteur;
            this.Editeur = unEditeur;
            this.Sortie = laSortie;
            this.IdLivre = idLivre;

            // instancie un dictionnaire vide pour la liste des adhérents
            lesAdherents = new SortedDictionary<int, MAdherents>();
            // datatable : pour y copier les données adhérents et à fournir aux composants de présentation 
            dtAdherents = new DataTable();

            // ajout à la datatable de 3 colonnes personnalisées 
            this.dtAdherents.Columns.Add(new DataColumn("Numéro adhérent", typeof(System.Int32)));
            this.dtAdherents.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            this.dtAdherents.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
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
        /// datatable des adhérents pour affichages en datagridview et pour exporter/importer en XML
        /// </summary>
        private DataTable dtAdherents;

        /// <summary>
        /// collection des adhérents de cette section sous forme de dictionnaire trié
        /// </summary>
        private SortedDictionary<Int32, MAdherents> lesAdherents;

        /// <summary>
        /// générer et retourner une datatable qui liste les numéro, nom et prenom
        /// de tous les adhérents de la collection
        /// </summary>
        /// <returns></returns>
        public DataTable ListerAdherents()
        {
            // vider la datatable pour la régénérer
            this.dtAdherents.Clear();
            // boucle de remplissage de la datatable à partir de la collection
            foreach (MAdherents unAdherent in this.lesAdherents.Values)
            {
                // instanciation datarow (=ligne datatable)
                DataRow dr;
                dr = this.dtAdherents.NewRow();
                // affectation des 3 colonnes
                dr[0] = unAdherent.NumAdherent;
                dr[1] = unAdherent.Nom;
                dr[2] = unAdherent.Prenom;
                // ajouter la ligne à la datatable
                this.dtAdherents.Rows.Add(dr);
            } // fin de boucle remplissage datatable
            // retourne la référence à la datatable
            return this.dtAdherents;
        }

        /// <summary>
        /// ajouter un adhérent à la collection
        /// (reçoit la référence à l'adhérent et en déduit la clé (= numAdherent) pour la collection)
        /// </summary>
        /// <param name="unAdherent">la référence de l'adhérent à ajouter</param>
        public void Ajouter(MAdherents unAdherent)
        {
            this.lesAdherents.Add(unAdherent.NumAdherent, unAdherent);
        }

        /// <summary>
        /// supprimer un adhérent de la collection
        /// (reçoit la clé de l'adhérent (= numAdherent) pour la collection)
        /// </summary>
        /// <param name="unNumOSIA">la clé (= numAdherent) de l'adhérent à supprimer</param>
        /// <exception cref="Exception">Si numAdherent reçu non trouvé en collection</exception>
        public void Supprimer(Int32 unNumAdherent)
        {
            // suppression sécurisée
            if (this.lesAdherents.ContainsKey(unNumAdherent))
            {
                this.lesAdherents.Remove(unNumAdherent);
            }
            else
            {
                throw new Exception("Erreur : numéro adhérent non trouvé dans la collection");
            }
        }

        /// <summary>
        /// modifier les données de l'adhérent
        /// tout est modifiable sauf le numAdherent (= clé de la collection)
        /// </summary>
        /// <param name="unAdherent">la référence au nouvel objet MAdherents pour cette clé</param>
        public void Remplacer(MAdherents unAdherent)
        {
            // modifie la référence de l'adhérent stockée dans la collection            
            this.lesAdherents[unAdherent.NumAdherent] = unAdherent;
        }

        /// <summary>
        /// Rechercher un adhérent dans la liste en connaissant sa clé
        /// </summary>
        /// <param name="unNumAdherent">le numéro (=la clé) de l'adhérent à rechercher</param>
        /// <returns>la référence à l'adhérent (ou bien lève une erreur)</returns>
        public MAdherents RestituerAdherent(Int32 unNumAdherent)
        {
            MAdherents unAdherent;
            unAdherent = this.lesAdherents[unNumAdherent];
            if (unAdherent == null)
            {
                throw new Exception("Aucun adhérent pour le numéro " + unNumAdherent.ToString());
            }
            else
            {
                return unAdherent;
            }
        }

        public void SupprimerAdherents()
        {
            this.lesAdherents.Clear();
        }

        /// <summary>
        /// méthode qui permet de sélectionner un adhérent dans l'application (lié à la base de données)
        /// </summary>
        /// <param name="unAdherent"></param>
        public static void SelectAdherents(MLivres leLivre)
        {
            string query = "SELECT * FROM adherents WHERE id_livre=@livre";
            leLivre.SupprimerAdherents();

            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = query;

            // créé un datareader et exécute la commande
            MySqlDataReader dataReader = cmd.ExecuteReader();

            // lit les données et les garde en mémoire dans la liste
            while (dataReader.Read())
            {
                MAdherents nouvelAdherent;

                nouvelAdherent = new MAdherents(
                    int.Parse(dataReader["numero"].ToString()),
                    dataReader["nom"].ToString(),
                    dataReader["prenom"].ToString(),
                    dataReader["codepostal"].ToString(),
                    dataReader["ville"].ToString(),
                    dataReader["adresse1"].ToString(),
                    dataReader["adresse2"].ToString(),
                    dataReader["telephone"].ToString(),
                    dataReader["email"].ToString());

                 leLivre.Ajouter(nouvelAdherent);
                nouvelAdherent = null;
            }
            // ferme le datareader
            dataReader.Close();
        }

            /// <summary>
            /// méthode pour insérer un adhérent dans l'application ainsi que dans la base de données
            /// </summary>
            /// <param name="ad"></param>
        public static void InsertAdherent(MAdherents ad, MLivres lvr)
        {
            string query = "INSERT INTO adherents(`num_adherent`, `id_livres`, `date_inscription`, `date_cotisation`) VALUES (Null, @livre," +
                "@dateInscription, @dateCotisation)";

            // crée la commande sql
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = query;
            // exécute la commande
            cmd.Parameters.AddWithValue("@livre", lvr.IdLivre);
            cmd.Parameters.AddWithValue("@dateInscription", ad.Inscription);
            cmd.Parameters.AddWithValue("@dateCotisation", ad.Cotisation);
            // exécute la requête
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// méthode pour mettre à jour l'adhérent dans l'application et également dans la base de données
        /// </summary>
        /// <param name="ad"></param>
        public static void UpdateAdherent(MAdherents ad)
        {
            string query = "UPDATE adherents SET date_cotisation=@dateCotisation WHERE num_adherent=@NumAdherent";

            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@dateCotisation", ad.Cotisation);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// méthode pour supprimer un adhérent dans l'application ainsi que dans la base de données
        /// </summary>
        /// <param name="num"></param>
        public static void DeleteAdherent(Int32 num)
        {
            string query = "DELETE FROM adherents WHERE num_adherent=@NumAdherent";

            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@NumAdherent", num);
            cmd.ExecuteNonQuery();
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
    }
}
