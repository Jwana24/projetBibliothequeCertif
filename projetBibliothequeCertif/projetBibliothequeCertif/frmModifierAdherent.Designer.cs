namespace projetBibliothequeCertif
{
    partial class frmModifierAdherent
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.grpCotisations.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbNom
            // 
            this.txtbNom.Location = new System.Drawing.Point(111, 78);
            // 
            // txtbPrenom
            // 
            this.txtbPrenom.Location = new System.Drawing.Point(111, 123);
            // 
            // txtbCodePostal
            // 
            this.txtbCodePostal.Location = new System.Drawing.Point(111, 174);
            // 
            // txtbVille
            // 
            this.txtbVille.Location = new System.Drawing.Point(462, 174);
            // 
            // txtbAdresse
            // 
            this.txtbAdresse.Location = new System.Drawing.Point(111, 224);
            // 
            // txtbComplAdresse
            // 
            this.txtbComplAdresse.Location = new System.Drawing.Point(202, 273);
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(111, 380);
            // 
            // txtbTelephone
            // 
            this.txtbTelephone.Location = new System.Drawing.Point(111, 436);
            // 
            // dateTimeInscription
            // 
            this.dateTimeInscription.Location = new System.Drawing.Point(202, 326);
            // 
            // lblNom
            // 
            this.lblNom.Location = new System.Drawing.Point(24, 78);
            // 
            // lblPrenom
            // 
            this.lblPrenom.Location = new System.Drawing.Point(24, 123);
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.Location = new System.Drawing.Point(24, 174);
            // 
            // lblVille
            // 
            this.lblVille.Location = new System.Drawing.Point(378, 174);
            // 
            // lblAdresse1
            // 
            this.lblAdresse1.Location = new System.Drawing.Point(24, 224);
            // 
            // lblAdresse2
            // 
            this.lblAdresse2.Location = new System.Drawing.Point(24, 273);
            // 
            // lblDateInscription
            // 
            this.lblDateInscription.Location = new System.Drawing.Point(24, 326);
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(24, 380);
            // 
            // lblTelephone
            // 
            this.lblTelephone.Location = new System.Drawing.Point(24, 436);
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.Location = new System.Drawing.Point(24, 486);
            // 
            // dateTimeNaissance
            // 
            this.dateTimeNaissance.Location = new System.Drawing.Point(202, 486);
            // 
            // lblNumAdherent
            // 
            this.lblNumAdherent.Location = new System.Drawing.Point(24, 31);
            // 
            // txtbNumAdherent
            // 
            this.txtbNumAdherent.Location = new System.Drawing.Point(202, 31);
            // 
            // grpCotisations
            // 
            this.grpCotisations.Location = new System.Drawing.Point(550, 23);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(788, 540);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(85, 29);
            this.btnFermer.TabIndex = 26;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(718, 540);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(57, 29);
            this.btnOK.TabIndex = 28;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(550, 540);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(154, 29);
            this.btnEffacer.TabIndex = 34;
            this.btnEffacer.Text = "Effacer modifications";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // frmModifierAdherent
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(896, 586);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnFermer);
            this.Name = "frmModifierAdherent";
            this.Text = "Modifier l\'adhérent : ";
            this.Controls.SetChildIndex(this.grpCotisations, 0);
            this.Controls.SetChildIndex(this.lblNumAdherent, 0);
            this.Controls.SetChildIndex(this.txtbNumAdherent, 0);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnEffacer, 0);
            this.Controls.SetChildIndex(this.lblDateNaissance, 0);
            this.Controls.SetChildIndex(this.dateTimeNaissance, 0);
            this.Controls.SetChildIndex(this.lblNom, 0);
            this.Controls.SetChildIndex(this.lblPrenom, 0);
            this.Controls.SetChildIndex(this.lblCodePostal, 0);
            this.Controls.SetChildIndex(this.lblVille, 0);
            this.Controls.SetChildIndex(this.lblAdresse1, 0);
            this.Controls.SetChildIndex(this.lblAdresse2, 0);
            this.Controls.SetChildIndex(this.lblDateInscription, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.lblTelephone, 0);
            this.Controls.SetChildIndex(this.txtbNom, 0);
            this.Controls.SetChildIndex(this.txtbPrenom, 0);
            this.Controls.SetChildIndex(this.txtbCodePostal, 0);
            this.Controls.SetChildIndex(this.txtbVille, 0);
            this.Controls.SetChildIndex(this.txtbAdresse, 0);
            this.Controls.SetChildIndex(this.txtbComplAdresse, 0);
            this.Controls.SetChildIndex(this.txtbEmail, 0);
            this.Controls.SetChildIndex(this.txtbTelephone, 0);
            this.Controls.SetChildIndex(this.dateTimeInscription, 0);
            this.grpCotisations.ResumeLayout(false);
            this.grpCotisations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnEffacer;
    }
}
