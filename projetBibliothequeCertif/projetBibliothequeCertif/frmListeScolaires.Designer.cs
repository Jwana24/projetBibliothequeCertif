namespace projetBibliothequeCertif
{
    partial class frmListeScolaires
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeScolaires));
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtbRecherche = new System.Windows.Forms.TextBox();
            this.grdScolaires = new System.Windows.Forms.DataGridView();
            this.lblRecherche = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdScolaires)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(453, 388);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(141, 30);
            this.btnSupprimer.TabIndex = 23;
            this.btnSupprimer.Text = "Supprimer scolaire";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Double-clique pour ouvrir";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(746, 454);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(93, 30);
            this.btnFermer.TabIndex = 21;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(611, 388);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(118, 30);
            this.btnAjouter.TabIndex = 20;
            this.btnAjouter.Text = "Ajouter scolaire";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtbRecherche
            // 
            this.txtbRecherche.Location = new System.Drawing.Point(196, 41);
            this.txtbRecherche.Name = "txtbRecherche";
            this.txtbRecherche.Size = new System.Drawing.Size(533, 22);
            this.txtbRecherche.TabIndex = 19;
            // 
            // grdScolaires
            // 
            this.grdScolaires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdScolaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdScolaires.Location = new System.Drawing.Point(58, 87);
            this.grdScolaires.Name = "grdScolaires";
            this.grdScolaires.RowTemplate.Height = 24;
            this.grdScolaires.Size = new System.Drawing.Size(781, 279);
            this.grdScolaires.TabIndex = 18;
            this.grdScolaires.DoubleClick += new System.EventHandler(this.grdScolaires_DoubleClick);
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(89, 41);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(77, 17);
            this.lblRecherche.TabIndex = 17;
            this.lblRecherche.Text = "Recherche";
            // 
            // frmListeScolaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 519);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtbRecherche);
            this.Controls.Add(this.grdScolaires);
            this.Controls.Add(this.lblRecherche);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListeScolaires";
            this.Text = "Liste des scolaires";
            ((System.ComponentModel.ISupportInitialize)(this.grdScolaires)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtbRecherche;
        private System.Windows.Forms.DataGridView grdScolaires;
        private System.Windows.Forms.Label lblRecherche;
    }
}