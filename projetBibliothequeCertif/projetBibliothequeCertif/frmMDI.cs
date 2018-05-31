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
        public frmMDI()
        {
            InitializeComponent();
        }

        private void quitterLapplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nouvelUsagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // on va instancier le form de saisie du nouveau client
            frmNouvelUsager nouvelUsager = new frmNouvelUsager();

            // affichage en modal et contrôle que l'utilisateur
            // en sort par OK
            if (nouvelUsager.ShowDialog() == DialogResult.OK)
            {
                // recherche rang du client saisi
                //this.iClient = MClients.NClients - 1;
            }
        }

        private void nouveauLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // on va instancier le form de saisie du nouveau client
            frmNouveauLivre nouveauLivre = new frmNouveauLivre();

            // affichage en modal et contrôle que l'utilisateur
            // en sort par OK
            if (nouveauLivre.ShowDialog() == DialogResult.OK)
            {
                // recherche rang du client saisi
                //this.iClient = MClients.NClients - 1;
            }
        }

        private void listeDesUsagersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeUsagers listeUsagers = new frmListeUsagers();
            listeUsagers.Show();
        }

        private void listeDesLivresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeLivres listeLivres = new frmListeLivres();
            listeLivres.Show();
        }
    }
}
