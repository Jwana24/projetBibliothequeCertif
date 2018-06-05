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
    /// classe des usagers :
    /// permet de mémoriser les informations concernant un usager
    /// </summary>
    public class MUsagers
    {
         /// <summary>
         /// nombre d'usagers de la classe
         /// </summary>
         public static int NUsagers;

         /// <summary>
         /// rang de l'usager
         /// </summary>
         private int iUsager;

         public Int32 IUsager
         {
             get { return iUsager; }
             set { value = iUsager; }
         }

        /// <summary>
        /// obtient le numéro de l'usager
        /// </summary>
        private Int32 numUsager;

        public Int32 NumUsager
        {
            get { return numUsager; }
        }

        public MUsagers(Int32 leNumero, String leNom, String lePrenom, String leCodePostal, String laVille, String uneAdresse1, String uneAdresse2,
            String leTelephone)
        {
            leNumero = this.NumUsager;
            leNom = this.Nom;
            lePrenom = this.Prenom;
            leCodePostal = this.CodePostal;
            laVille = this.Ville;
            uneAdresse1 = this.Adresse1;
            uneAdresse2 = this.Adresse2;
            leTelephone = this.Telephone;
        }

        /// <summary>
        /// datatable des usagers pour affichages en datagridview et pour exporter/importer en XML
        /// </summary>
        private DataTable dtUsagers;

        /// <summary>
        /// collection des usagers de cette section sous forme de dictionnaire trié
        /// </summary>
        private SortedDictionary<Int32, MUsagers> lesUsagers;

        /// <summary>
        /// générer et retourner une datatable qui liste les numéro, nom et prenom
        /// de tous les usagers de la collection
        /// </summary>
        /// <returns></returns>
        public DataTable ListerUsagers()
        {
            // vider la datatable pour la régénérer
            this.dtUsagers.Clear();
            // boucle de remplissage de la datatable à partir de la collection
            foreach (MUsagers unUsager in this.lesUsagers.Values)
            {
                // instanciation datarow (=ligne datatable)
                DataRow dr;
                dr = this.dtUsagers.NewRow();
                // affectation des 3 colonnes
                dr[0] = unUsager.NumUsager;
                dr[1] = unUsager.Nom;
                dr[2] = unUsager.Prenom;
                // ajouter la ligne à la datatable
                this.dtUsagers.Rows.Add(dr);
            } // fin de boucle remplissage datatable
            // retourne la référence à la datatable
            return this.dtUsagers;
        }

        /// <summary>
        /// nom de l'usager forcé en majuscules
        /// </summary>
        private String nomUsager;

        public String Nom
        {
            get { return nomUsager; }
            set { nomUsager = value.Trim().ToUpper(); }
        }

        /// <summary>
        /// prenom de l'usager forcé en minuscule
        /// </summary>
        private String prenomUsager;

        public String Prenom
        {
            get { return prenomUsager; }
            set { prenomUsager = value.Trim().ToLower(); }
        }

        /// <summary>
        /// la gestion d'exception ne permettre à l'utilisateur de taper un code postal d'exactement 5 chiffres entiers
        /// </summary>
        private String codePostalUsager;

        public String CodePostal
        {
            get { return codePostalUsager; }
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
                        codePostalUsager = value;
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

        private String villeUsager;

        public String Ville
        {
            get { return villeUsager; }
            set { villeUsager = value.Trim().ToUpper(); }
        }

        private String adresse1Usager;

        public String Adresse1
        {
            get { return adresse1Usager; }
            set { value = adresse1Usager; }
        }

        private String adresse2Usager;

        public String Adresse2
        {
            get { return adresse2Usager; }
            set { value = adresse2Usager; }
        }

        private Boolean email;

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

        public Boolean Email
        {
            get { return email; }
            set
            {
                if (Email == true)
                {
                    value = email;
                }
            }
        }

        private DateTime inscriptionUsager;

        public DateTime Inscription
        {
            get { return inscriptionUsager; }
            set { value = inscriptionUsager; }
        }

        private String telephoneUsager;

        public String Telephone
        {
            get { return telephoneUsager; }
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
                        telephoneUsager = value.ToString();
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

        public void Ajouter(MUsagers unUsager)
        {
            this.lesUsagers.Add(unUsager.NumUsager, unUsager);
        }

        public void SupprimerUsagers()
        {
            this.lesUsagers.Clear();
        }

        public static void SelectUsagers(MUsagers unUsager)
        {
            string query = "SELECT * FROM usagers";
            unUsager.SupprimerUsagers();

            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = query;

            // créé un datareader et exécute la commande
            MySqlDataReader dataReader = cmd.ExecuteReader();

            // lit les données et les garde en mémoire dans la liste
            while (dataReader.Read())
            {
                MUsagers nouvelUsager;

                nouvelUsager = new MUsagers(
                    int.Parse(dataReader["numero"].ToString()),
                    dataReader["nom"].ToString(),
                    dataReader["prenom"].ToString(),
                    dataReader["codepostal"].ToString(),
                    dataReader["ville"].ToString(),
                    dataReader["adresse1"].ToString(),
                    dataReader["adresse2"].ToString(),
                    dataReader["telephone"].ToString());

                unUsager.Ajouter(nouvelUsager);
                nouvelUsager = null;
            }
            // ferme le datareader
            dataReader.Close();
        }
    }
}
