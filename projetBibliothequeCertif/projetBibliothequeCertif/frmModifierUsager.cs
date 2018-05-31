using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetBibliothequeCertif
{
    public partial class frmModifierUsager : projetBibliothequeCertif.frmUsagers
    {
        public frmModifierUsager()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmModifierUsager modifierUsager = new frmModifierUsager();
            this.Close();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {

        }
    }
}
