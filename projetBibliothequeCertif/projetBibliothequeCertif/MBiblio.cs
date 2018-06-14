using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace projetBibliothequeCertif
{
    public class MBiblio
    {
        /// <summary>
        /// collection des objets MLivres
        /// </summary>
        private SortedDictionary<String, MLivres> lesLivres;

        /// <summary>
        /// DataTable à 2 colonnes pour restituer la liste des livres
        /// </summary>
        private DataTable dtLivres;

        /// <summary>
        /// constructeur par défaut
        /// (initialise la collection et le datatable)
        /// </summary>
        public MBiblio()
        {
            // instancie la collection 
            lesLivres = new SortedDictionary<string, MLivres>();

            // prépare la DataTable pour restituer la liste des livres
            dtLivres = new DataTable();

            // ajoute à la datatable 2 colonnes personnalisées 
            this.dtLivres.Columns.Add(new DataColumn("Code livre", typeof(System.String)));
            this.dtLivres.Columns.Add(new DataColumn("Titre livre", typeof(System.String)));
        }

        /// <summary>
        /// ajouter un livre à la collection
        /// (reçoit la référence au livre et en déduit la clé (= codeLivre) pour la collection)
        /// </summary>
        /// <param name="unLivre">la référence du livre à ajouter</param>
        public void Ajouter(MLivres unLivre)
        {
            this.lesLivres.Add(unLivre.CodeLivre, unLivre);
        }

        /// <summary>
        /// supprimer un livre de la collection
        /// (reçoit la clé du livre (= codeLivre) pour la collection)
        /// </summary>
        /// <param name="unCodeLivre">la clé (= codeLivre) du livre à supprimer</param>
        /// <exception cref="Exception">Si codeLivre reçu non trouvé en collection</exception>
        public void Supprimer(String unCodeLivre)
        {
            // suppression sécurisée
            if (this.lesLivres.ContainsKey(unCodeLivre))
            {
                this.lesLivres.Remove(unCodeLivre);
            }
            else
            {
                throw new Exception("Erreur : code livre non trouvé dans la collection");
            }
        }

        /// <summary>
        /// modifier les données d'un livre
        /// tout est modifiable sauf le codeLivre (= clé de la collection)
        /// </summary>
        /// <param name="unLivre">la référence au nouvel objet MLivres pour cette clé</param>
        public void Remplacer(MLivres unLivre)
        {
            // modifie la référence du livre stockée dans la collection            
            this.lesLivres[unLivre.CodeLivre] = unLivre;
        }

        /// <summary>
        /// Rechercher un livre dans la liste en connaissant sa clé
        /// </summary>
        /// <param name="unCodeLivre">le codeLivre (=la clé) du livre à rechercher</param>
        /// <exception cref="Exception">Si codeLivre reçu non trouvé en collection</exception>
        /// <returns>la référence à un livre</returns>
        public MLivres RestituerSection(String unCodeLivre)
        {
            MLivres leLivre;
            leLivre = this.lesLivres[unCodeLivre] as MLivres;
            if (leLivre == null)
            {
                throw new Exception("Aucun livre trouvé pour le code livre " + unCodeLivre);
            }
            else
            {
                return leLivre;
            }
        }

        // <summary>
        /// générer et retourner une datatable
        /// qui liste les codeLivre et titreLivre
        /// de tous les livres de la collection
        /// </summary>
        /// <returns>une référence de datatable à 2 colonnes</returns>
        public DataTable ListerLivres()
        {
            // ligne de la datatable
            DataRow dr;
            // vide la datatable pour la régénérer
            this.dtLivres.Clear();
            // boucle de remplissage de la datatable à partir de la collection
            foreach (MLivres unLivre in this.lesLivres.Values)
            {
                // instanciation de la datarow (=ligne)
                dr = this.dtLivres.NewRow();
                // affectation des 2 colonnes
                // récupère le valeur de la clé
                dr[0] = unLivre.CodeLivre;
                // affecte l'autre colonne des valeurs de propriété de l'objet MLivres
                dr[1] = unLivre.Titre;
                // ajoute la ligne à la datatable
                this.dtLivres.Rows.Add(dr);
            } // fin de la boucle de remplissage de la datatable
            // retourne la référence à la datatable
            return this.dtLivres;
        }

        public void SupprimerLivres()
        {
            this.lesLivres.Clear();
        }

        public static void SelectLivre(MBiblio livres)
        {
            string query = "SELECT * FROM livres";
            livres.SupprimerLivres();

            MySqlCommand cmd = ConnexionBase.GetConnexion().CreateCommand();
            cmd.CommandText = query;

            // crée un dataReader et exécute la commande
            MySqlDataReader dataReader = cmd.ExecuteReader();

            // lit les données et les stocks dans la liste
            while (dataReader.Read())
            {
                // MAdherent nouvelAdherent;
                Console.WriteLine(dataReader["date_inscription"].ToString());
                Console.Read();

                if (dataReader["date_inscription"].ToString() != "")
                {

                    MLivres nvlAdherent = new MLivres(
                    dataReader["code"].ToString(),
                    dataReader["isbn"].ToString(),
                    dataReader["titre"].ToString(),
                    dataReader["auteur"].ToString(),
                    dataReader["editeur"].ToString(),
                    DateTime.ParseExact(dataReader["date_sortie"].ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture),
                    int.Parse(dataReader["id_section"].ToString()));

                    // ajout du nouvel adhérent à la liste de livres
                    livres.Ajouter(nvlAdherent);
                    nvlAdherent = null;
                }
                else
                {
                    MLivres nvlAdherent = new MLivres(
                    dataReader["code"].ToString(),
                    dataReader["titre"].ToString(),
                    int.Parse(dataReader["id_section"].ToString()));

                    // ajout du nouvel adhérent à la liste de livres
                    livres.Ajouter(nvlAdherent);
                    nvlAdherent = null;
                }
            }
            // ferme le dataReader
            dataReader.Close();
        }
    }
}
