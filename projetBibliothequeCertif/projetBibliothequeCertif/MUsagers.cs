using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
        public static Int32 NUsagers;

        /// <summary>
        /// rang de l'usager
        /// </summary>
        private Int32 iUsager;

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
            set { value = numUsager; }
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

        private String adresseUsager1;

        public String Adresse1
        {
            get { return adresseUsager1; }
            set { value = adresseUsager1; }
        }

        private String adresseUsager2;

        public String Adresse2
        {
            get { return adresseUsager2; }
            set { value = adresseUsager2; }
        }

        static Regex ValidEmailRegex = CreateValidEmailRegex();

        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        internal static bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
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
                Int32 i;
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
    }
}
