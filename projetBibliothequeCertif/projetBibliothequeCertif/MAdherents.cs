using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace projetBibliothequeCertif
{
    /// <summary>
    /// classe des adhérents :
    /// permet de mémoriser les informations concernant un adhérent
    /// </summary>
    public class MAdherents
    {
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
            String leTelephone)
        {
            leNumero = this.NumAdherent;
            leNom = this.Nom;
            lePrenom = this.Prenom;
            leCodePostal = this.CodePostal;
            laVille = this.Ville;
            uneAdresse1 = this.Adresse1;
            uneAdresse2 = this.Adresse2;
            leTelephone = this.Telephone;
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

        public void Ajouter(MAdherents unAdherent)
        {
            this.lesAdherents.Add(unAdherent.NumAdherent, unAdherent);
        }

        public void SupprimerAdherents()
        {
            this.lesAdherents.Clear();
        }

        public static void SelectAdherents(MAdherents unAdherent)
        {
            string query = "SELECT * FROM adherents";
            unAdherent.SupprimerAdherents();

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
                    dataReader["telephone"].ToString());

                unAdherent.Ajouter(nouvelAdherent);
                nouvelAdherent = null;
            }
            // ferme le datareader
            dataReader.Close();
        }
    }
}
