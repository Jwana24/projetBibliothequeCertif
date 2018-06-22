using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
        /// collection d'objets MPersonnes
        /// </summary>
        public static MPersonnes Personnes;

        /// <summary>
        /// collection d'objets MLivres
        /// </summary>
        public static DataTable tableLivres = new DataTable();

        /// <summary>
        /// collection d'objets MPersonnes
        /// </summary>
        public static DataTable tablePersonnes = new DataTable();
    }
}
