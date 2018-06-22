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
            // on instancie le form de saisie du nouveau livre
            frmConsultationPersonne consulterPer = new frmConsultationPersonne(personne);
            // affichage en modal
            consulterPer.ShowDialog();
        }

        private void consultationScolaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultationScolaire consultersco = new frmConsultationScolaire();
            consultersco.ShowDialog();
        }

        private void consultationLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultationLivre consulterLvr = new frmConsultationLivre(unLivre);
            consulterLvr.ShowDialog();
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
