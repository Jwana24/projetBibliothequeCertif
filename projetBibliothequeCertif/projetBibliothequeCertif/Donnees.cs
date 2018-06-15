using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace projetBibliothequeCertif
{
    // classe générale regroupant les données des adhérents et des livres
    public class Donnees
    {
        /// <summary>
        /// collection d'objets MLivres
        /// </summary>
        public static MLivres Livres;

        /// <summary>
        /// collection d'objets MLivres
        /// </summary>
        public static ArrayList arrayLivres = new ArrayList();

        public ArrayList ArrayLivres
        {
            get { return arrayLivres; }
            set { arrayLivres = value; }
        }

        /// <summary>
        /// collection d'objets MAdherents
        /// </summary>
        public static ArrayList arrayAdherents = new ArrayList();

        public ArrayList ArrayAdherents
        {
            get { return arrayAdherents; }
            set { arrayAdherents = value; }
        }

        public static object getLivreById(int id)
        {
            return Donnees.arrayLivres[id];
        }

        public static object getAdherentById(int id)
        {
            return Donnees.arrayAdherents[id];
        }
    }
}
