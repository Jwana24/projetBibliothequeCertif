﻿using System;
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
        protected MAdherents unAdherent;
        private MLivres unLivre;

        public frmConsultationAdherent(MAdherents adherent)
        {
            this.unAdherent = adherent;
            InitializeComponent();
        }

        private void afficheLivres()
        {
            MLivres.SelectLivres(unLivre);

            // déterminer l'origine des données à afficher : 
            // appel de la méthode de la classe MLivres qui alimente et retourne copie de sa 
            // collection de livres sous forme de datatable
            this.grdLivresEmpruntes.DataSource = unLivre.ListerLivres();
            // refraîchir l'affichage
            this.grdLivresEmpruntes.Refresh();
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
            grdLivresEmpruntes.Rows.Remove(grdLivresEmpruntes.CurrentRow);
        }

        private void btnAjouterLivre_Click(object sender, EventArgs e)
        {
            frmNouveauLivre nouveauLivre = new frmNouveauLivre();

            // Si on sort de la saisie par OK, régénère l'affichage du datagrid
            if (nouveauLivre.ShowDialog() == DialogResult.OK)
            {
                this.afficheLivres();
            }
            this.Close();
        }

        private void frmConsultationAdherent_Load(object sender, EventArgs e)
        {
            /*if (dateTimeCotisations. > 1)
            {
                this.lblRetard.Visible = true;
            }*/
        }
    }
}
