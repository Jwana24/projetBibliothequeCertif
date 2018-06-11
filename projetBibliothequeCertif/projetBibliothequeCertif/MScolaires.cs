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
            set { value = classeScolaire; }
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
