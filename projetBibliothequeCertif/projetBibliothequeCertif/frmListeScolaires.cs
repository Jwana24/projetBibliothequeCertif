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
    public partial class frmListeScolaires : Form
    {
        private MScolaires unScolaire;

        public frmListeScolaires()
        {
            InitializeComponent();
            this.afficheScolaires();
        }

        public void afficheScolaires()
        {
            // déterminer l'origine des données à afficher : appel de la méthode de la classe MScolaires qui alimente
            // et retourne une copie de sa collection des scolaires sous forme de datatable
            this.grdScolaires.DataSource = MScolaires.ListerScolaires(txtbRecherche.Text);
            // rafraîchit l'affichage
            this.grdScolaires.Refresh();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNouvelAdherent nouvelAdherent = new frmNouvelAdherent();

            // si on sort de la saisie par le bouton OK, régénère l'affichage de la datagridview
            if (nouvelAdherent.ShowDialog() == DialogResult.OK)
            {
                this.afficheScolaires();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // si un scolaire est pointé dans la datagridview
            if (this.grdScolaires.CurrentRow != null)
            {
                // récupère la clé du scolaire pointé
                Int32 cleScolaire;
                cleScolaire = (Int32)this.grdScolaires.CurrentRow.Cells[0].Value;
                // demande confirmation de la suppression
                if (MessageBox.Show("Voulez-vous supprimer le scolaire numéro :" + cleScolaire.ToString(), "Suppression", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MScolaires.DeleteScolaire(cleScolaire);
                    // réaffiche la datagridview
                    afficheScolaires();
                }
            }
        }
    }
}
