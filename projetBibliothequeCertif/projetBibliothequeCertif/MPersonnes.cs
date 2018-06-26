using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace projetBibliothequeCertif
{
    /// <summary>
    /// classe des personnes :
    /// permet de mémoriser les informations concernant une personne
    /// </summary>
    public class MPersonnes
    {
        /// <summary>
        /// collection des personnes de cette section sous forme de dictionnaire trié
        /// </summary>
        private SortedDictionary<Int32, MPersonnes> lesPersonnes;

        /// <summary>
        /// nombre de personnes de la classe
        /// </summary>
        public static int NPersonnes;

        /// <summary>
        /// rang de la personne
        /// </summary>
        private Int32 iPersonne;

        public Int32 IPersonne
        {
            get { return iPersonne; }
            set { iPersonne = value; }
        }

        /// <summary>
        /// obtient le numéro de la personne
        /// </summary>
        private Int32 numPersonne;

        public Int32 NumPersonne
        {
            get { return numPersonne; }
            set { numPersonne = value; }
        }

        private Int32 numAdherent;

        public Int32 NumAdherent
        {
            get { return numAdherent; }
            set { numAdherent = value; }
        }

        public MPersonnes()
        {

        }

        public MPersonnes(Int32 leNumero, String leNom, String lePrenom, String uneAdresse1,
            String leTelephone, String unEmail, DateTime uneDate, String leCode, String laVille)
        {
            // instancie la collection des personnes
            lesPersonnes = new SortedDictionary<Int32, MPersonnes>();

            leNumero = this.NumPersonne;
            leNom = this.Nom;
            lePrenom = this.Prenom;
            uneAdresse1 = this.Adresse1;
            leTelephone = this.Telephone;
            unEmail = this.Email;
            uneDate = this.Naissance;
            leCode = this.CodePostal;
            laVille = this.Ville;
        }

        /// <summary>
        /// nom de la personne forcé en majuscules
        /// </summary>
        private String nomPersonne;

        public String Nom
        {
            get { return nomPersonne; }
            set { nomPersonne = value.Trim().ToUpper(); }
        }

        /// <summary>
        /// prenom de la personne forcé en minuscule
        /// </summary>
        private String prenomPersonne;

        public String Prenom
        {
            get { return prenomPersonne; }
            set { prenomPersonne = value.Trim().ToLower(); }
        }

        /// <summary>
        /// la gestion d'exception ne permettre à l'utilisateur de taper un code postal d'exactement 5 chiffres entiers
        /// </summary>
        private String codePostalPersonne;

        public String CodePostal
        {
            get { return codePostalPersonne; }
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
                        codePostalPersonne = value;
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

        private String villePersonne;

        public String Ville
        {
            get { return villePersonne; }
            set { villePersonne = value.Trim().ToUpper(); }
        }

        private String adressePersonne;

        public String Adresse1
        {
            get { return adressePersonne; }
            set { adressePersonne = value; }
        }

        private String emailValidePattern;

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
            get { return emailValidePattern; }
            set { emailValidePattern = value; }
        }

        private DateTime inscriptionPersonne;

        public DateTime Inscription
        {
            get { return inscriptionPersonne; }
            set { inscriptionPersonne = value; }
        }

        private String telephonePersonne;

        public String Telephone
        {
            get { return telephonePersonne; }
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
                        telephonePersonne = value.ToString();
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

        private DateTime naissancePersonne;

        public DateTime Naissance
        {
            get { return naissancePersonne; }
            set { naissancePersonne = value; }
        }

        private DateTime dateCotisation;

        public DateTime Cotisation
        {
            get { return dateCotisation; }
            set { dateCotisation = value; }
        }

        /// <summary>
        /// obtient un libellé en clair (numPersonne + date_inscription et date_cotisation)
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "Personne " + this.NumPersonne + " : " + this.Inscription + " " + this.Cotisation;
        }

        /// <summary>
        /// ajouter une personne à la collection
        /// (reçoit la référence à la personne et en déduit la clé (= numPersonne) pour la collection)
        /// </summary>
        /// <param name="unePersonne">la référence de la personne à ajouter</param>
        public void Ajouter(MPersonnes unePersonne)
        {
            this.lesPersonnes.Add(unePersonne.NumPersonne, unePersonne);
        }

        /// <summary>
        /// supprimer une personne de la collection
        /// (reçoit la clé de la personne (= numPersonne) pour la collection)
        /// </summary>
        /// <param name="unNumPersonne">la clé (= numPersonne) de la personne à supprimer</param>
        /// <exception cref="Exception">Si numPersonne reçu non trouvé en collection</exception>
        public void Supprimer(Int32 unNumPersonne)
        {
            // suppression sécurisée
            if (this.lesPersonnes.ContainsKey(unNumPersonne))
            {
                this.lesPersonnes.Remove(unNumPersonne);
            }
            else
            {
                throw new Exception("Erreur : numéro personne non trouvé dans la collection");
            }
        }

        /// <summary>
        /// modifier les données de la personne
        /// tout est modifiable sauf le numPersonne (= clé de la collection)
        /// </summary>
        /// <param name="unePersonne">la référence au nouvel objet MPersonnes pour cette clé</param>
        public void Remplacer(MPersonnes unePersonne)
        {
            // modifie la référence de la personne stockée dans la collection            
            this.lesPersonnes[unePersonne.NumPersonne] = unePersonne;
        }

        /// <summary>
        /// Rechercher une personne dans la liste en connaissant sa clé
        /// </summary>
        /// <param name="unNumPersonne">le numéro (=la clé) de la personne à rechercher</param>
        /// <returns>la référence à la personne (ou bien lève une erreur)</returns>
        public static MPersonnes RestituerPersonne(Int32 recherche)
        {
            MPersonnes unePersonne = null;
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT`num_personne`,`nom`,`prenom`,`date_naissance`,`adresse1`,`email`,`telephone`,personnes.num_adherent," +
                "`cp`,`ville`,`date_inscription`,`date_cotisation` FROM personnes JOIN adherents on personnes.num_adherent = adherents.num_adherent" +
                "WHERE num_personne = @recherche";
            cmd.Parameters.AddWithValue("@recherche", recherche);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                unePersonne = new MPersonnes();
                // affectation des 10 lignes
                unePersonne.NumPersonne = reader.GetInt32(0);
                unePersonne.Nom = reader.GetString("nom");
                unePersonne.Prenom = reader.GetString("prenom");
                unePersonne.Naissance = reader.GetDateTime("date_naissance");
                unePersonne.Adresse1 = reader.GetString("adresse1");
                unePersonne.Email = reader.GetString("email");
                unePersonne.Telephone = reader.GetString("telephone");
                unePersonne.CodePostal = reader.GetString("cp");
                unePersonne.Ville = reader.GetString("ville");
                unePersonne.NumAdherent = reader.GetInt32("num_adherent");
            }
            reader.Close();
            if (unePersonne == null)
            {
                throw new Exception("Aucune personne pour le numéro " + recherche);
            }
            else
            {
                return unePersonne;
            }
        }

        public void SupprimerPersonnes()
        {
            this.lesPersonnes.Clear();
        }

        /// <summary>
        /// générer et retourner une datatable qui liste les numéros, noms, prénoms et dates d"inscription
        /// de toutes les personnes de la collection
        /// </summary>
        /// <returns></returns>
        public static DataTable ListerPersonnes(String recherche)
        {
            DataTable tablePersonnes = new DataTable();

            // ajoute à la datatable 4 colonnes personnalisées pour les personnes
            tablePersonnes.Columns.Add(new DataColumn("Num personne", typeof(System.Int32)));
            tablePersonnes.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            tablePersonnes.Columns.Add(new DataColumn("Prénom", typeof(System.String)));

            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM personnes WHERE nom like @recherche";
            cmd.Parameters.AddWithValue("@recherche", recherche + '%');
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DataRow dr;
                dr = tablePersonnes.NewRow();
                // affectation des 4 lignes
                dr[0] = reader.GetString(0);
                dr[1] = reader.GetString(1);
                dr[2] = reader.GetString(2);
                // ajoute les lignes à la datatable
                tablePersonnes.Rows.Add(dr);
            }
            reader.Close();

            // fin de la boucle de remplissage de la datatable
            // retourne la référence à la datatable
            return tablePersonnes;
        }

        /// <summary>
        /// méthode pour insérer une personne dans l'application ainsi que dans la base de données
        /// </summary>
        /// <param name="ad"></param>
        public static void InsertPersonne(MPersonnes ad)
        {
            // crée la commande sql
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "INSERT INTO personnes(num_personne, num_adherent, nom, prenom, date_naissance, adresse1, email, telephone, cp, ville) " +
                "VALUES (@NumPersonne, @NumAdherent, @nom, @prenom, @dateNaissance, @adresse1, @email, @telephone, @cp, @ville)";

            cmd.Parameters.AddWithValue("@numAdherent", ad.NumAdherent);
            cmd.Parameters.AddWithValue("@numPersonne", ad.NumPersonne);
            cmd.Parameters.AddWithValue("@nom", ad.Nom);
            cmd.Parameters.AddWithValue("@prenom", ad.Prenom);
            cmd.Parameters.AddWithValue("@dateNaissance", ad.Naissance);
            cmd.Parameters.AddWithValue("@adresse1", ad.Adresse1);
            cmd.Parameters.AddWithValue("@email", ad.Email);
            cmd.Parameters.AddWithValue("@telephone", ad.Telephone);
            cmd.Parameters.AddWithValue("@cp", ad.CodePostal);
            cmd.Parameters.AddWithValue("@ville", ad.Ville);
            // exécute la requête
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// méthode pour mettre à jour la personne dans l'application et également dans la base de données
        /// </summary>
        /// <param name="pers"></param>
        public static void UpdatePersonne(MPersonnes pers)
        {
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "UPDATE personnes SET date_cotisation=@dateCotisation WHERE num_adherent=@NumAdherent";
            
            cmd.Parameters.AddWithValue("@dateCotisation", pers.Cotisation);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// méthode pour supprimer une personne dans l'application ainsi que dans la base de données
        /// </summary>
        /// <param name="num"></param>
        public static void DeletePersonne(Int32 numero)
        {
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "DELETE FROM personnes WHERE num_personne=@numPersonne";
            
            cmd.Parameters.AddWithValue("@numPersonne", numero);
            cmd.ExecuteNonQuery();
        }
    }
}
