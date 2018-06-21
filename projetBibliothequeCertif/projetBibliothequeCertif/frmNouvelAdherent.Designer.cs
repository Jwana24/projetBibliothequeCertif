namespace projetBibliothequeCertif
{
    partial class frmNouvelAdherent
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkParticuliers = new System.Windows.Forms.CheckBox();
            this.chkScolaires = new System.Windows.Forms.CheckBox();
            this.grpScolarite = new System.Windows.Forms.GroupBox();
            this.txtbPrenomProf = new System.Windows.Forms.TextBox();
            this.txtbNomProf = new System.Windows.Forms.TextBox();
            this.lblPrenomProf = new System.Windows.Forms.Label();
            this.lblNomProf = new System.Windows.Forms.Label();
            this.txtbVilleEcole = new System.Windows.Forms.TextBox();
            this.lblVilleEcole = new System.Windows.Forms.Label();
            this.cbbClasse = new System.Windows.Forms.ComboBox();
            this.txtbEcole = new System.Windows.Forms.TextBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblEcole = new System.Windows.Forms.Label();
            this.dateTimeCotis = new System.Windows.Forms.DateTimePicker();
            this.grpCotisations.SuspendLayout();
            this.grpScolarite.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbNom
            // 
            this.txtbNom.Location = new System.Drawing.Point(111, 114);
            this.txtbNom.Visible = false;
            // 
            // txtbPrenom
            // 
            this.txtbPrenom.Location = new System.Drawing.Point(111, 159);
            this.txtbPrenom.Visible = false;
            // 
            // txtbCodePostal
            // 
            this.txtbCodePostal.Location = new System.Drawing.Point(111, 210);
            this.txtbCodePostal.Visible = false;
            // 
            // txtbVille
            // 
            this.txtbVille.Location = new System.Drawing.Point(462, 210);
            this.txtbVille.Size = new System.Drawing.Size(405, 22);
            this.txtbVille.Visible = false;
            // 
            // txtbAdresse
            // 
            this.txtbAdresse.Location = new System.Drawing.Point(111, 260);
            this.txtbAdresse.Size = new System.Drawing.Size(758, 22);
            this.txtbAdresse.Visible = false;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(111, 351);
            this.txtbEmail.Size = new System.Drawing.Size(756, 22);
            this.txtbEmail.Visible = false;
            // 
            // txtbTelephone
            // 
            this.txtbTelephone.Location = new System.Drawing.Point(111, 407);
            this.txtbTelephone.Visible = false;
            // 
            // dateTimeInscription
            // 
            this.dateTimeInscription.Location = new System.Drawing.Point(202, 307);
            this.dateTimeInscription.Visible = false;
            // 
            // lblNom
            // 
            this.lblNom.Location = new System.Drawing.Point(24, 114);
            this.lblNom.Visible = false;
            // 
            // lblPrenom
            // 
            this.lblPrenom.Location = new System.Drawing.Point(24, 159);
            this.lblPrenom.Visible = false;
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.Location = new System.Drawing.Point(24, 210);
            this.lblCodePostal.Visible = false;
            // 
            // lblVille
            // 
            this.lblVille.Location = new System.Drawing.Point(378, 210);
            this.lblVille.Visible = false;
            // 
            // lblAdresse1
            // 
            this.lblAdresse1.Location = new System.Drawing.Point(24, 260);
            this.lblAdresse1.Visible = false;
            // 
            // lblDateInscription
            // 
            this.lblDateInscription.Location = new System.Drawing.Point(24, 307);
            this.lblDateInscription.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(24, 351);
            this.lblEmail.Visible = false;
            // 
            // lblTelephone
            // 
            this.lblTelephone.Location = new System.Drawing.Point(24, 407);
            this.lblTelephone.Visible = false;
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.Location = new System.Drawing.Point(24, 456);
            this.lblDateNaissance.Visible = false;
            // 
            // dateTimeNaissance
            // 
            this.dateTimeNaissance.Location = new System.Drawing.Point(202, 456);
            this.dateTimeNaissance.Visible = false;
            // 
            // lblNumAdherent
            // 
            this.lblNumPersonne.Location = new System.Drawing.Point(24, 66);
            this.lblNumPersonne.Visible = false;
            // 
            // txtbNumAdherent
            // 
            this.txtbNumPersonne.Location = new System.Drawing.Point(202, 66);
            this.txtbNumPersonne.Visible = false;
            // 
            // grpCotisations
            // 
            this.grpCotisations.Controls.Add(this.dateTimeCotis);
            this.grpCotisations.Location = new System.Drawing.Point(550, 57);
            this.grpCotisations.Visible = false;
            this.grpCotisations.Enter += new System.EventHandler(this.grpCotisations_Enter);
            this.grpCotisations.Controls.SetChildIndex(this.lblCotisations, 0);
            this.grpCotisations.Controls.SetChildIndex(this.lblRetard, 0);
            this.grpCotisations.Controls.SetChildIndex(this.dateTimeCotis, 0);
            // 
            // lblRetard
            // 
            this.lblRetard.Visible = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(792, 545);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 29);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(711, 545);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(61, 29);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkParticuliers
            // 
            this.chkParticuliers.AutoSize = true;
            this.chkParticuliers.Location = new System.Drawing.Point(282, 26);
            this.chkParticuliers.Name = "chkParticuliers";
            this.chkParticuliers.Size = new System.Drawing.Size(99, 21);
            this.chkParticuliers.TabIndex = 22;
            this.chkParticuliers.Text = "particuliers";
            this.chkParticuliers.UseVisualStyleBackColor = true;
            this.chkParticuliers.CheckedChanged += new System.EventHandler(this.chkParticuliers_CheckedChanged);
            // 
            // chkScolaires
            // 
            this.chkScolaires.AutoSize = true;
            this.chkScolaires.Location = new System.Drawing.Point(558, 26);
            this.chkScolaires.Name = "chkScolaires";
            this.chkScolaires.Size = new System.Drawing.Size(86, 21);
            this.chkScolaires.TabIndex = 24;
            this.chkScolaires.Text = "scolaires";
            this.chkScolaires.UseVisualStyleBackColor = true;
            this.chkScolaires.CheckedChanged += new System.EventHandler(this.chkScolaires_CheckedChanged);
            // 
            // grpScolarite
            // 
            this.grpScolarite.Controls.Add(this.txtbPrenomProf);
            this.grpScolarite.Controls.Add(this.txtbNomProf);
            this.grpScolarite.Controls.Add(this.lblPrenomProf);
            this.grpScolarite.Controls.Add(this.lblNomProf);
            this.grpScolarite.Controls.Add(this.txtbVilleEcole);
            this.grpScolarite.Controls.Add(this.lblVilleEcole);
            this.grpScolarite.Controls.Add(this.cbbClasse);
            this.grpScolarite.Controls.Add(this.txtbEcole);
            this.grpScolarite.Controls.Add(this.lblClasse);
            this.grpScolarite.Controls.Add(this.lblEcole);
            this.grpScolarite.Location = new System.Drawing.Point(27, 57);
            this.grpScolarite.Name = "grpScolarite";
            this.grpScolarite.Size = new System.Drawing.Size(857, 474);
            this.grpScolarite.TabIndex = 25;
            this.grpScolarite.TabStop = false;
            this.grpScolarite.Text = "Scolarité";
            this.grpScolarite.Visible = false;
            // 
            // txtbPrenomProf
            // 
            this.txtbPrenomProf.Location = new System.Drawing.Point(247, 325);
            this.txtbPrenomProf.Name = "txtbPrenomProf";
            this.txtbPrenomProf.Size = new System.Drawing.Size(370, 22);
            this.txtbPrenomProf.TabIndex = 9;
            // 
            // txtbNomProf
            // 
            this.txtbNomProf.Location = new System.Drawing.Point(247, 268);
            this.txtbNomProf.Name = "txtbNomProf";
            this.txtbNomProf.Size = new System.Drawing.Size(370, 22);
            this.txtbNomProf.TabIndex = 8;
            // 
            // lblPrenomProf
            // 
            this.lblPrenomProf.AutoSize = true;
            this.lblPrenomProf.Location = new System.Drawing.Point(57, 325);
            this.lblPrenomProf.Name = "lblPrenomProf";
            this.lblPrenomProf.Size = new System.Drawing.Size(147, 17);
            this.lblPrenomProf.TabIndex = 7;
            this.lblPrenomProf.Text = "Prénom professeur(e)";
            // 
            // lblNomProf
            // 
            this.lblNomProf.AutoSize = true;
            this.lblNomProf.Location = new System.Drawing.Point(57, 268);
            this.lblNomProf.Name = "lblNomProf";
            this.lblNomProf.Size = new System.Drawing.Size(127, 17);
            this.lblNomProf.TabIndex = 6;
            this.lblNomProf.Text = "Nom professeur(e)";
            // 
            // txtbVilleEcole
            // 
            this.txtbVilleEcole.Location = new System.Drawing.Point(138, 110);
            this.txtbVilleEcole.Name = "txtbVilleEcole";
            this.txtbVilleEcole.Size = new System.Drawing.Size(320, 22);
            this.txtbVilleEcole.TabIndex = 5;
            // 
            // lblVilleEcole
            // 
            this.lblVilleEcole.AutoSize = true;
            this.lblVilleEcole.Location = new System.Drawing.Point(57, 110);
            this.lblVilleEcole.Name = "lblVilleEcole";
            this.lblVilleEcole.Size = new System.Drawing.Size(34, 17);
            this.lblVilleEcole.TabIndex = 4;
            this.lblVilleEcole.Text = "Ville";
            // 
            // cbbClasse
            // 
            this.cbbClasse.FormattingEnabled = true;
            this.cbbClasse.Items.AddRange(new object[] {
            "6e",
            "5e",
            "4e",
            "3e"});
            this.cbbClasse.Location = new System.Drawing.Point(138, 206);
            this.cbbClasse.Name = "cbbClasse";
            this.cbbClasse.Size = new System.Drawing.Size(125, 24);
            this.cbbClasse.TabIndex = 3;
            // 
            // txtbEcole
            // 
            this.txtbEcole.Location = new System.Drawing.Point(247, 155);
            this.txtbEcole.Name = "txtbEcole";
            this.txtbEcole.Size = new System.Drawing.Size(370, 22);
            this.txtbEcole.TabIndex = 2;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(54, 209);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(50, 17);
            this.lblClasse.TabIndex = 1;
            this.lblClasse.Text = "Classe";
            // 
            // lblEcole
            // 
            this.lblEcole.AutoSize = true;
            this.lblEcole.Location = new System.Drawing.Point(54, 155);
            this.lblEcole.Name = "lblEcole";
            this.lblEcole.Size = new System.Drawing.Size(149, 17);
            this.lblEcole.TabIndex = 0;
            this.lblEcole.Text = "Etablissement scolaire";
            // 
            // dateTimeCotis
            // 
            this.dateTimeCotis.Location = new System.Drawing.Point(113, 33);
            this.dateTimeCotis.Name = "dateTimeCotis";
            this.dateTimeCotis.Size = new System.Drawing.Size(200, 22);
            this.dateTimeCotis.TabIndex = 4;
            // 
            // frmNouvelAdherent
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(911, 596);
            this.Controls.Add(this.grpScolarite);
            this.Controls.Add(this.chkScolaires);
            this.Controls.Add(this.chkParticuliers);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "frmNouvelAdherent";
            this.Text = "Nouvel adhérent";
            this.Load += new System.EventHandler(this.frmNouvelAdherent_Load);
            this.Controls.SetChildIndex(this.grpCotisations, 0);
            this.Controls.SetChildIndex(this.lblNumPersonne, 0);
            this.Controls.SetChildIndex(this.txtbNumPersonne, 0);
            this.Controls.SetChildIndex(this.lblDateNaissance, 0);
            this.Controls.SetChildIndex(this.dateTimeNaissance, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.chkParticuliers, 0);
            this.Controls.SetChildIndex(this.chkScolaires, 0);
            this.Controls.SetChildIndex(this.lblNom, 0);
            this.Controls.SetChildIndex(this.lblPrenom, 0);
            this.Controls.SetChildIndex(this.lblCodePostal, 0);
            this.Controls.SetChildIndex(this.lblVille, 0);
            this.Controls.SetChildIndex(this.lblAdresse1, 0);
            this.Controls.SetChildIndex(this.lblDateInscription, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.lblTelephone, 0);
            this.Controls.SetChildIndex(this.txtbNom, 0);
            this.Controls.SetChildIndex(this.txtbPrenom, 0);
            this.Controls.SetChildIndex(this.txtbCodePostal, 0);
            this.Controls.SetChildIndex(this.txtbVille, 0);
            this.Controls.SetChildIndex(this.txtbAdresse, 0);
            this.Controls.SetChildIndex(this.txtbEmail, 0);
            this.Controls.SetChildIndex(this.txtbTelephone, 0);
            this.Controls.SetChildIndex(this.dateTimeInscription, 0);
            this.Controls.SetChildIndex(this.grpScolarite, 0);
            this.grpCotisations.ResumeLayout(false);
            this.grpCotisations.PerformLayout();
            this.grpScolarite.ResumeLayout(false);
            this.grpScolarite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkParticuliers;
        private System.Windows.Forms.CheckBox chkScolaires;
        private System.Windows.Forms.GroupBox grpScolarite;
        private System.Windows.Forms.ComboBox cbbClasse;
        private System.Windows.Forms.TextBox txtbEcole;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblEcole;
        private System.Windows.Forms.TextBox txtbPrenomProf;
        private System.Windows.Forms.TextBox txtbNomProf;
        private System.Windows.Forms.Label lblPrenomProf;
        private System.Windows.Forms.Label lblNomProf;
        private System.Windows.Forms.TextBox txtbVilleEcole;
        private System.Windows.Forms.Label lblVilleEcole;
        private System.Windows.Forms.DateTimePicker dateTimeCotis;
    }
}
