using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    /// <summary>
    /// classe des adhérents :
    /// permet de mémoriser les informations concernant un adhérent
    /// </summary>
    public class MAdherents
    {
        /// <summary>
        /// collection des adhérents de cette section sous forme de dictionnaire trié
        /// </summary>
        private SortedDictionary<Int32, MAdherents> lesAdherents;

        /// <summary>
        /// nombre d'adhérents de la classe
        /// </summary>
        public static int NAdherents;

        /// <summary>
        /// rang de l'adhérent
        /// </summary>
        private int iAdherent;

        public Int32 IAdherent
        {
            get { return iAdherent; }
            set { value = iAdherent; }
        }

        /// <summary>
        /// obtient le numéro de l'adhérent
        /// </summary>
        private Int32 numAdherent;

        public Int32 NumAdherent
        {
            get { return numAdherent; }
            set { value = numAdherent; }
        }

        public MAdherents(Int32 leNumero, String leNom, String lePrenom, String leCodePostal, String laVille, String uneAdresse1, String uneAdresse2,
            String leTelephone, String unEmail)
        {
            leNumero = this.NumAdherent;
            leNom = this.Nom;
            lePrenom = this.Prenom;
            leCodePostal = this.CodePostal;
            laVille = this.Ville;
            uneAdresse1 = this.Adresse1;
            uneAdresse2 = this.Adresse2;
            leTelephone = this.Telephone;
            unEmail = this.Email;
        }

        /// <summary>
        /// nom de l'adhérent forcé en majuscules
        /// </summary>
        private String nomAdherent;

        public String Nom
        {
            get { return nomAdherent; }
            set { nomAdherent = value.Trim().ToUpper(); }
        }

        /// <summary>
        /// prenom de l'adhérent forcé en minuscule
        /// </summary>
        private String prenomAdherent;

        public String Prenom
        {
            get { return prenomAdherent; }
            set { prenomAdherent = value.Trim().ToLower(); }
        }

        /// <summary>
        /// la gestion d'exception ne permettre à l'utilisateur de taper un code postal d'exactement 5 chiffres entiers
        /// </summary>
        private String codePostalAdherent;

        public String CodePostal
        {
            get { return codePostalAdherent; }
            set
            {
                // variable de boucle
                Int32 i;
                // indicateur d'erreur
                Boolean erreur = false;

                if (value.Length == 5)
                {
                    for (i = 0; i < value.Length; i++)
                    {
                        if (!(Char.IsDigit(value[i])))
                        { erreur = true; }
                    }
                    // on a rencontre autre chose qu'un chiffre
                    if (erreur)
                    {
                        System.Windows.Forms.MessageBox.Show(
                        value.ToString() + "\n" + "n'est pas un code postal valide : uniquement des chiffres",
                        "Erreur Classe MUsagers", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                    else
                    {
                        // tout est bon on affecte la propriété
                        codePostalAdherent = value;
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" +
                    "n'est pas un code postal valide : 5 chiffres, pas plus, pas moins",
                    "ErreurClasse MUsagers",
                    System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }

        private String villeAdherent;

        public String Ville
        {
            get { return villeAdherent; }
            set { villeAdherent = value.Trim().ToUpper(); }
        }

        private String adresse1Adherent;

        public String Adresse1
        {
            get { return adresse1Adherent; }
            set { value = adresse1Adherent; }
        }

        private String adresse2Adherent;

        public String Adresse2
        {
            get { return adresse2Adherent; }
            set { value = adresse2Adherent; }
        }

        private String email;

        static Regex EmailValideRegex = CreerEmailValideRegex();

        private static Regex CreerEmailValideRegex()
        {
            string emailValidePattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(emailValidePattern, RegexOptions.IgnoreCase);
        }

        internal static bool EmailEstValide(string adresseEmail)
        {
            bool estValide = EmailValideRegex.IsMatch(adresseEmail);

            return estValide;
        }

        public String Email
        {
            get { return email; }
            set { value = email; }
        }

        private DateTime inscriptionAdherent;

        public DateTime Inscription
        {
            get { return inscriptionAdherent; }
            set { value = inscriptionAdherent; }
        }

        private String telephoneAdherent;

        public String Telephone
        {
            get { return telephoneAdherent; }
            set
            {
                int i;
                Boolean erreur = false;

                // 10 caractères attendus : OK
                if (value.Length == 10)
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
                        + "n'est pas un numéro de téléphone valide : uniquement des chiffres",
                        "Erreur Classe MUsagers", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                    else
                    {
                        // tout est bon, on affecte la propriété
                        telephoneAdherent = value.ToString();
                    }
                }
                // il n'y a pas 10 caractères
                else
                {
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" +
                    "n'est pas un numéro de téléphone valide : 10 chiffres, pas plus, pas moins",
                        "ErreurClasse MUsagers", System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }

        private DateTime naissanceAdherent;

        public DateTime Naissance
        {
            get { return naissanceAdherent; }
            set { value = naissanceAdherent; }
        }

        private String dateCotisation;

        public String Cotisation
        {
            get { return dateCotisation; }
            set { value = dateCotisation; }
        }

        /// <summary>
        /// obtient un libellé en clair (numAdherent + date_inscription et date_cotisation)
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "Adherent " + this.NumAdherent + " : " + this.Inscription + " " + this.Cotisation;
        }

        /// <summary>
        /// datatable des adhérents pour affichages en datagridview et pour exporter/importer en XML
        /// </summary>
        private DataTable dtAdherents;

        /// <summary>
        /// Constructeur par défaut
        /// (initialise la collection et le datatable)
        /// </summary>
        public MAdherents()
        {
            // instancie la collection des adhérents
            lesAdherents = new SortedDictionary<int, MAdherents>();
            // prépare la DataTable pour restituer la liste des adhérents
            dtAdherents = new DataTable();
            // ajout à la datatable de 3 colonnes personnalisées pour les adhérents
            this.dtAdherents.Columns.Add(new DataColumn("Numéro adhérent", typeof(System.Int32)));
            this.dtAdherents.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            this.dtAdherents.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
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

        public void SupprimerAdherents()
        {
            this.lesAdherents.Clear();
        }

        /// <summary>
        /// méthode qui permet de sélectionner un adhérent dans l'application (lié à la base de données)
        /// </summary>
        public static void SelectAdherents(MAdherents unAdherent)
        {
            string query = "SELECT * FROM adherents WHERE num_adherent=@NumAdherent";
            unAdherent.SupprimerAdherents();

            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.Parameters.AddWithValue("@NumAdherent", unAdherent.NumAdherent);
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

                unAdherent.Ajouter(nouvelAdherent);
                nouvelAdherent = null;
            }
            // ferme le datareader
            dataReader.Close();
        }

        /// <summary>
        /// méthode pour insérer un adhérent dans l'application ainsi que dans la base de données
        /// </summary>
        /// <param name="ad"></param>
        public static void InsertAdherent(MAdherents ad)
        {
            string query = "INSERT INTO adherents(`num_adherent`, `id_livres`, `date_inscription`, `date_cotisation`) VALUES (Null," +
                "@dateInscription, @dateCotisation)";

            // crée la commande sql
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = query;
            // exécute la commande
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
