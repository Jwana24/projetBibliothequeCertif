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

        public MScolaires (Int32 leCode, String uneVille, String uneEcole, String uneClasse, String unNom, String unPrenom, String unCP)
        {
            lesScolaires = new SortedDictionary<Int32, MScolaires>();

            this.Code = leCode;
            this.Ville = uneVille;
            this.Etablissement = uneEcole;
            this.Classe = uneClasse;
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.CodePostal = unCP;
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

        public String Etablissement
        {
            get { return etablissementScolaire; }
            set { etablissementScolaire = value.Trim().ToUpper(); }
        }

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

        public String Ville
        {
            get { return villeScolaire; }
            set { villeScolaire = value.Trim().ToUpper(); }
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

        public MScolaires RestituerScolaire(Int32 unCodeScolaire)
        {
            MScolaires unScolaire;
            unScolaire = this.lesScolaires[unCodeScolaire];
            if (unScolaire == null)
            {
                throw new Exception("Aucun scolaire pour le numéro " + unCodeScolaire.ToString());
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
            cmd.CommandText = "INSERT INTO classes_scolaire(code_scolaire, libelle, num_adherent, nom_ecole, cp, ville) " +
                "VALUES (@codeScolaire, @libelle, @numAdherent, @nomEcole, @cp, @ville)";

            cmd.Parameters.AddWithValue("@codeScolaire", sco.Code);
            cmd.Parameters.AddWithValue("@libelle", sco.Classe);
            cmd.Parameters.AddWithValue("@numAdherent", sco.NumAdherent);
            cmd.Parameters.AddWithValue("@nomEcole", sco.Etablissement);
            cmd.Parameters.AddWithValue("@cp", sco.CodePostal);
            cmd.Parameters.AddWithValue("@ville", sco.Ville);
            // exécute la requête
            cmd.ExecuteNonQuery();
        }

        public static void UpdateScolaire(MScolaires sco)
        {
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "UPDATE classes_scolaire SET libelle=@libelle WHERE num_adherent=@NumAdherent";

            cmd.Parameters.AddWithValue("@libelle", sco.Classe);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteScolaire(Int32 code)
        {
            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = "DELETE FROM classes-scolaire WHERE code_scolaire=@codeScolaire";

            cmd.Parameters.AddWithValue("@codeScolaire", code);
            cmd.ExecuteNonQuery();
        }
    }
}
