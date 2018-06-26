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

        public static MAdherents ChercherAdherent(Int32 num)
        {
            MAdherents adh = null;
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * from adherents where num_adherent=@num";
            cmd.Parameters.AddWithValue("@num", num);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                adh = new MAdherents();

                adh.dateCotisation = reader.GetDateTime("date_cotisation");
                adh.dateInscription = reader.GetDateTime("date_inscription");
            }
            reader.Close();
            return adh;
        }

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

      /*  public static long LastUpdateID()
        {
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "UPDATE last_update_id()";

            long id = 0;
            IDataReader reader = cmd.ExecuteReader();
            if (reader != null && reader.Read())
            {
                id = reader.GetInt64(0);
            }
            reader.Close();
            return id;
        }*/

        public static void UpdateAdherent(MAdherents adh)
        {
            // crée la commande sql
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "UPDATE adherents SET date_cotisation=@dateCotisation WHERE num_adherent=@numAdherent";

            cmd.Parameters.AddWithValue("@numAdherent", adh.numAdherent);
            cmd.Parameters.AddWithValue("@dateCotisation", adh.dateCotisation);
            // exécute la requête
            cmd.ExecuteNonQuery();
        }

        public static void DeleteAdherent(Int32 numero)
        {
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "DELETE FROM adherents WHERE num_adherent=@numAdherent";

            cmd.Parameters.AddWithValue("@numAdherent", numero);
            cmd.ExecuteNonQuery();
        }
    }
}
