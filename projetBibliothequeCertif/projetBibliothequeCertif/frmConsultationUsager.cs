using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    public partial class frmConsultationUsager : projetBibliothequeCertif.frmUsagers
    {
        public frmConsultationUsager()
        {
            InitializeComponent();
        }

        private void btnModifierUsager_Click(object sender, EventArgs e)
        {
            frmModifierUsager modifierUsager = new frmModifierUsager();
            modifierUsager.Show();
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
