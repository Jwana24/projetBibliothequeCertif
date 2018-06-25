namespace projetBibliothequeCertif
{
    partial class frmConsultationPersonne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultationPersonne));
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpCotisations.SuspendLayout();
            this.grpScolarite.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbNom
            // 
            this.txtbNom.Enabled = false;
            // 
            // txtbPrenom
            // 
            this.txtbPrenom.Enabled = false;
            // 
            // txtbCodePostal
            // 
            this.txtbCodePostal.Enabled = false;
            // 
            // txtbVille
            // 
            this.txtbVille.Enabled = false;
            this.txtbVille.Size = new System.Drawing.Size(407, 22);
            // 
            // txtbAdresse
            // 
            this.txtbAdresse.Enabled = false;
            this.txtbAdresse.Size = new System.Drawing.Size(758, 22);
            // 
            // txtbEmail
            // 
            this.txtbEmail.Enabled = false;
            this.txtbEmail.Size = new System.Drawing.Size(758, 22);
            // 
            // txtbTelephone
            // 
            this.txtbTelephone.Enabled = false;
            // 
            // dateTimeInscription
            // 
            this.dateTimeInscription.Enabled = false;
            // 
            // dateTimeNaissance
            // 
            this.dateTimeNaissance.Enabled = false;
            // 
            // txtbNumPersonne
            // 
            this.txtbNumPersonne.Enabled = false;
            // 
            // grpScolarite
            // 
            this.grpScolarite.Location = new System.Drawing.Point(67, 53);
            this.grpScolarite.Visible = false;
            // 
            // cbbClasse
            // 
            this.cbbClasse.Size = new System.Drawing.Size(125, 24);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(784, 510);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(85, 29);
            this.btnFermer.TabIndex = 22;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(557, 510);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(132, 29);
            this.btnModifier.TabIndex = 24;
            this.btnModifier.Text = "Modifier personne";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(709, 510);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(55, 29);
            this.btnOk.TabIndex = 34;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmConsultationPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(905, 565);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnFermer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultationPersonne";
            this.Text = "Consultation de la personne";
            this.Load += new System.EventHandler(this.frmConsultationPersonne_Load);
            this.Controls.SetChildIndex(this.grpScolarite, 0);
            this.Controls.SetChildIndex(this.grpCotisations, 0);
            this.Controls.SetChildIndex(this.lblDateNaissance, 0);
            this.Controls.SetChildIndex(this.dateTimeNaissance, 0);
            this.Controls.SetChildIndex(this.lblNumPersonne, 0);
            this.Controls.SetChildIndex(this.txtbNumPersonne, 0);
            this.Controls.SetChildIndex(this.lblNom, 0);
            this.Controls.SetChildIndex(this.lblPrenom, 0);
            this.Controls.SetChildIndex(this.lblCodePostal, 0);
            this.Controls.SetChildIndex(this.lblVille, 0);
            this.Controls.SetChildIndex(this.lblAdresse1, 0);
            this.Controls.SetChildIndex(this.lblDateInscription, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.lblTelephone, 0);
            this.Controls.SetChildIndex(this.txtbNom, 0);
            this.Controls.SetChildIndex(this.txtbPrenom, 0);
            this.Controls.SetChildIndex(this.txtbCodePostal, 0);
            this.Controls.SetChildIndex(this.txtbVille, 0);
            this.Controls.SetChildIndex(this.txtbAdresse, 0);
            this.Controls.SetChildIndex(this.txtbEmail, 0);
            this.Controls.SetChildIndex(this.txtbTelephone, 0);
            this.Controls.SetChildIndex(this.dateTimeInscription, 0);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.btnModifier, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.grpCotisations.ResumeLayout(false);
            this.grpCotisations.PerformLayout();
            this.grpScolarite.ResumeLayout(false);
            this.grpScolarite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnOk;
    }
}
