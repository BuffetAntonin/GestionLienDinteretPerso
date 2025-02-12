namespace GesLienGUI
{
    partial class FrmModifBeneficiaire
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
            this.pnlBeneficiaire = new System.Windows.Forms.Panel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblTypeBeneficiaire = new System.Windows.Forms.Label();
            this.btnModif = new System.Windows.Forms.Button();
            this.cbxTypeBeneficiaire = new System.Windows.Forms.ComboBox();
            this.pnlEtablissement = new System.Windows.Forms.Panel();
            this.cbxEtablissement = new System.Windows.Forms.ComboBox();
            this.lblEtatblissement = new System.Windows.Forms.Label();
            this.pnlProfession = new System.Windows.Forms.Panel();
            this.mTBRPPS = new System.Windows.Forms.MaskedTextBox();
            this.cbxProfession = new System.Windows.Forms.ComboBox();
            this.lblProf = new System.Windows.Forms.Label();
            this.lblNumRPPS = new System.Windows.Forms.Label();
            this.cbxVille = new System.Windows.Forms.ComboBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.pnlPrenom = new System.Windows.Forms.Panel();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblBeneficiaire = new System.Windows.Forms.Label();
            this.cbxBeneficiaire = new System.Windows.Forms.ComboBox();
            this.lblPasDeBeneficiaire = new System.Windows.Forms.Label();
            this.pnlBeneficiaire.SuspendLayout();
            this.pnlEtablissement.SuspendLayout();
            this.pnlProfession.SuspendLayout();
            this.pnlPrenom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBeneficiaire
            // 
            this.pnlBeneficiaire.Controls.Add(this.btnAnnuler);
            this.pnlBeneficiaire.Controls.Add(this.lblTypeBeneficiaire);
            this.pnlBeneficiaire.Controls.Add(this.btnModif);
            this.pnlBeneficiaire.Controls.Add(this.cbxTypeBeneficiaire);
            this.pnlBeneficiaire.Controls.Add(this.pnlEtablissement);
            this.pnlBeneficiaire.Controls.Add(this.pnlProfession);
            this.pnlBeneficiaire.Controls.Add(this.cbxVille);
            this.pnlBeneficiaire.Controls.Add(this.txtRue);
            this.pnlBeneficiaire.Controls.Add(this.lblAdresse);
            this.pnlBeneficiaire.Controls.Add(this.pnlPrenom);
            this.pnlBeneficiaire.Controls.Add(this.txtNom);
            this.pnlBeneficiaire.Controls.Add(this.lblNom);
            this.pnlBeneficiaire.Location = new System.Drawing.Point(97, 92);
            this.pnlBeneficiaire.Name = "pnlBeneficiaire";
            this.pnlBeneficiaire.Size = new System.Drawing.Size(858, 469);
            this.pnlBeneficiaire.TabIndex = 5;
            this.pnlBeneficiaire.Visible = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(429, 350);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(143, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblTypeBeneficiaire
            // 
            this.lblTypeBeneficiaire.AutoSize = true;
            this.lblTypeBeneficiaire.Location = new System.Drawing.Point(221, 25);
            this.lblTypeBeneficiaire.Name = "lblTypeBeneficiaire";
            this.lblTypeBeneficiaire.Size = new System.Drawing.Size(89, 13);
            this.lblTypeBeneficiaire.TabIndex = 4;
            this.lblTypeBeneficiaire.Text = "Type Bénéficiaire";
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(226, 350);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(130, 23);
            this.btnModif.TabIndex = 10;
            this.btnModif.Text = "Modification";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // cbxTypeBeneficiaire
            // 
            this.cbxTypeBeneficiaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeBeneficiaire.FormattingEnabled = true;
            this.cbxTypeBeneficiaire.Location = new System.Drawing.Point(335, 17);
            this.cbxTypeBeneficiaire.Name = "cbxTypeBeneficiaire";
            this.cbxTypeBeneficiaire.Size = new System.Drawing.Size(219, 21);
            this.cbxTypeBeneficiaire.TabIndex = 3;
            this.cbxTypeBeneficiaire.SelectionChangeCommitted += new System.EventHandler(this.cbxTypeBeneficiaire_SelectionChangeCommitted);
            // 
            // pnlEtablissement
            // 
            this.pnlEtablissement.Controls.Add(this.cbxEtablissement);
            this.pnlEtablissement.Controls.Add(this.lblEtatblissement);
            this.pnlEtablissement.Location = new System.Drawing.Point(248, 285);
            this.pnlEtablissement.Name = "pnlEtablissement";
            this.pnlEtablissement.Size = new System.Drawing.Size(223, 47);
            this.pnlEtablissement.TabIndex = 9;
            this.pnlEtablissement.Visible = false;
            // 
            // cbxEtablissement
            // 
            this.cbxEtablissement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEtablissement.FormattingEnabled = true;
            this.cbxEtablissement.Location = new System.Drawing.Point(87, 10);
            this.cbxEtablissement.Name = "cbxEtablissement";
            this.cbxEtablissement.Size = new System.Drawing.Size(121, 21);
            this.cbxEtablissement.TabIndex = 8;
            // 
            // lblEtatblissement
            // 
            this.lblEtatblissement.AutoSize = true;
            this.lblEtatblissement.Location = new System.Drawing.Point(6, 13);
            this.lblEtatblissement.Name = "lblEtatblissement";
            this.lblEtatblissement.Size = new System.Drawing.Size(75, 13);
            this.lblEtatblissement.TabIndex = 7;
            this.lblEtatblissement.Text = "Etatblissement";
            // 
            // pnlProfession
            // 
            this.pnlProfession.Controls.Add(this.mTBRPPS);
            this.pnlProfession.Controls.Add(this.cbxProfession);
            this.pnlProfession.Controls.Add(this.lblProf);
            this.pnlProfession.Controls.Add(this.lblNumRPPS);
            this.pnlProfession.Location = new System.Drawing.Point(248, 200);
            this.pnlProfession.Name = "pnlProfession";
            this.pnlProfession.Size = new System.Drawing.Size(329, 79);
            this.pnlProfession.TabIndex = 6;
            this.pnlProfession.Visible = false;
            // 
            // mTBRPPS
            // 
            this.mTBRPPS.Location = new System.Drawing.Point(97, 18);
            this.mTBRPPS.Mask = "99999";
            this.mTBRPPS.Name = "mTBRPPS";
            this.mTBRPPS.Size = new System.Drawing.Size(68, 20);
            this.mTBRPPS.TabIndex = 11;
            this.mTBRPPS.ValidatingType = typeof(int);
            // 
            // cbxProfession
            // 
            this.cbxProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfession.FormattingEnabled = true;
            this.cbxProfession.Location = new System.Drawing.Point(87, 55);
            this.cbxProfession.Name = "cbxProfession";
            this.cbxProfession.Size = new System.Drawing.Size(121, 21);
            this.cbxProfession.TabIndex = 6;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(6, 55);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(56, 13);
            this.lblProf.TabIndex = 4;
            this.lblProf.Text = "Profession";
            // 
            // lblNumRPPS
            // 
            this.lblNumRPPS.AutoSize = true;
            this.lblNumRPPS.Location = new System.Drawing.Point(6, 21);
            this.lblNumRPPS.Name = "lblNumRPPS";
            this.lblNumRPPS.Size = new System.Drawing.Size(76, 13);
            this.lblNumRPPS.TabIndex = 2;
            this.lblNumRPPS.Text = "Numero RPPS";
            // 
            // cbxVille
            // 
            this.cbxVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVille.FormattingEnabled = true;
            this.cbxVille.Location = new System.Drawing.Point(516, 162);
            this.cbxVille.Name = "cbxVille";
            this.cbxVille.Size = new System.Drawing.Size(121, 21);
            this.cbxVille.TabIndex = 5;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(335, 163);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(175, 20);
            this.txtRue.TabIndex = 4;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(259, 163);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 3;
            this.lblAdresse.Text = "Adresse";
            // 
            // pnlPrenom
            // 
            this.pnlPrenom.Controls.Add(this.txtPrenom);
            this.pnlPrenom.Controls.Add(this.lblPrenom);
            this.pnlPrenom.Location = new System.Drawing.Point(248, 96);
            this.pnlPrenom.Name = "pnlPrenom";
            this.pnlPrenom.Size = new System.Drawing.Size(223, 48);
            this.pnlPrenom.TabIndex = 2;
            this.pnlPrenom.Visible = false;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(87, 15);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(126, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(11, 15);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(335, 70);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(126, 20);
            this.txtNom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(259, 73);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblBeneficiaire
            // 
            this.lblBeneficiaire.AutoSize = true;
            this.lblBeneficiaire.Location = new System.Drawing.Point(305, 48);
            this.lblBeneficiaire.Name = "lblBeneficiaire";
            this.lblBeneficiaire.Size = new System.Drawing.Size(62, 13);
            this.lblBeneficiaire.TabIndex = 6;
            this.lblBeneficiaire.Text = "Beneficiaire";
            // 
            // cbxBeneficiaire
            // 
            this.cbxBeneficiaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBeneficiaire.FormattingEnabled = true;
            this.cbxBeneficiaire.Location = new System.Drawing.Point(392, 45);
            this.cbxBeneficiaire.Name = "cbxBeneficiaire";
            this.cbxBeneficiaire.Size = new System.Drawing.Size(173, 21);
            this.cbxBeneficiaire.TabIndex = 7;
            this.cbxBeneficiaire.SelectionChangeCommitted += new System.EventHandler(this.cbxBeneficiaire_SelectionChangeCommitted);
            // 
            // lblPasDeBeneficiaire
            // 
            this.lblPasDeBeneficiaire.AutoSize = true;
            this.lblPasDeBeneficiaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPasDeBeneficiaire.Location = new System.Drawing.Point(378, 69);
            this.lblPasDeBeneficiaire.Name = "lblPasDeBeneficiaire";
            this.lblPasDeBeneficiaire.Size = new System.Drawing.Size(198, 20);
            this.lblPasDeBeneficiaire.TabIndex = 12;
            this.lblPasDeBeneficiaire.Text = "Il n\'y a pas de bénéficiaires";
            // 
            // FrmModifBeneficiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 627);
            this.Controls.Add(this.lblPasDeBeneficiaire);
            this.Controls.Add(this.cbxBeneficiaire);
            this.Controls.Add(this.lblBeneficiaire);
            this.Controls.Add(this.pnlBeneficiaire);
            this.Name = "FrmModifBeneficiaire";
            this.Text = "Modification d\'un bénéficiaire";
            this.pnlBeneficiaire.ResumeLayout(false);
            this.pnlBeneficiaire.PerformLayout();
            this.pnlEtablissement.ResumeLayout(false);
            this.pnlEtablissement.PerformLayout();
            this.pnlProfession.ResumeLayout(false);
            this.pnlProfession.PerformLayout();
            this.pnlPrenom.ResumeLayout(false);
            this.pnlPrenom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBeneficiaire;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblTypeBeneficiaire;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.ComboBox cbxTypeBeneficiaire;
        private System.Windows.Forms.Panel pnlEtablissement;
        private System.Windows.Forms.ComboBox cbxEtablissement;
        private System.Windows.Forms.Label lblEtatblissement;
        private System.Windows.Forms.Panel pnlProfession;
        private System.Windows.Forms.MaskedTextBox mTBRPPS;
        private System.Windows.Forms.ComboBox cbxProfession;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Label lblNumRPPS;
        private System.Windows.Forms.ComboBox cbxVille;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Panel pnlPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblBeneficiaire;
        private System.Windows.Forms.ComboBox cbxBeneficiaire;
        private System.Windows.Forms.Label lblPasDeBeneficiaire;
    }
}