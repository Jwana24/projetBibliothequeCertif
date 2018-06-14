namespace projetBibliothequeCertif
{
    partial class frmLivres
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
            this.lblCodeLivre = new System.Windows.Forms.Label();
            this.lblQrCode = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblEditeur = new System.Windows.Forms.Label();
            this.lblDateParution = new System.Windows.Forms.Label();
            this.txtbCodeLivre = new System.Windows.Forms.TextBox();
            this.txtbISBN = new System.Windows.Forms.TextBox();
            this.txtbTitre = new System.Windows.Forms.TextBox();
            this.cbbCategorie = new System.Windows.Forms.ComboBox();
            this.txtbAuteur = new System.Windows.Forms.TextBox();
            this.txtbEditeur = new System.Windows.Forms.TextBox();
            this.dateTimeSortie = new System.Windows.Forms.DateTimePicker();
            this.lblIdLivre = new System.Windows.Forms.Label();
            this.txtbIdLivre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCodeLivre
            // 
            this.lblCodeLivre.AutoSize = true;
            this.lblCodeLivre.Location = new System.Drawing.Point(37, 84);
            this.lblCodeLivre.Name = "lblCodeLivre";
            this.lblCodeLivre.Size = new System.Drawing.Size(71, 17);
            this.lblCodeLivre.TabIndex = 0;
            this.lblCodeLivre.Text = "Code livre";
            // 
            // lblQrCode
            // 
            this.lblQrCode.AutoSize = true;
            this.lblQrCode.Location = new System.Drawing.Point(37, 133);
            this.lblQrCode.Name = "lblQrCode";
            this.lblQrCode.Size = new System.Drawing.Size(39, 17);
            this.lblQrCode.TabIndex = 1;
            this.lblQrCode.Text = "ISBN";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(37, 182);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(37, 17);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Titre";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(37, 232);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(69, 17);
            this.lblCategorie.TabIndex = 3;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(37, 283);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(68, 17);
            this.lblAuteur.TabIndex = 4;
            this.lblAuteur.Text = "Auteur(e)";
            // 
            // lblEditeur
            // 
            this.lblEditeur.AutoSize = true;
            this.lblEditeur.Location = new System.Drawing.Point(37, 333);
            this.lblEditeur.Name = "lblEditeur";
            this.lblEditeur.Size = new System.Drawing.Size(53, 17);
            this.lblEditeur.TabIndex = 5;
            this.lblEditeur.Text = "Editeur";
            // 
            // lblDateParution
            // 
            this.lblDateParution.AutoSize = true;
            this.lblDateParution.Location = new System.Drawing.Point(37, 384);
            this.lblDateParution.Name = "lblDateParution";
            this.lblDateParution.Size = new System.Drawing.Size(114, 17);
            this.lblDateParution.TabIndex = 6;
            this.lblDateParution.Text = "Date de parution";
            // 
            // txtbCodeLivre
            // 
            this.txtbCodeLivre.Location = new System.Drawing.Point(121, 84);
            this.txtbCodeLivre.Name = "txtbCodeLivre";
            this.txtbCodeLivre.Size = new System.Drawing.Size(174, 22);
            this.txtbCodeLivre.TabIndex = 7;
            // 
            // txtbISBN
            // 
            this.txtbISBN.Location = new System.Drawing.Point(121, 133);
            this.txtbISBN.Name = "txtbISBN";
            this.txtbISBN.Size = new System.Drawing.Size(424, 22);
            this.txtbISBN.TabIndex = 8;
            // 
            // txtbTitre
            // 
            this.txtbTitre.Location = new System.Drawing.Point(121, 182);
            this.txtbTitre.Name = "txtbTitre";
            this.txtbTitre.Size = new System.Drawing.Size(590, 22);
            this.txtbTitre.TabIndex = 9;
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.FormattingEnabled = true;
            this.cbbCategorie.Items.AddRange(new object[] {
            "Science fiction",
            "Fantastique",
            "Policier",
            "Romance",
            "Jeunesse (13 ans et +)",
            "Enfants (- 13 ans)",
            "BD adultes",
            "BD jeunesse",
            "Art musique et cinéma",
            "Cuisine",
            "Droit et économie",
            "Histoire",
            "Sciences techniques et médecine",
            "Sports loisirs et vie pratique",
            "Développement personnel",
            "Essai et documents",
            "Littérature",
            "Humour",
            "Religion et spiritualité",
            "Scolaire",
            "Théâtre",
            "Dictionnaires langues",
            "Guides pratiques",
            "Informatique et Internet",
            "Sciences sociales",
            "Tourisme et voyages",
            "Contes",
            "Poésies",
            "Biographies"});
            this.cbbCategorie.Location = new System.Drawing.Point(121, 229);
            this.cbbCategorie.Name = "cbbCategorie";
            this.cbbCategorie.Size = new System.Drawing.Size(237, 24);
            this.cbbCategorie.TabIndex = 10;
            // 
            // txtbAuteur
            // 
            this.txtbAuteur.Location = new System.Drawing.Point(121, 283);
            this.txtbAuteur.Name = "txtbAuteur";
            this.txtbAuteur.Size = new System.Drawing.Size(555, 22);
            this.txtbAuteur.TabIndex = 11;
            // 
            // txtbEditeur
            // 
            this.txtbEditeur.Location = new System.Drawing.Point(121, 333);
            this.txtbEditeur.Name = "txtbEditeur";
            this.txtbEditeur.Size = new System.Drawing.Size(555, 22);
            this.txtbEditeur.TabIndex = 12;
            // 
            // dateTimeSortie
            // 
            this.dateTimeSortie.Location = new System.Drawing.Point(180, 384);
            this.dateTimeSortie.Name = "dateTimeSortie";
            this.dateTimeSortie.Size = new System.Drawing.Size(258, 22);
            this.dateTimeSortie.TabIndex = 13;
            // 
            // lblIdLivre
            // 
            this.lblIdLivre.AutoSize = true;
            this.lblIdLivre.Location = new System.Drawing.Point(37, 34);
            this.lblIdLivre.Name = "lblIdLivre";
            this.lblIdLivre.Size = new System.Drawing.Size(49, 17);
            this.lblIdLivre.TabIndex = 14;
            this.lblIdLivre.Text = "id livre";
            // 
            // txtbIdLivre
            // 
            this.txtbIdLivre.Location = new System.Drawing.Point(121, 34);
            this.txtbIdLivre.Name = "txtbIdLivre";
            this.txtbIdLivre.Size = new System.Drawing.Size(174, 22);
            this.txtbIdLivre.TabIndex = 15;
            // 
            // frmLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 457);
            this.Controls.Add(this.txtbIdLivre);
            this.Controls.Add(this.lblIdLivre);
            this.Controls.Add(this.dateTimeSortie);
            this.Controls.Add(this.txtbEditeur);
            this.Controls.Add(this.txtbAuteur);
            this.Controls.Add(this.cbbCategorie);
            this.Controls.Add(this.txtbTitre);
            this.Controls.Add(this.txtbISBN);
            this.Controls.Add(this.txtbCodeLivre);
            this.Controls.Add(this.lblDateParution);
            this.Controls.Add(this.lblEditeur);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblQrCode);
            this.Controls.Add(this.lblCodeLivre);
            this.Name = "frmLivres";
            this.Text = "Livres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblCodeLivre;
        protected System.Windows.Forms.Label lblQrCode;
        protected System.Windows.Forms.Label lblTitre;
        protected System.Windows.Forms.Label lblCategorie;
        protected System.Windows.Forms.Label lblAuteur;
        protected System.Windows.Forms.Label lblEditeur;
        protected System.Windows.Forms.Label lblDateParution;
        protected System.Windows.Forms.TextBox txtbCodeLivre;
        protected System.Windows.Forms.TextBox txtbISBN;
        protected System.Windows.Forms.TextBox txtbTitre;
        protected System.Windows.Forms.ComboBox cbbCategorie;
        protected System.Windows.Forms.TextBox txtbAuteur;
        protected System.Windows.Forms.TextBox txtbEditeur;
        protected System.Windows.Forms.DateTimePicker dateTimeSortie;
        protected System.Windows.Forms.Label lblIdLivre;
        protected System.Windows.Forms.TextBox txtbIdLivre;
    }
}