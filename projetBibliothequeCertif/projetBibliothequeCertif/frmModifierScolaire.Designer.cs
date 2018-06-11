namespace projetBibliothequeCertif
{
    partial class frmModifierScolaire
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(744, 375);
            // 
            // txtbPrenomProf
            // 
            this.txtbPrenomProf.Location = new System.Drawing.Point(247, 313);
            // 
            // txtbNomProf
            // 
            this.txtbNomProf.Location = new System.Drawing.Point(247, 256);
            // 
            // lblPrenomProf
            // 
            this.lblPrenomProf.Location = new System.Drawing.Point(57, 313);
            // 
            // lblNomProf
            // 
            this.lblNomProf.Location = new System.Drawing.Point(57, 256);
            // 
            // txtbVilleEcole
            // 
            this.txtbVilleEcole.Location = new System.Drawing.Point(138, 98);
            // 
            // lblVilleEcole
            // 
            this.lblVilleEcole.Location = new System.Drawing.Point(57, 98);
            // 
            // cbbClasse
            // 
            this.cbbClasse.Location = new System.Drawing.Point(138, 198);
            this.cbbClasse.Size = new System.Drawing.Size(125, 24);
            // 
            // txtbEcole
            // 
            this.txtbEcole.Location = new System.Drawing.Point(247, 147);
            // 
            // lblClasse
            // 
            this.lblClasse.Location = new System.Drawing.Point(54, 201);
            // 
            // lblEcole
            // 
            this.lblEcole.Location = new System.Drawing.Point(54, 147);
            // 
            // txtbCodeSco
            // 
            this.txtbCodeSco.Location = new System.Drawing.Point(247, 50);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(57, 50);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(447, 453);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(154, 29);
            this.btnEffacer.TabIndex = 37;
            this.btnEffacer.Text = "Effacer modifications";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(615, 453);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(57, 29);
            this.btnOK.TabIndex = 36;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(685, 453);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(85, 29);
            this.btnFermer.TabIndex = 35;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmModifierScolaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnFermer);
            this.Name = "frmModifierScolaire";
            this.Text = "Modifier les scolaires";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnEffacer, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnFermer;
    }
}
