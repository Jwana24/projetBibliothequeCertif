using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        public MScolaires (Int32 leCode, String uneVille, String uneEcole, String uneClasse, String unCP, String unNom, String unPrenom)
        {
            lesScolaires = new SortedDictionary<Int32, MScolaires>();

            leCode = this.Code;
            uneVille = this.Ville;
            uneEcole = this.Etablissement;
            uneClasse = this.Classe;
            unCP = this.CodePostal;
            unNom = this.Nom;
            unPrenom = this.Prenom;
        }

        public MScolaires()
        {

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

        private Int32 numAdherent;

        public Int32 NumAdherent
        {
            get { return numAdherent; }
            set { numAdherent = value; }
        }

        private String classeScolaire;

        public String Classe
        {
            get { return classeScolaire; }
            set { classeScolaire = value; }
        }

        private String etablissementScolaire;

        public String Etablissement { get; set; }

        private String codePostalScolaire;

        public String CodePostal
        {
            get { return codePostalScolaire; }
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
                        codePostalScolaire = value;
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

        private String villeScolaire;

        public String Ville { get; set; }

        private String nomProf;

        public String Nom { get; set; }

        private String prenomProf;

        public String Prenom { get; set; }

        public DateTime inscriptionScolaire;

        public DateTime Inscription { get; set; }

        public void Ajouter(MScolaires unScolaire)
        {
            this.lesScolaires.Add(unScolaire.Code, unScolaire);
        }

        public void Supprimer(Int32 unCodeScolaire)
        {
            // suppression sécurisée
            if (this.lesScolaires.ContainsKey(unCodeScolaire))
            {
                this.lesScolaires.Remove(unCodeScolaire);
            }
            else
            {
                throw new Exception("Erreur : numéro scolaire non trouvé dans la collection");
            }
        }

        public void Remplacer(MScolaires unScolaire)
        {
            // modifie la référence du scolaire stocké dans la collection            
            this.lesScolaires[unScolaire.Code] = unScolaire;
        }

        public static MScolaires RestituerScolaire(Int32 recherche)
        {
            MScolaires unScolaire = null;
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM classes_scolaire WHERE code_scolaire=@recherche";
            cmd.Parameters.AddWithValue("@recherche", recherche);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                unScolaire = new MScolaires();
                // affectation des 9 lignes
                unScolaire.Code = reader.GetInt32(0);
                unScolaire.Classe = reader.GetString("libelle");
                unScolaire.NumAdherent = reader.GetInt32("num_adherent");
                unScolaire.Etablissement = reader.GetString("nom_ecole");
                unScolaire.CodePostal = reader.GetString("cp");
                unScolaire.Ville = reader.GetString("ville");
                unScolaire.Nom = reader.GetString("nom_prof");
                unScolaire.Prenom = reader.GetString("prenom_prof");
            }
            reader.Close();
            if (unScolaire == null)
            {
                throw new Exception("Aucun scolaire pour le numéro " + recherche);
            }
            else
            {
                return unScolaire;
            }
        }

        public void SupprimerScolaires()
        {
            this.lesScolaires.Clear();
        }

        public MScolaires RechercherScolaires(Int32 Code)
        {
            MScolaires scolaire;
            scolaire = this.lesScolaires[Code] as MScolaires;
            if (scolaire == null)
            {
                throw new Exception("Vous n'avez pas de scolaire sélectionné");
            }
            else
            {
                return scolaire;
            }
        }

        public static DataTable ListerScolaires(String recherche)
        {
            DataTable tableScolaires = new DataTable();

            // ajoute à la datatable 4 colonnes personnalisées pour les scolaires
            tableScolaires.Columns.Add(new DataColumn("Code scolaire", typeof(System.Int32)));
            tableScolaires.Columns.Add(new DataColumn("Ecole", typeof(System.String)));
            tableScolaires.Columns.Add(new DataColumn("Classe", typeof(System.String)));
            tableScolaires.Columns.Add(new DataColumn("Ville", typeof(System.String)));

            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "SELECT * FROM classes_scolaire WHERE libelle like @recherche";
            cmd.Parameters.AddWithValue("@recherche", recherche + '%');
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DataRow dr;
                dr = tableScolaires.NewRow();
                // affectation des 4 lignes
                dr[0] = reader.GetString(0);
                dr[1] = reader.GetString(3);
                dr[2] = reader.GetString(1);
                dr[3] = reader.GetString(5);
                // ajoute les lignes à la datatable
                tableScolaires.Rows.Add(dr);
            }
            reader.Close();

            // fin de la boucle de remplissage de la datatable
            // retourne la référence à la datatable
            return tableScolaires;
        }

        public static void InsertScolaire(MScolaires sco)
        {
            // crée la commande sql
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "INSERT INTO classes_scolaire(code_scolaire, libelle, num_adherent, nom_ecole, cp, ville, nom_prof, prenom_prof) " +
                "VALUES (@codeScolaire, @libelle, @numAdherent, @nomEcole, @cp, @ville, @nomProf, @prenomProf)";

            cmd.Parameters.AddWithValue("@codeScolaire", sco.Code);
            cmd.Parameters.AddWithValue("@libelle", sco.Classe);
            cmd.Parameters.AddWithValue("@numAdherent", sco.NumAdherent);
            cmd.Parameters.AddWithValue("@nomEcole", sco.Etablissement);
            cmd.Parameters.AddWithValue("@cp", sco.CodePostal);
            cmd.Parameters.AddWithValue("@ville", sco.Ville);
            cmd.Parameters.AddWithValue("@nomProf", sco.Nom);
            cmd.Parameters.AddWithValue("@prenomProf", sco.Prenom);
            // exécute la requête
            cmd.ExecuteNonQuery();
        }

        public static void UpdateScolaire(MScolaires sco)
        {
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "UPDATE classes_scolaire SET libelle=@libelle, nom_prof=@NomProf, prenom_prof=@PrenomProf" +
                "WHERE num_adherent=@NumAdherent";

            cmd.Parameters.AddWithValue("@libelle", sco.Classe);
            cmd.Parameters.AddWithValue("@NomProf", sco.Nom);
            cmd.Parameters.AddWithValue("@PrenomProf", sco.Prenom);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteScolaire(Int32 code)
        {
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "DELETE FROM classes_scolaire WHERE code_scolaire=@codeScolaire";

            cmd.Parameters.AddWithValue("@codeScolaire", code);
            cmd.ExecuteNonQuery();
        }
    }
}
