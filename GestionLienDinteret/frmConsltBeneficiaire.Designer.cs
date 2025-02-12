namespace GesLienGUI
{
    partial class FrmConsltBeneficiaire
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
            this.lblPasDeBeneficiaire = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiaire)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBeneficiaire
            // 
            this.dgvBeneficiaire.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBeneficiaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiaire.Location = new System.Drawing.Point(12, 56);
            this.dgvBeneficiaire.Name = "dgvBeneficiaire";
            this.dgvBeneficiaire.Size = new System.Drawing.Size(819, 370);
            this.dgvBeneficiaire.TabIndex = 0;
            // 
            // lblPasDeBeneficiaire
            // 
            this.lblPasDeBeneficiaire.AutoSize = true;
            this.lblPasDeBeneficiaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPasDeBeneficiaire.Location = new System.Drawing.Point(297, 33);
            this.lblPasDeBeneficiaire.Name = "lblPasDeBeneficiaire";
            this.lblPasDeBeneficiaire.Size = new System.Drawing.Size(187, 20);
            this.lblPasDeBeneficiaire.TabIndex = 1;
            this.lblPasDeBeneficiaire.Text = "Il n\'a pas de bénéficiaires";
            // 
            // FrmConsltBeneficiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 467);
            this.Controls.Add(this.lblPasDeBeneficiaire);
            this.Controls.Add(this.dgvBeneficiaire);
            this.Name = "FrmConsltBeneficiaire";
            this.Text = "Consltation des Bénéficiaires";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBeneficiaire;
        private System.Windows.Forms.Label lblPasDeBeneficiaire;
    }
}