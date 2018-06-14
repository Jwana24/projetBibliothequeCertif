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
    }
}
