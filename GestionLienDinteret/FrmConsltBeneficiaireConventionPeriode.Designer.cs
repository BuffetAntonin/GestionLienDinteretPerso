namespace GesLienGUI
{
    partial class FrmConsltBeneficiaireConventionPeriode
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
            this.lblPeriode = new System.Windows.Forms.Label();
            this.dTPDateDebut = new System.Windows.Forms.DateTimePicker();
            this.dTPDateFin = new System.Windows.Forms.DateTimePicker();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.lblPasDeBeneficiaire = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiaire)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBeneficiaire
            // 
            this.dgvBeneficiaire.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBeneficiaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiaire.Location = new System.Drawing.Point(95, 219);
            this.dgvBeneficiaire.Name = "dgvBeneficiaire";
            this.dgvBeneficiaire.Size = new System.Drawing.Size(819, 370);
            this.dgvBeneficiaire.TabIndex = 4;
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Location = new System.Drawing.Point(141, 84);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(120, 13);
            this.lblPeriode.TabIndex = 5;
            this.lblPeriode.Text = "Veuille choisir la periode";
            // 
            // dTPDateDebut
            // 
            this.dTPDateDebut.Location = new System.Drawing.Point(288, 84);
            this.dTPDateDebut.Name = "dTPDateDebut";
            this.dTPDateDebut.Size = new System.Drawing.Size(200, 20);
            this.dTPDateDebut.TabIndex = 6;
            // 
            // dTPDateFin
            // 
            this.dTPDateFin.Location = new System.Drawing.Point(544, 84);
            this.dTPDateFin.Name = "dTPDateFin";
            this.dTPDateFin.Size = new System.Drawing.Size(200, 20);
            this.dTPDateFin.TabIndex = 7;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(423, 130);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(216, 23);
            this.btnAfficher.TabIndex = 8;
            this.btnAfficher.Text = "Afficher la periode selection";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // lblPasDeBeneficiaire
            // 
            this.lblPasDeBeneficiaire.AutoSize = true;
            this.lblPasDeBeneficiaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPasDeBeneficiaire.Location = new System.Drawing.Point(400, 181);
            this.lblPasDeBeneficiaire.Name = "lblPasDeBeneficiaire";
            this.lblPasDeBeneficiaire.Size = new System.Drawing.Size(198, 20);
            this.lblPasDeBeneficiaire.TabIndex = 10;
            this.lblPasDeBeneficiaire.Text = "Il n\'y a pas de bénéficiaires";
            // 
            // FrmConsltBeneficiaireConventionPeriode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 635);
            this.Controls.Add(this.lblPasDeBeneficiaire);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dTPDateFin);
            this.Controls.Add(this.dTPDateDebut);
            this.Controls.Add(this.lblPeriode);
            this.Controls.Add(this.dgvBeneficiaire);
            this.Name = "FrmConsltBeneficiaireConventionPeriode";
            this.Text = "Conslutation du periode de convenction des Bénéficiaires";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBeneficiaire;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.DateTimePicker dTPDateDebut;
        private System.Windows.Forms.DateTimePicker dTPDateFin;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Label lblPasDeBeneficiaire;
    }
}