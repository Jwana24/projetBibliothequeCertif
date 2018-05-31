namespace projetBibliothequeCertif
{
    partial class frmConsultationUsager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblLivresEmprunt = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnSupprimerLivre = new System.Windows.Forms.Button();
            this.btnModifierUsager = new System.Windows.Forms.Button();
            this.btnAjouterLivre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 495);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 204);
            this.dataGridView1.TabIndex = 18;
            // 
            // lblLivresEmprunt
            // 
            this.lblLivresEmprunt.AutoSize = true;
            this.lblLivresEmprunt.Location = new System.Drawing.Point(24, 475);
            this.lblLivresEmprunt.Name = "lblLivresEmprunt";
            this.lblLivresEmprunt.Size = new System.Drawing.Size(117, 17);
            this.lblLivresEmprunt.TabIndex = 19;
            this.lblLivresEmprunt.Text = "Livres empruntés";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(668, 733);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(85, 29);
            this.btnFermer.TabIndex = 22;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnSupprimerLivre
            // 
            this.btnSupprimerLivre.Location = new System.Drawing.Point(27, 716);
            this.btnSupprimerLivre.Name = "btnSupprimerLivre";
            this.btnSupprimerLivre.Size = new System.Drawing.Size(124, 29);
            this.btnSupprimerLivre.TabIndex = 23;
            this.btnSupprimerLivre.Text = "Supprimer livre";
            this.btnSupprimerLivre.UseVisualStyleBackColor = true;
            this.btnSupprimerLivre.Click += new System.EventHandler(this.btnSupprimerLivre_Click);
            // 
            // btnModifierUsager
            // 
            this.btnModifierUsager.Location = new System.Drawing.Point(621, 403);
            this.btnModifierUsager.Name = "btnModifierUsager";
            this.btnModifierUsager.Size = new System.Drawing.Size(132, 29);
            this.btnModifierUsager.TabIndex = 24;
            this.btnModifierUsager.Text = "Modifier usager";
            this.btnModifierUsager.UseVisualStyleBackColor = true;
            this.btnModifierUsager.Click += new System.EventHandler(this.btnModifierUsager_Click);
            // 
            // btnAjouterLivre
            // 
            this.btnAjouterLivre.Location = new System.Drawing.Point(167, 716);
            this.btnAjouterLivre.Name = "btnAjouterLivre";
            this.btnAjouterLivre.Size = new System.Drawing.Size(101, 29);
            this.btnAjouterLivre.TabIndex = 25;
            this.btnAjouterLivre.Text = "Ajouter livre";
            this.btnAjouterLivre.UseVisualStyleBackColor = true;
            this.btnAjouterLivre.Click += new System.EventHandler(this.btnAjouterLivre_Click);
            // 
            // frmConsultationUsager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(789, 780);
            this.Controls.Add(this.btnAjouterLivre);
            this.Controls.Add(this.btnModifierUsager);
            this.Controls.Add(this.btnSupprimerLivre);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblLivresEmprunt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmConsultationUsager";
            this.Text = "Consultation de l\'usager";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.lblLivresEmprunt, 0);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.btnSupprimerLivre, 0);
            this.Controls.SetChildIndex(this.btnModifierUsager, 0);
            this.Controls.SetChildIndex(this.btnAjouterLivre, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblLivresEmprunt;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnSupprimerLivre;
        private System.Windows.Forms.Button btnModifierUsager;
        private System.Windows.Forms.Button btnAjouterLivre;
    }
}
