namespace GesLienGUI
{
    partial class FrmModifAvantage
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
            this.pnlAvantage = new System.Windows.Forms.Panel();
            this.txtmontant = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dtpDateDatedon = new System.Windows.Forms.DateTimePicker();
            this.cbxNature = new System.Windows.Forms.ComboBox();
            this.cbxEmploye = new System.Windows.Forms.ComboBox();
            this.cbxBeneficiaire = new System.Windows.Forms.ComboBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblEmploye = new System.Windows.Forms.Label();
            this.lblBeneficiaire = new System.Windows.Forms.Label();
            this.lblDateRemise = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.cbxAvantage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAvantage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAvantage
            // 
            this.pnlAvantage.Controls.Add(this.txtmontant);
            this.pnlAvantage.Controls.Add(this.btnAnnuler);
            this.pnlAvantage.Controls.Add(this.btnModifier);
            this.pnlAvantage.Controls.Add(this.dtpDateDatedon);
            this.pnlAvantage.Controls.Add(this.cbxNature);
            this.pnlAvantage.Controls.Add(this.cbxEmploye);
            this.pnlAvantage.Controls.Add(this.cbxBeneficiaire);
            this.pnlAvantage.Controls.Add(this.lblNature);
            this.pnlAvantage.Controls.Add(this.lblEmploye);
            this.pnlAvantage.Controls.Add(this.lblBeneficiaire);
            this.pnlAvantage.Controls.Add(this.lblDateRemise);
            this.pnlAvantage.Controls.Add(this.lblMontant);
            this.pnlAvantage.Location = new System.Drawing.Point(125, 104);
            this.pnlAvantage.Name = "pnlAvantage";
            this.pnlAvantage.Size = new System.Drawing.Size(551, 305);
            this.pnlAvantage.TabIndex = 26;
            this.pnlAvantage.Visible = false;
            // 
            // txtmontant
            // 
            this.txtmontant.Location = new System.Drawing.Point(213, 17);
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.Size = new System.Drawing.Size(121, 20);
            this.txtmontant.TabIndex = 35;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(338, 247);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(132, 33);
            this.btnAnnuler.TabIndex = 34;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(81, 247);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(131, 33);
            this.btnModifier.TabIndex = 33;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dtpDateDatedon
            // 
            this.dtpDateDatedon.Location = new System.Drawing.Point(213, 61);
            this.dtpDateDatedon.Name = "dtpDateDatedon";
            this.dtpDateDatedon.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDatedon.TabIndex = 32;
            this.dtpDateDatedon.Value = new System.DateTime(2023, 11, 16, 11, 21, 37, 0);
            // 
            // cbxNature
            // 
            this.cbxNature.FormattingEnabled = true;
            this.cbxNature.Location = new System.Drawing.Point(213, 181);
            this.cbxNature.Name = "cbxNature";
            this.cbxNature.Size = new System.Drawing.Size(121, 21);
            this.cbxNature.TabIndex = 31;
            // 
            // cbxEmploye
            // 
            this.cbxEmploye.FormattingEnabled = true;
            this.cbxEmploye.Location = new System.Drawing.Point(213, 145);
            this.cbxEmploye.Name = "cbxEmploye";
            this.cbxEmploye.Size = new System.Drawing.Size(121, 21);
            this.cbxEmploye.TabIndex = 30;
            // 
            // cbxBeneficiaire
            // 
            this.cbxBeneficiaire.FormattingEnabled = true;
            this.cbxBeneficiaire.Location = new System.Drawing.Point(213, 100);
            this.cbxBeneficiaire.Name = "cbxBeneficiaire";
            this.cbxBeneficiaire.Size = new System.Drawing.Size(121, 21);
            this.cbxBeneficiaire.TabIndex = 29;
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(130, 189);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(62, 13);
            this.lblNature.TabIndex = 27;
            this.lblNature.Text = "Une Nature";
            // 
            // lblEmploye
            // 
            this.lblEmploye.AutoSize = true;
            this.lblEmploye.Location = new System.Drawing.Point(130, 145);
            this.lblEmploye.Name = "lblEmploye";
            this.lblEmploye.Size = new System.Drawing.Size(64, 13);
            this.lblEmploye.TabIndex = 26;
            this.lblEmploye.Text = "Un Employe";
            // 
            // lblBeneficiaire
            // 
            this.lblBeneficiaire.AutoSize = true;
            this.lblBeneficiaire.Location = new System.Drawing.Point(126, 103);
            this.lblBeneficiaire.Name = "lblBeneficiaire";
            this.lblBeneficiaire.Size = new System.Drawing.Size(79, 13);
            this.lblBeneficiaire.TabIndex = 25;
            this.lblBeneficiaire.Text = "Un Beneficiaire";
            // 
            // lblDateRemise
            // 
            this.lblDateRemise.AutoSize = true;
            this.lblDateRemise.Location = new System.Drawing.Point(130, 67);
            this.lblDateRemise.Name = "lblDateRemise";
            this.lblDateRemise.Size = new System.Drawing.Size(51, 13);
            this.lblDateRemise.TabIndex = 24;
            this.lblDateRemise.Text = "Date don";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(130, 25);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(46, 13);
            this.lblMontant.TabIndex = 23;
            this.lblMontant.Text = "Montant";
            // 
            // cbxAvantage
            // 
            this.cbxAvantage.FormattingEnabled = true;
            this.cbxAvantage.Location = new System.Drawing.Point(319, 42);
            this.cbxAvantage.Name = "cbxAvantage";
            this.cbxAvantage.Size = new System.Drawing.Size(193, 21);
            this.cbxAvantage.TabIndex = 25;
            this.cbxAvantage.SelectedIndexChanged += new System.EventHandler(this.cbxAvantage_SelectedIndexChanged);
            this.cbxAvantage.SelectionChangeCommitted += new System.EventHandler(this.cbxAvantage_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Selectionné un Avantage";
            // 
            // FrmModifAvantage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAvantage);
            this.Controls.Add(this.cbxAvantage);
            this.Controls.Add(this.label1);
            this.Name = "FrmModifAvantage";
            this.Text = "FrmModifAvantage";
            this.pnlAvantage.ResumeLayout(false);
            this.pnlAvantage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAvantage;
        private System.Windows.Forms.TextBox txtmontant;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DateTimePicker dtpDateDatedon;
        private System.Windows.Forms.ComboBox cbxNature;
        private System.Windows.Forms.ComboBox cbxEmploye;
        private System.Windows.Forms.ComboBox cbxBeneficiaire;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblEmploye;
        private System.Windows.Forms.Label lblBeneficiaire;
        private System.Windows.Forms.Label lblDateRemise;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.ComboBox cbxAvantage;
        private System.Windows.Forms.Label label1;
    }
}