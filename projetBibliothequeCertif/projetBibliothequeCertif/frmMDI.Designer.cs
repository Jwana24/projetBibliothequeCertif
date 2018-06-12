namespace projetBibliothequeCertif
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelAdherentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterLapplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenetresStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesAdherentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierStripMenuItem,
            this.fenetresStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierStripMenuItem
            // 
            this.fichierStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelAdherentToolStripMenuItem,
            this.nouveauLivreToolStripMenuItem,
            this.quitterLapplicationToolStripMenuItem});
            this.fichierStripMenuItem.Name = "fichierStripMenuItem";
            this.fichierStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierStripMenuItem.Text = "Fichier";
            // 
            // nouvelAdherentToolStripMenuItem
            // 
            this.nouvelAdherentToolStripMenuItem.Name = "nouvelAdherentToolStripMenuItem";
            this.nouvelAdherentToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.nouvelAdherentToolStripMenuItem.Text = "Nouvel adhérent";
            this.nouvelAdherentToolStripMenuItem.Click += new System.EventHandler(this.nouvelAdherentToolStripMenuItem_Click);
            // 
            // nouveauLivreToolStripMenuItem
            // 
            this.nouveauLivreToolStripMenuItem.Name = "nouveauLivreToolStripMenuItem";
            this.nouveauLivreToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.nouveauLivreToolStripMenuItem.Text = "Nouveau livre";
            this.nouveauLivreToolStripMenuItem.Click += new System.EventHandler(this.nouveauLivreToolStripMenuItem_Click);
            // 
            // quitterLapplicationToolStripMenuItem
            // 
            this.quitterLapplicationToolStripMenuItem.Name = "quitterLapplicationToolStripMenuItem";
            this.quitterLapplicationToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.quitterLapplicationToolStripMenuItem.Text = "Quitter l\'application";
            this.quitterLapplicationToolStripMenuItem.Click += new System.EventHandler(this.quitterLapplicationToolStripMenuItem_Click);
            // 
            // fenetresStripMenuItem
            // 
            this.fenetresStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesAdherentsToolStripMenuItem,
            this.listeDesLivresToolStripMenuItem});
            this.fenetresStripMenuItem.Name = "fenetresStripMenuItem";
            this.fenetresStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.fenetresStripMenuItem.Text = "Fenêtres";
            // 
            // listeDesAdherentsToolStripMenuItem
            // 
            this.listeDesAdherentsToolStripMenuItem.Name = "listeDesAdherentsToolStripMenuItem";
            this.listeDesAdherentsToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.listeDesAdherentsToolStripMenuItem.Text = "Liste des adhérents";
            this.listeDesAdherentsToolStripMenuItem.Click += new System.EventHandler(this.listeDesAdherentsToolStripMenuItem_Click);
            // 
            // listeDesLivresToolStripMenuItem
            // 
            this.listeDesLivresToolStripMenuItem.Name = "listeDesLivresToolStripMenuItem";
            this.listeDesLivresToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.listeDesLivresToolStripMenuItem.Text = "Liste des livres";
            this.listeDesLivresToolStripMenuItem.Click += new System.EventHandler(this.listeDesLivresToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(918, 596);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.ShowIcon = false;
            this.Text = "Logiciel de gestion de bibliothèque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelAdherentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterLapplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenetresStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesAdherentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesLivresToolStripMenuItem;
    }
}

