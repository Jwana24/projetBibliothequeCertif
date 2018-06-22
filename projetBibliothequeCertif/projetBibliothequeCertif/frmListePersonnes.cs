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
    public partial class frmListePersonnes : Form
    {
        private MPersonnes personne;

        public frmListePersonnes()
        {
            InitializeComponent();
            // affiche la liste des personnes de la section
            this.affichePersonnes();
        }

        public void affichePersonnes()
        {
            // déterminer l'origine des données à afficher : appel de la méthode de la classe MPersonnes qui alimente
            // et retourne une copie de sa collection des personnes sous forme de datatable
            this.grdPersonnes.DataSource = MPersonnes.ListerPersonnes(txtbRecherche.Text);
            // rafraîchit l'affichage
            this.grdPersonnes.Refresh();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNouvelAdherent nouvelAdherent = new frmNouvelAdherent();

            // si on sort de la saisie par le bouton OK, régénère l'affichage de la datagridview
            if (nouvelAdherent.ShowDialog() == DialogResult.OK)
            {
                this.affichePersonnes();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // si une personne est pointée dans la datagridview
            if (this.grdPersonnes.CurrentRow != null)
            {
                // récupère la clé de la personne pointée
                Int32 clePersonne;
                clePersonne = Int32.Parse(this.grdPersonnes.CurrentRow.Cells[0].Value.ToString());
                // demande confirmation de la suppression
                if (MessageBox.Show("Voulez-vous supprimer la personne numéro :" + clePersonne.ToString(), "Suppression", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MPersonnes.DeletePersonne(clePersonne);
                    // réaffiche la datagridview
                    affichePersonnes();
                }
            }
        }

        private void txtbRecherche_TextChanged(object sender, EventArgs e)
        {
            MPersonnes.ListerPersonnes(txtbRecherche.Text);
            affichePersonnes();
        }

        /// <summary>
        /// ouvre la feuille détail en y affichant la personne correspondant à la ligne double-cliquée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdPersonnes_DoubleClick(object sender, EventArgs e)
        {
            Int32 iPersonne;
            iPersonne = (Int32)this.grdPersonnes.CurrentRow.Cells[0].Value;

            personne = Donnees.Personnes.RechercherPersonnes(iPersonne) as MPersonnes;
            // instancie le form consultation personne
            frmConsultationPersonne frmConsulter = new frmConsultationPersonne(personne);
            // affiche le form de consultation d'une personne
            frmConsulter.ShowDialog();
            // rafraîchit la datagriedview quand le form est fermé
            this.affichePersonnes();


        }
    }
}