﻿using System;
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
    public partial class frmListeLivres : Form
    {
        /// <summary>
        /// la section du livre gérée par ce form
        /// </summary>
        private MLivres leLivre;

        public frmListeLivres()
        {
            InitializeComponent();
            this.afficheLivres();
        }

        public void afficheLivres()
        {
            // détermine l'origine des données à afficher : appel de la méthode de la classe MLivres
            // qui alimente et retourne la copie de sa collection de livres sous forme de datatable
            this.grdLivres.DataSource = MLivres.ListerLivres(txtbRecherche.Text);
            // rafraîchit l'affichage
            this.grdLivres.Refresh();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNouveauLivre nouveauLivre = new frmNouveauLivre();
            if (nouveauLivre.ShowDialog() == DialogResult.OK)
            {
                afficheLivres();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // si un livre est pointé dans la datagridview
            if (this.grdLivres.CurrentRow != null)
            {
                // récupère la clé du livre pointé
                String cleLivre;
                cleLivre = (String)this.grdLivres.CurrentRow.Cells[0].Value;
                // demande confirmation de la suppression
                if (MessageBox.Show("Voulez-vous supprimer le livre numéro :" + cleLivre.ToString(), "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    MLivres.DeleteLivre(cleLivre.ToString());

                    // réaffiche la datagridview
                    afficheLivres();
                }
            }
        }

        /// <summary>
        /// ouvre la feuille détail en y affichant le livre correspondant à la ligne double-cliquée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdLivres_DoubleClick(object sender, EventArgs e)
        {
            String iLivre;
            iLivre = (String)this.grdLivres.CurrentRow.Cells[0].Value;

            leLivre = Donnees.Livres.RechercherLivres(iLivre) as MLivres;

            frmConsultationLivre frmConsulter = new frmConsultationLivre(leLivre);
            // affiche le form de consultation d'un livre
            frmConsulter.ShowDialog();
            // rafraichît la datagridview quand le form est fermé
            this.afficheLivres();
        }

        private void txtbRecherche_TextChanged(object sender, EventArgs e)
        {
            MLivres.ListerLivres(txtbRecherche.Text);
            afficheLivres();
        }
    }
}
