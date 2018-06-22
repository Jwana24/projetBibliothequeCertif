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
            this.grdLivresEmpruntes = new System.Windows.Forms.DataGridView();
            this.lblLivresEmprunt = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnSupprimerLivre = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouterLivre = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpCotisations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivresEmpruntes)).BeginInit();
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
            // grdLivresEmpruntes
            // 
            this.grdLivresEmpruntes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLivresEmpruntes.Location = new System.Drawing.Point(27, 534);
            this.grdLivresEmpruntes.Name = "grdLivresEmpruntes";
            this.grdLivresEmpruntes.RowTemplate.Height = 24;
            this.grdLivresEmpruntes.Size = new System.Drawing.Size(842, 204);
            this.grdLivresEmpruntes.TabIndex = 18;
            // 
            // lblLivresEmprunt
            // 
            this.lblLivresEmprunt.AutoSize = true;
            this.lblLivresEmprunt.Location = new System.Drawing.Point(24, 515);
            this.lblLivresEmprunt.Name = "lblLivresEmprunt";
            this.lblLivresEmprunt.Size = new System.Drawing.Size(117, 17);
            this.lblLivresEmprunt.TabIndex = 19;
            this.lblLivresEmprunt.Text = "Livres empruntés";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(784, 795);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(85, 29);
            this.btnFermer.TabIndex = 22;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnSupprimerLivre
            // 
            this.btnSupprimerLivre.Location = new System.Drawing.Point(27, 755);
            this.btnSupprimerLivre.Name = "btnSupprimerLivre";
            this.btnSupprimerLivre.Size = new System.Drawing.Size(124, 29);
            this.btnSupprimerLivre.TabIndex = 23;
            this.btnSupprimerLivre.Text = "Supprimer livre";
            this.btnSupprimerLivre.UseVisualStyleBackColor = true;
            this.btnSupprimerLivre.Click += new System.EventHandler(this.btnSupprimerLivre_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(632, 401);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(132, 29);
            this.btnModifier.TabIndex = 24;
            this.btnModifier.Text = "Modifier personne";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouterLivre
            // 
            this.btnAjouterLivre.Location = new System.Drawing.Point(167, 755);
            this.btnAjouterLivre.Name = "btnAjouterLivre";
            this.btnAjouterLivre.Size = new System.Drawing.Size(101, 29);
            this.btnAjouterLivre.TabIndex = 25;
            this.btnAjouterLivre.Text = "Ajouter livre";
            this.btnAjouterLivre.UseVisualStyleBackColor = true;
            this.btnAjouterLivre.Click += new System.EventHandler(this.btnAjouterLivre_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(777, 401);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(55, 29);
            this.btnOk.TabIndex = 34;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // frmConsultationPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(905, 847);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAjouterLivre);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimerLivre);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblLivresEmprunt);
            this.Controls.Add(this.grdLivresEmpruntes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultationPersonne";
            this.Text = "Consultation de la personne";
            this.Load += new System.EventHandler(this.frmConsultationPersonne_Load);
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
            this.Controls.SetChildIndex(this.grdLivresEmpruntes, 0);
            this.Controls.SetChildIndex(this.lblLivresEmprunt, 0);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.btnSupprimerLivre, 0);
            this.Controls.SetChildIndex(this.btnModifier, 0);
            this.Controls.SetChildIndex(this.btnAjouterLivre, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.grpCotisations.ResumeLayout(false);
            this.grpCotisations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivresEmpruntes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdLivresEmpruntes;
        private System.Windows.Forms.Label lblLivresEmprunt;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnSupprimerLivre;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouterLivre;
        private System.Windows.Forms.Button btnOk;
    }
}
