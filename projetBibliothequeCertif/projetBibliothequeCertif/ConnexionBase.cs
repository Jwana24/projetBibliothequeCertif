using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projetBibliothequeCertif
{
   public class ConnexionBase
    {
        private static MySqlConnection connexion = null;

        public static MySqlConnection GetConnexion()
        {
            String server = "localhost";
            String database = "projet_bibliotheque";
            String uid = "root";
            String password = "";
            String connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            if (connexion == null)
            {
                try
                {
                    connexion = new MySqlConnection();
                    connexion.ConnectionString = connectionString;
                    connexion.Open();
                }
                catch (MySqlException)
                {

                }
            }
            return connexion;
        }

        public static void CloseConnexion()
        {
            try
            {
                connexion.Close();
                connexion = null;
            }
            catch (MySqlException)
            {

            }
        }
    }
}
