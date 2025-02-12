namespace GesLienGUI
{
    partial class FrmConsltParVilleBeneficiaire
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
            this.lblVille = new System.Windows.Forms.Label();
            this.cbxVille = new System.Windows.Forms.ComboBox();
            this.lblPasDeBeneficiaire = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiaire)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBeneficiaire
            // 
            this.dgvBeneficiaire.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBeneficiaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiaire.Location = new System.Drawing.Point(31, 110);
            this.dgvBeneficiaire.Name = "dgvBeneficiaire";
            this.dgvBeneficiaire.Size = new System.Drawing.Size(819, 370);
            this.dgvBeneficiaire.TabIndex = 1;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(78, 40);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 2;
            this.lblVille.Text = "Ville :";
            // 
            // cbxVille
            // 
            this.cbxVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVille.FormattingEnabled = true;
            this.cbxVille.Location = new System.Drawing.Point(116, 37);
            this.cbxVille.Name = "cbxVille";
            this.cbxVille.Size = new System.Drawing.Size(121, 21);
            this.cbxVille.TabIndex = 6;
            this.cbxVille.SelectionChangeCommitted += new System.EventHandler(this.cbxVille_SelectionChangeCommitted);
            // 
            // lblPasDeBeneficiaire
            // 
            this.lblPasDeBeneficiaire.AutoSize = true;
            this.lblPasDeBeneficiaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPasDeBeneficiaire.Location = new System.Drawing.Point(350, 73);
            this.lblPasDeBeneficiaire.Name = "lblPasDeBeneficiaire";
            this.lblPasDeBeneficiaire.Size = new System.Drawing.Size(198, 20);
            this.lblPasDeBeneficiaire.TabIndex = 7;
            this.lblPasDeBeneficiaire.Text = "Il n\'y a pas de bénéficiaires";
            // 
            // FrmConsltParVilleBeneficiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 563);
            this.Controls.Add(this.lblPasDeBeneficiaire);
            this.Controls.Add(this.cbxVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.dgvBeneficiaire);
            this.Name = "FrmConsltParVilleBeneficiaire";
            this.Text = "Conslutation des Bénéficiaires par ville";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBeneficiaire;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.ComboBox cbxVille;
        private System.Windows.Forms.Label lblPasDeBeneficiaire;
    }
}