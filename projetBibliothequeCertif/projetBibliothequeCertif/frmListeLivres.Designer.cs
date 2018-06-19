namespace projetBibliothequeCertif
{
    partial class frmListeLivres
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtbRecherche = new System.Windows.Forms.TextBox();
            this.grdLivres = new System.Windows.Forms.DataGridView();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Double-clique pour ouvrir";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(757, 442);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(93, 30);
            this.btnFermer.TabIndex = 14;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(622, 376);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(118, 30);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Ajouter livre";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtbRecherche
            // 
            this.txtbRecherche.Location = new System.Drawing.Point(207, 29);
            this.txtbRecherche.Name = "txtbRecherche";
            this.txtbRecherche.Size = new System.Drawing.Size(533, 22);
            this.txtbRecherche.TabIndex = 10;
            this.txtbRecherche.TextChanged += new System.EventHandler(this.txtbRecherche_TextChanged);
            // 
            // grdLivres
            // 
            this.grdLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLivres.Location = new System.Drawing.Point(69, 75);
            this.grdLivres.Name = "grdLivres";
            this.grdLivres.RowTemplate.Height = 24;
            this.grdLivres.Size = new System.Drawing.Size(781, 279);
            this.grdLivres.TabIndex = 9;
            this.grdLivres.DoubleClick += new System.EventHandler(this.grdLivres_DoubleClick);
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(100, 29);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(77, 17);
            this.lblRecherche.TabIndex = 8;
            this.lblRecherche.Text = "Recherche";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(492, 376);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(113, 30);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer livre";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmListeLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 502);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtbRecherche);
            this.Controls.Add(this.grdLivres);
            this.Controls.Add(this.lblRecherche);
            this.KeyPreview = true;
            this.Name = "frmListeLivres";
            this.Text = "Liste des livres";
            ((System.ComponentModel.ISupportInitialize)(this.grdLivres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtbRecherche;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridView grdLivres;
    }
}