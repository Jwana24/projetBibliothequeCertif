using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    public partial class frmConsultationAdherent : projetBibliothequeCertif.frmAdherents
    {
        public frmConsultationAdherent()
        {
            InitializeComponent();
        }

        private void btnModifierAdherent_Click(object sender, EventArgs e)
        {
            frmModifierAdherent modifierAdherent = new frmModifierAdherent();
            modifierAdherent.Show();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimerLivre_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterLivre_Click(object sender, EventArgs e)
        {

        }
    }
}
