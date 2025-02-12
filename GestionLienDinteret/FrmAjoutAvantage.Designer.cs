namespace GesLienGUI
{
    partial class FrmAjoutAvantage
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
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblDateRemise = new System.Windows.Forms.Label();
            this.lblBeneficiaire = new System.Windows.Forms.Label();
            this.lblEmploye = new System.Windows.Forms.Label();
            this.lblNature = new System.Windows.Forms.Label();
            this.mtbMontant = new System.Windows.Forms.MaskedTextBox();
            this.cbxBeneficaire = new System.Windows.Forms.ComboBox();
            this.cbxEmploye = new System.Windows.Forms.ComboBox();
            this.cbxNature = new System.Windows.Forms.ComboBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dateDatedon = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(78, 65);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(46, 13);
            this.lblMontant.TabIndex = 0;
            this.lblMontant.Text = "Montant";
            // 
            // lblDateRemise
            // 
            this.lblDateRemise.AutoSize = true;
            this.lblDateRemise.Location = new System.Drawing.Point(73, 92);
            this.lblDateRemise.Name = "lblDateRemise";
            this.lblDateRemise.Size = new System.Drawing.Size(51, 13);
            this.lblDateRemise.TabIndex = 1;
            this.lblDateRemise.Text = "Date don";
            // 
            // lblBeneficiaire
            // 
            this.lblBeneficiaire.AutoSize = true;
            this.lblBeneficiaire.Location = new System.Drawing.Point(73, 116);
            this.lblBeneficiaire.Name = "lblBeneficiaire";
            this.lblBeneficiaire.Size = new System.Drawing.Size(79, 13);
            this.lblBeneficiaire.TabIndex = 2;
            this.lblBeneficiaire.Text = "Un Beneficiaire";
            // 
            // lblEmploye
            // 
            this.lblEmploye.AutoSize = true;
            this.lblEmploye.Location = new System.Drawing.Point(73, 144);
            this.lblEmploye.Name = "lblEmploye";
            this.lblEmploye.Size = new System.Drawing.Size(64, 13);
            this.lblEmploye.TabIndex = 3;
            this.lblEmploye.Text = "Un Employe";
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(73, 171);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(62, 13);
            this.lblNature.TabIndex = 4;
            this.lblNature.Text = "Une Nature";
            // 
            // mtbMontant
            // 
            this.mtbMontant.Location = new System.Drawing.Point(158, 65);
            this.mtbMontant.Mask = "0000.00";
            this.mtbMontant.Name = "mtbMontant";
            this.mtbMontant.Size = new System.Drawing.Size(100, 20);
            this.mtbMontant.TabIndex = 5;
            // 
            // cbxBeneficaire
            // 
            this.cbxBeneficaire.FormattingEnabled = true;
            this.cbxBeneficaire.Location = new System.Drawing.Point(158, 114);
            this.cbxBeneficaire.Name = "cbxBeneficaire";
            this.cbxBeneficaire.Size = new System.Drawing.Size(121, 21);
            this.cbxBeneficaire.TabIndex = 6;
            // 
            // cbxEmploye
            // 
            this.cbxEmploye.FormattingEnabled = true;
            this.cbxEmploye.Location = new System.Drawing.Point(158, 144);
            this.cbxEmploye.Name = "cbxEmploye";
            this.cbxEmploye.Size = new System.Drawing.Size(121, 21);
            this.cbxEmploye.TabIndex = 7;
            // 
            // cbxNature
            // 
            this.cbxNature.FormattingEnabled = true;
            this.cbxNature.Location = new System.Drawing.Point(158, 171);
            this.cbxNature.Name = "cbxNature";
            this.cbxNature.Size = new System.Drawing.Size(121, 21);
            this.cbxNature.TabIndex = 8;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(158, 223);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(131, 33);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // dateDatedon
            // 
            this.dateDatedon.Location = new System.Drawing.Point(158, 91);
            this.dateDatedon.Name = "dateDatedon";
            this.dateDatedon.Size = new System.Drawing.Size(200, 20);
            this.dateDatedon.TabIndex = 9;
            this.dateDatedon.Value = new System.DateTime(2023, 11, 16, 11, 21, 37, 0);
            // 
            // FrmAjoutAvantage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dateDatedon);
            this.Controls.Add(this.cbxNature);
            this.Controls.Add(this.cbxEmploye);
            this.Controls.Add(this.cbxBeneficaire);
            this.Controls.Add(this.mtbMontant);
            this.Controls.Add(this.lblNature);
            this.Controls.Add(this.lblEmploye);
            this.Controls.Add(this.lblBeneficiaire);
            this.Controls.Add(this.lblDateRemise);
            this.Controls.Add(this.lblMontant);
            this.Name = "FrmAjoutAvantage";
            this.Text = "FrmAjoutAvantage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblDateRemise;
        private System.Windows.Forms.Label lblBeneficiaire;
        private System.Windows.Forms.Label lblEmploye;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.MaskedTextBox mtbMontant;
        private System.Windows.Forms.ComboBox cbxBeneficaire;
        private System.Windows.Forms.ComboBox cbxEmploye;
        private System.Windows.Forms.ComboBox cbxNature;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DateTimePicker dateDatedon;
    }
}