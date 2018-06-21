using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace projetBibliothequeCertif
{
    public partial class frmConsultationAdherent : projetBibliothequeCertif.frmAdherents
    {
        protected MPersonnes unAdherent;
        private MLivres unLivre;

        public frmConsultationAdherent(MPersonnes adherent)
        {
            this.unAdherent = adherent;
            InitializeComponent();
        }

        private void afficheLivres()
        {
            MLivres.SelectLivre(unLivre);

            // déterminer l'origine des données à afficher : 
            // appel de la méthode de la classe MLivres qui alimente et retourne copie de sa 
            // collection de livres sous forme de datatable
           // this.grdLivresEmpruntes.DataSource = unLivre.ListerLivres();
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
            frmNouveauLivre nouveauLivre = new frmNouveauLivre(unLivre);

            // Si on sort de la saisie par OK, régénère l'affichage du datagrid
            if (nouveauLivre.ShowDialog() == DialogResult.OK)
            {
                this.afficheLivres();
            }
            this.Close();
        }

        private void frmConsultationAdherent_Load(object sender, EventArgs e)
        {
          /*  DateTime myDateTime = DateTime.Parse(dateti.ToString());
            int totalDays = Convert.ToInt32((DateTime.UtcNow.Date - myDateTime.Date).TotalDays);
            MessageBox.Show("Vous avez cotisé il y a " + " jours");*/
            
        }
    }
}
