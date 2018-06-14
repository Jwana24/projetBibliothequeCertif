namespace projetBibliothequeCertif
{
    partial class frmNouveauLivre
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.Size = new System.Drawing.Size(237, 24);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(554, 416);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(61, 29);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(636, 416);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 29);
            this.btnAnnuler.TabIndex = 22;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmNouveauLivre
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(758, 476);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "frmNouveauLivre";
            this.Text = "Nouveau livre";
            this.Controls.SetChildIndex(this.lblCodeLivre, 0);
            this.Controls.SetChildIndex(this.lblQrCode, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.lblCategorie, 0);
            this.Controls.SetChildIndex(this.lblAuteur, 0);
            this.Controls.SetChildIndex(this.lblEditeur, 0);
            this.Controls.SetChildIndex(this.lblDateParution, 0);
            this.Controls.SetChildIndex(this.txtbCodeLivre, 0);
            this.Controls.SetChildIndex(this.txtbISBN, 0);
            this.Controls.SetChildIndex(this.txtbTitre, 0);
            this.Controls.SetChildIndex(this.cbbCategorie, 0);
            this.Controls.SetChildIndex(this.txtbAuteur, 0);
            this.Controls.SetChildIndex(this.txtbEditeur, 0);
            this.Controls.SetChildIndex(this.dateTimeSortie, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
