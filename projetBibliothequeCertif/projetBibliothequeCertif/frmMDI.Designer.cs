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
            this.listeDesScolairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierStripMenuItem,
            this.fenetresStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fichierStripMenuItem
            // 
            resources.ApplyResources(this.fichierStripMenuItem, "fichierStripMenuItem");
            this.fichierStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelAdherentToolStripMenuItem,
            this.nouveauLivreToolStripMenuItem,
            this.quitterLapplicationToolStripMenuItem});
            this.fichierStripMenuItem.Name = "fichierStripMenuItem";
            // 
            // nouvelAdherentToolStripMenuItem
            // 
            resources.ApplyResources(this.nouvelAdherentToolStripMenuItem, "nouvelAdherentToolStripMenuItem");
            this.nouvelAdherentToolStripMenuItem.Name = "nouvelAdherentToolStripMenuItem";
            this.nouvelAdherentToolStripMenuItem.Click += new System.EventHandler(this.nouvelAdherentToolStripMenuItem_Click);
            // 
            // nouveauLivreToolStripMenuItem
            // 
            resources.ApplyResources(this.nouveauLivreToolStripMenuItem, "nouveauLivreToolStripMenuItem");
            this.nouveauLivreToolStripMenuItem.Name = "nouveauLivreToolStripMenuItem";
            this.nouveauLivreToolStripMenuItem.Click += new System.EventHandler(this.nouveauLivreToolStripMenuItem_Click);
            // 
            // quitterLapplicationToolStripMenuItem
            // 
            resources.ApplyResources(this.quitterLapplicationToolStripMenuItem, "quitterLapplicationToolStripMenuItem");
            this.quitterLapplicationToolStripMenuItem.Name = "quitterLapplicationToolStripMenuItem";
            this.quitterLapplicationToolStripMenuItem.Click += new System.EventHandler(this.quitterLapplicationToolStripMenuItem_Click_1);
            // 
            // fenetresStripMenuItem
            // 
            resources.ApplyResources(this.fenetresStripMenuItem, "fenetresStripMenuItem");
            this.fenetresStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesAdherentsToolStripMenuItem,
            this.listeDesScolairesToolStripMenuItem,
            this.listeDesLivresToolStripMenuItem});
            this.fenetresStripMenuItem.Name = "fenetresStripMenuItem";
            // 
            // listeDesAdherentsToolStripMenuItem
            // 
            resources.ApplyResources(this.listeDesAdherentsToolStripMenuItem, "listeDesAdherentsToolStripMenuItem");
            this.listeDesAdherentsToolStripMenuItem.Name = "listeDesAdherentsToolStripMenuItem";
            this.listeDesAdherentsToolStripMenuItem.Click += new System.EventHandler(this.listeDesAdherentsToolStripMenuItem_Click);
            // 
            // listeDesScolairesToolStripMenuItem
            // 
            resources.ApplyResources(this.listeDesScolairesToolStripMenuItem, "listeDesScolairesToolStripMenuItem");
            this.listeDesScolairesToolStripMenuItem.Name = "listeDesScolairesToolStripMenuItem";
            this.listeDesScolairesToolStripMenuItem.Click += new System.EventHandler(this.listeDesScolairesToolStripMenuItem_Click);
            // 
            // listeDesLivresToolStripMenuItem
            // 
            resources.ApplyResources(this.listeDesLivresToolStripMenuItem, "listeDesLivresToolStripMenuItem");
            this.listeDesLivresToolStripMenuItem.Name = "listeDesLivresToolStripMenuItem";
            this.listeDesLivresToolStripMenuItem.Click += new System.EventHandler(this.listeDesLivresToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.ShowIcon = false;
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
        private System.Windows.Forms.ToolStripMenuItem fenetresStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesAdherentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesScolairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterLapplicationToolStripMenuItem;
    }
}

