using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    public partial class frmConsultationLivre : projetBibliothequeCertif.frmLivres
    {
        public frmConsultationLivre()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            frmModifierLivre modifierLivre = new frmModifierLivre();
            modifierLivre.Show();
        }
    }
}
