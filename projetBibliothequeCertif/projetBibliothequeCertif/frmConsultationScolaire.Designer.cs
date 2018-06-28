namespace projetBibliothequeCertif
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpScolarite.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpScolarite
            // 
            this.grpScolarite.Location = new System.Drawing.Point(28, 17);
            this.grpScolarite.Size = new System.Drawing.Size(744, 383);
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
            // 
            // lblClasse
            // 
            this.lblClasse.Location = new System.Drawing.Point(57, 189);
            // 
            // lblEcole
            // 
            this.lblEcole.Location = new System.Drawing.Point(57, 140);
            // 
            // dateTimeInscSco
            // 
            this.dateTimeInscSco.Enabled = false;
            this.dateTimeInscSco.Location = new System.Drawing.Point(247, 335);
            // 
            // lblDateInscr
            // 
            this.lblDateInscr.Location = new System.Drawing.Point(57, 334);
            // 
            // txtbCP
            // 
            this.txtbCP.Enabled = false;
            // 
            // btnModifierScolaire
            // 
            this.btnModifierScolaire.Location = new System.Drawing.Point(454, 422);
            this.btnModifierScolaire.Name = "btnModifierScolaire";
            this.btnModifierScolaire.Size = new System.Drawing.Size(132, 29);
            this.btnModifierScolaire.TabIndex = 27;
            this.btnModifierScolaire.Text = "Modifier scolaire";
            this.btnModifierScolaire.UseVisualStyleBackColor = true;
            this.btnModifierScolaire.Click += new System.EventHandler(this.btnModifierScolaire_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(687, 422);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(85, 29);
            this.btnFermer.TabIndex = 30;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(610, 422);
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
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnModifierScolaire);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultationScolaire";
            this.Text = "Consultation du scolaire";
            this.Load += new System.EventHandler(this.frmConsultationScolaire_Load);
            this.Controls.SetChildIndex(this.grpScolarite, 0);
            this.Controls.SetChildIndex(this.btnModifierScolaire, 0);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.grpScolarite.ResumeLayout(false);
            this.grpScolarite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifierScolaire;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnOk;
    }
}
