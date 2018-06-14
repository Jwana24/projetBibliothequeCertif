namespace projetBibliothequeCertif
{
    partial class frmModifierLivre
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
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.Size = new System.Drawing.Size(237, 24);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(392, 409);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(154, 29);
            this.btnEffacer.TabIndex = 33;
            this.btnEffacer.Text = "Effacer modifications";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(558, 409);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(57, 29);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(626, 409);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(85, 29);
            this.btnFermer.TabIndex = 30;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmModifierLivre
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(758, 464);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnFermer);
            this.Name = "frmModifierLivre";
            this.Text = "Modifier le livre :";
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
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnEffacer, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnFermer;
    }
}
