﻿namespace projetBibliothequeCertif
{
    partial class frmConsultationScolaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultationScolaire));
            this.btnModifierScolaire = new System.Windows.Forms.Button();
            this.btnAjouterLivre = new System.Windows.Forms.Button();
            this.btnSupprimerLivre = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblLivresEmprunt = new System.Windows.Forms.Label();
            this.grdLivresEmpruntes = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpScolarite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivresEmpruntes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.grpScolarite.Location = new System.Drawing.Point(28, 17);
            this.grpScolarite.Size = new System.Drawing.Size(744, 328);
            // 
            // txtbPrenomProf
            // 
            this.txtbPrenomProf.Enabled = false;
            this.txtbPrenomProf.Location = new System.Drawing.Point(247, 287);
            // 
            // txtbNomProf
            // 
            this.txtbNomProf.Enabled = false;
            this.txtbNomProf.Location = new System.Drawing.Point(247, 239);
            // 
            // lblPrenomProf
            // 
            this.lblPrenomProf.Location = new System.Drawing.Point(57, 287);
            // 
            // lblNomProf
            // 
            this.lblNomProf.Location = new System.Drawing.Point(57, 239);
            // 
            // txtbVilleEcole
            // 
            this.txtbVilleEcole.Enabled = false;
            this.txtbVilleEcole.Location = new System.Drawing.Point(140, 92);
            // 
            // lblVilleEcole
            // 
            this.lblVilleEcole.Location = new System.Drawing.Point(57, 92);
            // 
            // cbbClasse
            // 
            this.cbbClasse.Enabled = false;
            this.cbbClasse.Location = new System.Drawing.Point(138, 189);
            this.cbbClasse.Size = new System.Drawing.Size(125, 24);
            // 
            // txtbEcole
            // 
            this.txtbEcole.Enabled = false;
            this.txtbEcole.Location = new System.Drawing.Point(247, 140);
            // 
            // lblClasse
            // 
            this.lblClasse.Location = new System.Drawing.Point(57, 189);
            // 
            // lblEcole
            // 
            this.lblEcole.Location = new System.Drawing.Point(57, 140);
            // 
            // txtbCodeSco
            // 
            this.txtbCodeSco.Enabled = false;
            this.txtbCodeSco.Location = new System.Drawing.Point(247, 41);
            this.txtbCodeSco.Size = new System.Drawing.Size(213, 22);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(57, 41);
            // 
            // btnModifierScolaire
            // 
            this.btnModifierScolaire.Location = new System.Drawing.Point(495, 351);
            this.btnModifierScolaire.Name = "btnModifierScolaire";
            this.btnModifierScolaire.Size = new System.Drawing.Size(132, 29);
            this.btnModifierScolaire.TabIndex = 27;
            this.btnModifierScolaire.Text = "Modifier scolaire";
            this.btnModifierScolaire.UseVisualStyleBackColor = true;
            this.btnModifierScolaire.Click += new System.EventHandler(this.btnModifierScolaire_Click);
            // 
            // btnAjouterLivre
            // 
            this.btnAjouterLivre.Location = new System.Drawing.Point(168, 617);
            this.btnAjouterLivre.Name = "btnAjouterLivre";
            this.btnAjouterLivre.Size = new System.Drawing.Size(101, 29);
            this.btnAjouterLivre.TabIndex = 32;
            this.btnAjouterLivre.Text = "Ajouter livre";
            this.btnAjouterLivre.UseVisualStyleBackColor = true;
            this.btnAjouterLivre.Click += new System.EventHandler(this.btnAjouterLivre_Click);
            // 
            // btnSupprimerLivre
            // 
            this.btnSupprimerLivre.Location = new System.Drawing.Point(28, 617);
            this.btnSupprimerLivre.Name = "btnSupprimerLivre";
            this.btnSupprimerLivre.Size = new System.Drawing.Size(124, 29);
            this.btnSupprimerLivre.TabIndex = 31;
            this.btnSupprimerLivre.Text = "Supprimer livre";
            this.btnSupprimerLivre.UseVisualStyleBackColor = true;
            this.btnSupprimerLivre.Click += new System.EventHandler(this.btnSupprimerLivre_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(687, 644);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(85, 29);
            this.btnFermer.TabIndex = 30;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblLivresEmprunt
            // 
            this.lblLivresEmprunt.AutoSize = true;
            this.lblLivresEmprunt.Location = new System.Drawing.Point(25, 385);
            this.lblLivresEmprunt.Name = "lblLivresEmprunt";
            this.lblLivresEmprunt.Size = new System.Drawing.Size(117, 17);
            this.lblLivresEmprunt.TabIndex = 29;
            this.lblLivresEmprunt.Text = "Livres empruntés";
            // 
            // grdLivresEmpruntes
            // 
            this.grdLivresEmpruntes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLivresEmpruntes.Location = new System.Drawing.Point(28, 405);
            this.grdLivresEmpruntes.Name = "grdLivresEmpruntes";
            this.grdLivresEmpruntes.RowTemplate.Height = 24;
            this.grdLivresEmpruntes.Size = new System.Drawing.Size(744, 204);
            this.grdLivresEmpruntes.TabIndex = 28;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(643, 351);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(55, 29);
            this.btnOk.TabIndex = 33;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmConsultationScolaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 685);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAjouterLivre);
            this.Controls.Add(this.btnSupprimerLivre);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblLivresEmprunt);
            this.Controls.Add(this.grdLivresEmpruntes);
            this.Controls.Add(this.btnModifierScolaire);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultationScolaire";
            this.Text = "Consultation des scolaires";
            this.Controls.SetChildIndex(this.grpScolarite, 0);
            this.Controls.SetChildIndex(this.btnModifierScolaire, 0);
            this.Controls.SetChildIndex(this.grdLivresEmpruntes, 0);
            this.Controls.SetChildIndex(this.lblLivresEmprunt, 0);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.btnSupprimerLivre, 0);
            this.Controls.SetChildIndex(this.btnAjouterLivre, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.grpScolarite.ResumeLayout(false);
            this.grpScolarite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivresEmpruntes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifierScolaire;
        private System.Windows.Forms.Button btnAjouterLivre;
        private System.Windows.Forms.Button btnSupprimerLivre;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblLivresEmprunt;
        private System.Windows.Forms.DataGridView grdLivresEmpruntes;
        private System.Windows.Forms.Button btnOk;
    }
}
