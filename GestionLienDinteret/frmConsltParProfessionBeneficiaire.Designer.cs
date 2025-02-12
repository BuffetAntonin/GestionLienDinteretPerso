namespace GesLienGUI
{
    partial class FrmConsltParProfessionBeneficiaire
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
            this.dgvBeneficiaire = new System.Windows.Forms.DataGridView();
            this.cbxProfession = new System.Windows.Forms.ComboBox();
            this.lblProf = new System.Windows.Forms.Label();
            this.lblPasDeBeneficiaire = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiaire)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBeneficiaire
            // 
            this.dgvBeneficiaire.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBeneficiaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiaire.Location = new System.Drawing.Point(67, 130);
            this.dgvBeneficiaire.Name = "dgvBeneficiaire";
            this.dgvBeneficiaire.Size = new System.Drawing.Size(819, 370);
            this.dgvBeneficiaire.TabIndex = 2;
            // 
            // cbxProfession
            // 
            this.cbxProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfession.FormattingEnabled = true;
            this.cbxProfession.Location = new System.Drawing.Point(181, 58);
            this.cbxProfession.Name = "cbxProfession";
            this.cbxProfession.Size = new System.Drawing.Size(121, 21);
            this.cbxProfession.TabIndex = 8;
            this.cbxProfession.SelectionChangeCommitted += new System.EventHandler(this.cbxProfession_SelectionChangeCommitted);
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(110, 61);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(56, 13);
            this.lblProf.TabIndex = 7;
            this.lblProf.Text = "Profession";
            // 
            // lblPasDeBeneficiaire
            // 
            this.lblPasDeBeneficiaire.AutoSize = true;
            this.lblPasDeBeneficiaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPasDeBeneficiaire.Location = new System.Drawing.Point(359, 98);
            this.lblPasDeBeneficiaire.Name = "lblPasDeBeneficiaire";
            this.lblPasDeBeneficiaire.Size = new System.Drawing.Size(198, 20);
            this.lblPasDeBeneficiaire.TabIndex = 9;
            this.lblPasDeBeneficiaire.Text = "Il n\'y a pas de bénéficiaires";
            // 
            // FrmConsltParProfessionBeneficiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 613);
            this.Controls.Add(this.lblPasDeBeneficiaire);
            this.Controls.Add(this.cbxProfession);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.dgvBeneficiaire);
            this.Name = "FrmConsltParProfessionBeneficiaire";
            this.Text = "Conslutation des Bénéficiaires par profesionnel de sante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBeneficiaire;
        private System.Windows.Forms.ComboBox cbxProfession;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Label lblPasDeBeneficiaire;
    }
}