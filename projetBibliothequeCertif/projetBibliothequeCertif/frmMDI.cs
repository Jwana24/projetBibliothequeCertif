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
        private MPersonnes personne;

        public frmMDI()
        {
            InitializeComponent();
        }

        private void nouvelAdherentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // on instancie le form de saisie du nouvel adhérent
            frmNouvelAdherent nouvelPers = new frmNouvelAdherent();
            // affichage en modal
            nouvelPers.ShowDialog();
        }

        private void nouveauLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNouveauLivre nouveauLvr = new frmNouveauLivre();
            nouveauLvr.ShowDialog();
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

        private void quitterLapplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listeDesScolairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeScolaires listeScolaires = new frmListeScolaires();
            listeScolaires.Show();
        }
    }
}
