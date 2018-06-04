namespace projetBibliothequeCertif
{
    partial class frmNouvelUsager
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
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(678, 458);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 29);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(597, 458);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(61, 29);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmNouvelUsager
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "frmNouvelUsager";
            this.Text = "Nouvel usager";
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
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;
    }
}
