﻿namespace projetBibliothequeCertif
{
    partial class frmScolaires
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbCodeSco = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbCodeSco);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.txtbPrenomProf);
            this.groupBox1.Controls.Add(this.txtbNomProf);
            this.groupBox1.Controls.Add(this.lblPrenomProf);
            this.groupBox1.Controls.Add(this.lblNomProf);
            this.groupBox1.Controls.Add(this.txtbVilleEcole);
            this.groupBox1.Controls.Add(this.lblVilleEcole);
            this.groupBox1.Controls.Add(this.cbbClasse);
            this.groupBox1.Controls.Add(this.txtbEcole);
            this.groupBox1.Controls.Add(this.lblClasse);
            this.groupBox1.Controls.Add(this.lblEcole);
            this.groupBox1.Location = new System.Drawing.Point(28, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 407);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scolarité";
            // 
            // txtbCodeSco
            // 
            this.txtbCodeSco.Location = new System.Drawing.Point(247, 59);
            this.txtbCodeSco.Name = "txtbCodeSco";
            this.txtbCodeSco.Size = new System.Drawing.Size(211, 22);
            this.txtbCodeSco.TabIndex = 11;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(57, 59);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(94, 17);
            this.lblCode.TabIndex = 10;
            this.lblCode.Text = "Code scolaire";
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
            // frmScolaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmScolaires";
            this.Text = "Scolaires";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TextBox txtbPrenomProf;
        protected System.Windows.Forms.TextBox txtbNomProf;
        protected System.Windows.Forms.Label lblPrenomProf;
        protected System.Windows.Forms.Label lblNomProf;
        protected System.Windows.Forms.TextBox txtbVilleEcole;
        protected System.Windows.Forms.Label lblVilleEcole;
        protected System.Windows.Forms.ComboBox cbbClasse;
        protected System.Windows.Forms.TextBox txtbEcole;
        protected System.Windows.Forms.Label lblClasse;
        protected System.Windows.Forms.Label lblEcole;
        protected System.Windows.Forms.TextBox txtbCodeSco;
        protected System.Windows.Forms.Label lblCode;
    }
}