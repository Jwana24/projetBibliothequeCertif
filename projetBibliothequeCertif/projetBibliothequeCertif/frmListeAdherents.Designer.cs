namespace projetBibliothequeCertif
{
    partial class frmListeAdherents
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
            this.lblRecherche = new System.Windows.Forms.Label();
            this.grdAdherents = new System.Windows.Forms.DataGridView();
            this.txtbRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnTous = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAdherents)).BeginInit();
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
            // grdAdherents
            // 
            this.grdAdherents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAdherents.Location = new System.Drawing.Point(60, 81);
            this.grdAdherents.Name = "grdAdherents";
            this.grdAdherents.RowTemplate.Height = 24;
            this.grdAdherents.Size = new System.Drawing.Size(781, 279);
            this.grdAdherents.TabIndex = 1;
            // 
            // txtbRecherche
            // 
            this.txtbRecherche.Location = new System.Drawing.Point(198, 35);
            this.txtbRecherche.Name = "txtbRecherche";
            this.txtbRecherche.Size = new System.Drawing.Size(391, 22);
            this.txtbRecherche.TabIndex = 2;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(632, 31);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(98, 30);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnTous
            // 
            this.btnTous.Enabled = false;
            this.btnTous.Location = new System.Drawing.Point(750, 31);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(62, 30);
            this.btnTous.TabIndex = 4;
            this.btnTous.Text = "Tous";
            this.btnTous.UseVisualStyleBackColor = true;
            this.btnTous.Click += new System.EventHandler(this.btnTous_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(605, 401);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(127, 30);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter adhérent";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(748, 401);
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
            this.btnSupprimer.Location = new System.Drawing.Point(477, 401);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(113, 30);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "Supprimer livre";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmListeAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 459);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnTous);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtbRecherche);
            this.Controls.Add(this.grdAdherents);
            this.Controls.Add(this.lblRecherche);
            this.Name = "frmListeAdherents";
            this.Text = "Liste des adhérents";
            ((System.ComponentModel.ISupportInitialize)(this.grdAdherents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.DataGridView grdAdherents;
        private System.Windows.Forms.TextBox txtbRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSupprimer;
    }
}