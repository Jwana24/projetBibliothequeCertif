using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    public partial class frmModifierAdherent : projetBibliothequeCertif.frmAdherents
    {
        public frmModifierAdherent()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmModifierAdherent modifierAdherent = new frmModifierAdherent();
            this.Close();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {

        }
    }
}
