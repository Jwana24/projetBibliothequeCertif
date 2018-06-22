namespace projetBibliothequeCertif
{
    partial class frmConsultationLivre
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
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbCodeLivre
            // 
            this.txtbCodeLivre.Enabled = false;
            // 
            // txtbISBN
            // 
            this.txtbISBN.Enabled = false;
            // 
            // txtbTitre
            // 
            this.txtbTitre.Enabled = false;
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.Enabled = false;
            this.cbbCategorie.Size = new System.Drawing.Size(237, 24);
            // 
            // txtbAuteur
            // 
            this.txtbAuteur.Enabled = false;
            // 
            // txtbEditeur
            // 
            this.txtbEditeur.Enabled = false;
            // 
            // dateTimeSortie
            // 
            this.dateTimeSortie.Enabled = false;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(510, 407);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(89, 29);
            this.btnModifier.TabIndex = 26;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(626, 407);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(85, 29);
            this.btnFermer.TabIndex = 25;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmConsultationLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(758, 459);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnFermer);
            this.Name = "frmConsultationLivre";
            this.Text = "Consultation du livre";
            this.Load += new System.EventHandler(this.frmConsultationLivre_Load);
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
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.btnModifier, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnFermer;
    }
}
