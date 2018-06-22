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
        /// collection d'objets MLivres
        /// </summary>
        public static DataTable tableLivres = new DataTable();

        public DataTable TableLvr
        {
            get { return tableLivres; }
            set { tableLivres = value; }
        }

        /// <summary>
        /// collection d'objets MAdherents
        /// </summary>
        public static DataTable tablePersonnes = new DataTable();

        public DataTable TablePers
        {
            get { return tablePersonnes; }
            set { tablePersonnes = value; }
        }

        public static object getLivreById(int id)
        {
            return Donnees.tableLivres;
        }

        public static object getPersonneById(int id)
        {
            return Donnees.tablePersonnes;
        }
    }
}
