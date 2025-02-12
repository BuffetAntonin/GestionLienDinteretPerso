namespace GesLienGUI
{
    partial class FrmConsltBeneficiaireParAvantagesAnnee
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
            this.lbl = new System.Windows.Forms.Label();
            this.cbxAnne = new System.Windows.Forms.ComboBox();
            this.lblPasDeBeneficiaire = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiaire)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBeneficiaire
            // 
            this.dgvBeneficiaire.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBeneficiaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiaire.Location = new System.Drawing.Point(122, 148);
            this.dgvBeneficiaire.Name = "dgvBeneficiaire";
            this.dgvBeneficiaire.Size = new System.Drawing.Size(819, 370);
            this.dgvBeneficiaire.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(187, 72);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(111, 13);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Veuiller choisir l\'année";
            // 
            // cbxAnne
            // 
            this.cbxAnne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnne.FormattingEnabled = true;
            this.cbxAnne.Location = new System.Drawing.Point(304, 69);
            this.cbxAnne.Name = "cbxAnne";
            this.cbxAnne.Size = new System.Drawing.Size(121, 21);
            this.cbxAnne.TabIndex = 5;
            this.cbxAnne.SelectionChangeCommitted += new System.EventHandler(this.cbxAnne_SelectionChangeCommitted);
            // 
            // lblPasDeBeneficiaire
            // 
            this.lblPasDeBeneficiaire.AutoSize = true;
            this.lblPasDeBeneficiaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPasDeBeneficiaire.Location = new System.Drawing.Point(451, 125);
            this.lblPasDeBeneficiaire.Name = "lblPasDeBeneficiaire";
            this.lblPasDeBeneficiaire.Size = new System.Drawing.Size(198, 20);
            this.lblPasDeBeneficiaire.TabIndex = 10;
            this.lblPasDeBeneficiaire.Text = "Il n\'y a pas de bénéficiaires";
            // 
            // FrmConsltBeneficiaireParAvantagesAnnee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 622);
            this.Controls.Add(this.lblPasDeBeneficiaire);
            this.Controls.Add(this.cbxAnne);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dgvBeneficiaire);
            this.Name = "FrmConsltBeneficiaireParAvantagesAnnee";
            this.Text = "Conslutation des avantages pour une année des Bénéficiaires";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBeneficiaire;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cbxAnne;
        private System.Windows.Forms.Label lblPasDeBeneficiaire;
    }
}