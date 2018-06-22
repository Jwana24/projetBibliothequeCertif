namespace projetBibliothequeCertif
{
    partial class frmListePersonnes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListePersonnes));
            this.lblRecherche = new System.Windows.Forms.Label();
            this.grdPersonnes = new System.Windows.Forms.DataGridView();
            this.txtbRecherche = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonnes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(91, 35);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(77, 17);
            this.lblRecherche.TabIndex = 0;
            this.lblRecherche.Text = "Recherche";
            // 
            // grdPersonnes
            // 
            this.grdPersonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPersonnes.Location = new System.Drawing.Point(60, 81);
            this.grdPersonnes.Name = "grdPersonnes";
            this.grdPersonnes.RowTemplate.Height = 24;
            this.grdPersonnes.Size = new System.Drawing.Size(781, 279);
            this.grdPersonnes.TabIndex = 1;
            this.grdPersonnes.DoubleClick += new System.EventHandler(this.grdPersonnes_DoubleClick);
            // 
            // txtbRecherche
            // 
            this.txtbRecherche.Location = new System.Drawing.Point(198, 35);
            this.txtbRecherche.Name = "txtbRecherche";
            this.txtbRecherche.Size = new System.Drawing.Size(534, 22);
            this.txtbRecherche.TabIndex = 2;
            this.txtbRecherche.TextChanged += new System.EventHandler(this.txtbRecherche_TextChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(605, 384);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(127, 30);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter personne";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(748, 436);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(93, 30);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Double-clique pour ouvrir";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(445, 384);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(145, 30);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "Supprimer personne";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmListePersonnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 488);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtbRecherche);
            this.Controls.Add(this.grdPersonnes);
            this.Controls.Add(this.lblRecherche);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListePersonnes";
            this.Text = "Liste des personnes";
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.DataGridView grdPersonnes;
        private System.Windows.Forms.TextBox txtbRecherche;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSupprimer;
    }
}