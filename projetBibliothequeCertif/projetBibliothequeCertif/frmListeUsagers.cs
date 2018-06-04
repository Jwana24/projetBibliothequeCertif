using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    public partial class frmListeUsagers : Form
    {
        public frmListeUsagers()
        {
            InitializeComponent();
        }

        /// <summary>
        /// collection des stagiaires de cette section sous forme de dictionnaire trié
        /// </summary>
        private SortedDictionary<Int32, MUsagers> lesUsagers;

        /// <summary>
        /// datatable des stagiaires pour affichages en datagridview et pour exporter/importer en XML
        /// </summary>
        private DataTable dtUsagers;
        
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="leNum"></param>
        /// <param name="leNom"></param>
        public frmListeUsagers(String leNum, String leNom)
        {
            // initialise numéro et nom de la section
            this.NumUsager = leNum;
            this.Nom = leNom;
            // instancie un dictionnaire vide pour les usagers de cette section
            lesUsagers = new SortedDictionary<int, MUsagers>();
            // datatable : pour y copier les données usagers
            // et à fournir aux composants de présentation 
            dtUsagers = new DataTable();

            // ajout à la datatable de 3 colonnes personnalisées 
            this.dtUsagers.Columns.Add(new DataColumn("Numéro Usager", typeof(System.Int32)));
            this.dtUsagers.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            this.dtUsagers.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
        }

        /// <summary>
        /// générer et retourner une datatable qui liste les numéro, nom et prenom
        /// de tous les Usagers de la collection
        /// </summary>
        /// <returns></returns>
        public DataTable ListerUsagers()
        {
            // vider la datatable pour la régénérer
            this.dtUsagers.Clear();
            // boucle de remplissage de la datatable à partir de la collection
            foreach (MUsagers unUsager in this.lesUsagers.Values)
            {
                // instanciation datarow (=ligne datatable)
                DataRow dr;
                dr = this.dtUsagers.NewRow();
                // affectation des 3 colonnes
                dr[0] = unUsager.NumUsager;
                dr[1] = unUsager.Nom;
                dr[2] = unUsager.Prenom;
                // ajouter la ligne à la datatable
                this.dtUsagers.Rows.Add(dr);
            } // fin de boucle remplissage datatable
            // retourne la référence à la datatable
            return this.dtUsagers;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Ajouter(MUsagers unUsager)
        {
            this.lesUsagers.Add(unUsager.NumUsager, unUsager);
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (this.txtbRecherche != null)
            {
                ((DataView)(this.grdUsagers.DataSource)).RowFilter = "Nom like '%" + this.txtbRecherche.Text + "%'";
            }
        }

        private void btnTous_Click(object sender, EventArgs e)
        {
            // le bouton "tous" est grisé dès l'ouverture de la fenêtre
            this.btnTous.Enabled = false;
            // si l'utilisateur tape une recherche, le bouton "tous" est dégrisé
            if (this.txtbRecherche != null)
            {
                this.btnTous.Enabled = true;
            }
            // à partir du moment où il n'y a pas de recherche, tous les usagers sont affichés
            this.txtbRecherche.Text = null;
            ((DataView)(this.grdUsagers.DataSource)).RowFilter = null;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNouvelUsager nouvelUsager = new frmNouvelUsager();
            //rajouter le changement dans la dataTable

            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            grdUsagers.Rows.Remove(grdUsagers.CurrentRow);
        }
    }
}
