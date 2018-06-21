using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetBibliothequeCertif
{
    public class MAdherents
    {
        public Int32 numAdherent;

        public DateTime dateInscription;

        public DateTime dateCotisation;

        public static void InsertAdherent(MAdherents adh)
        {
            // crée la commande sql
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "INSERT INTO adherents(num_adherent, date_inscription, date_cotisation) " +
                "VALUES (@numAdherent, @dateInscription, @dateCotisation)";

            cmd.Parameters.AddWithValue("@numAdherent", adh.numAdherent);
            cmd.Parameters.AddWithValue("@dateInscription", adh.dateInscription);
            cmd.Parameters.AddWithValue("@dateCotisation", adh.dateCotisation);
            // exécute la requête
            cmd.ExecuteNonQuery();
        }

        public static long LastInsertId()
        {
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT last_insert_id()";

            long id = 0;
            IDataReader reader = cmd.ExecuteReader();
            if(reader!=null && reader.Read())
            {
                id = reader.GetInt64(0);
            }
            reader.Close();
            return id;
        }
    }
}
