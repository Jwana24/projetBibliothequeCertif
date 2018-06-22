using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetBibliothequeCertif
{
    public class MScolaires
    {
        /// <summary>
        /// collection des scolaires de cette section sous forme de dictionnaire trié
        /// </summary>
        private SortedDictionary<Int32, MScolaires> lesScolaires;

        public MScolaires (Int32 leCode, String laVille, String uneEcole, String uneClasse, String unNom, String unPrenom)
        {
            this.Code = leCode;
            this.Ville = laVille;
            this.Etablissement = uneEcole;
            this.Classe = uneClasse;
            this.Nom = unNom;
            this.Prenom = unPrenom;
        }

        /// <summary>
        /// nombre de scolaires de la classe
        /// </summary>
        public static int NScolaires;

        /// <summary>
        /// rang du scolaire
        /// </summary>
        private int iScolaire;

        private Int32 codeScolaire;

        public Int32 Code
        {
            get { return codeScolaire; }
            set { codeScolaire = value; }
        }

        private String villeScolaire;

        public String Ville
        {
            get { return villeScolaire; }
            set { villeScolaire = value.Trim().ToUpper(); }
        }

        private String etablissementScolaire;

        public String Etablissement
        {
            get { return etablissementScolaire; }
            set { etablissementScolaire = value.Trim().ToUpper(); }
        }

        private String classeScolaire;

        public String Classe
        {
            get { return classeScolaire; }
            set { classeScolaire = value; }
        }

        private String nomProf;

        public String Nom
        {
            get { return nomProf; }
            set { nomProf = value.Trim().ToUpper(); }
        }

        private String prenomProf;

        public String Prenom
        {
            get { return prenomProf; }
            set { prenomProf = value.Trim().ToLower(); }
        }
    }
}
