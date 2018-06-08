namespace projetBibliothequeCertif
{
    partial class frmNouvelAdherent
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkAdultes = new System.Windows.Forms.CheckBox();
            this.chkScolaires = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtbNom
            // 
            this.txtbNom.Location = new System.Drawing.Point(111, 55);
            // 
            // txtbPrenom
            // 
            this.txtbPrenom.Location = new System.Drawing.Point(111, 100);
            // 
            // txtbCodePostal
            // 
            this.txtbCodePostal.Location = new System.Drawing.Point(111, 151);
            // 
            // txtbVille
            // 
            this.txtbVille.Location = new System.Drawing.Point(462, 151);
            // 
            // txtbAdresse
            // 
            this.txtbAdresse.Location = new System.Drawing.Point(111, 201);
            // 
            // txtbComplAdresse
            // 
            this.txtbComplAdresse.Location = new System.Drawing.Point(202, 250);
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(111, 344);
            // 
            // txtbTelephone
            // 
            this.txtbTelephone.Location = new System.Drawing.Point(111, 400);
            // 
            // dateTimeInscription
            // 
            this.dateTimeInscription.Location = new System.Drawing.Point(202, 300);
            // 
            // lblNom
            // 
            this.lblNom.Location = new System.Drawing.Point(24, 55);
            // 
            // lblPrenom
            // 
            this.lblPrenom.Location = new System.Drawing.Point(24, 100);
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.Location = new System.Drawing.Point(24, 151);
            // 
            // lblVille
            // 
            this.lblVille.Location = new System.Drawing.Point(378, 151);
            // 
            // lblAdresse1
            // 
            this.lblAdresse1.Location = new System.Drawing.Point(24, 201);
            // 
            // lblAdresse2
            // 
            this.lblAdresse2.Location = new System.Drawing.Point(24, 250);
            // 
            // lblDateInscription
            // 
            this.lblDateInscription.Location = new System.Drawing.Point(24, 300);
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(24, 344);
            // 
            // lblTelephone
            // 
            this.lblTelephone.Location = new System.Drawing.Point(24, 400);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(678, 499);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 29);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(597, 499);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(61, 29);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkAdultes
            // 
            this.chkAdultes.AutoSize = true;
            this.chkAdultes.Location = new System.Drawing.Point(202, 12);
            this.chkAdultes.Name = "chkAdultes";
            this.chkAdultes.Size = new System.Drawing.Size(76, 21);
            this.chkAdultes.TabIndex = 22;
            this.chkAdultes.Text = "adultes";
            this.chkAdultes.UseVisualStyleBackColor = true;
            // 
            // chkScolaires
            // 
            this.chkScolaires.AutoSize = true;
            this.chkScolaires.Location = new System.Drawing.Point(478, 12);
            this.chkScolaires.Name = "chkScolaires";
            this.chkScolaires.Size = new System.Drawing.Size(86, 21);
            this.chkScolaires.TabIndex = 24;
            this.chkScolaires.Text = "scolaires";
            this.chkScolaires.UseVisualStyleBackColor = true;
            // 
            // frmNouvelAdherent
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.chkScolaires);
            this.Controls.Add(this.chkAdultes);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "frmNouvelAdherent";
            this.Text = "Nouvel adhérent";
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.chkAdultes, 0);
            this.Controls.SetChildIndex(this.chkScolaires, 0);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkAdultes;
        private System.Windows.Forms.CheckBox chkScolaires;
    }
}
