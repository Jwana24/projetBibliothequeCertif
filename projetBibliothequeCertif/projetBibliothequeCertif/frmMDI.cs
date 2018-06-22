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
    public partial class frmMDI : Form
    {
        private MLivres unLivre;
        private MPersonnes personne;

        public frmMDI()
        {
            InitializeComponent();
        }

        private void quitterLapplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultationPersonneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // on va instancier le form de saisie du nouveau client
            frmConsultationPersonne consulterPer = new frmConsultationPersonne(personne);

            // affichage en modal et contrôle que l'utilisateur
            // en sort par OK
            if (consulterPer.ShowDialog() == DialogResult.OK)
            {
                // recherche rang de l'adhérent saisi
                //this.iClient = MClients.NClients - 1;
            }
        }

        private void consultationLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // on va instancier le form de saisie du nouveau client
            frmConsultationLivre consulterLvr = new frmConsultationLivre(unLivre);

            // affichage en modal et contrôle que l'utilisateur
            // en sort par OK
            if (consulterLvr.ShowDialog() == DialogResult.OK)
            {
                // recherche rang du client saisi
                //this.iClient = MClients.NClients - 1;
            }
        }

        private void listeDesAdherentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListePersonnes listeAdherents = new frmListePersonnes();
            listeAdherents.Show();
        }

        private void listeDesLivresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeLivres listeLivres = new frmListeLivres();
            listeLivres.Show();
        }
    }
}
