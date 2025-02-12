namespace GesLienGUI
{
    partial class FrmMenuBen
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
            this.MenuBénéficiaire = new System.Windows.Forms.MenuStrip();
            this.MenuAjoutBénéficiaire = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsltBeneficiaire = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifBeneficiaire = new System.Windows.Forms.ToolStripMenuItem();
            this.SupprBeneficiaire = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBénéficiaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBénéficiaire
            // 
            this.MenuBénéficiaire.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAjoutBénéficiaire,
            this.ConsltBeneficiaire,
            this.ModifBeneficiaire,
            this.SupprBeneficiaire});
            this.MenuBénéficiaire.Location = new System.Drawing.Point(0, 0);
            this.MenuBénéficiaire.Name = "MenuBénéficiaire";
            this.MenuBénéficiaire.Size = new System.Drawing.Size(800, 24);
            this.MenuBénéficiaire.TabIndex = 0;
            this.MenuBénéficiaire.Text = "Menu des bénéficiaire";
            // 
            // MenuAjoutBénéficiaire
            // 
            this.MenuAjoutBénéficiaire.Name = "MenuAjoutBénéficiaire";
            this.MenuAjoutBénéficiaire.Size = new System.Drawing.Size(139, 20);
            this.MenuAjoutBénéficiaire.Text = "Ajout d\'un Bénéficiaire";
            this.MenuAjoutBénéficiaire.Click += new System.EventHandler(this.MenuAjoutBénéficiaire_Click);
            // 
            // ConsltBeneficiaire
            // 
            this.ConsltBeneficiaire.Name = "ConsltBeneficiaire";
            this.ConsltBeneficiaire.Size = new System.Drawing.Size(177, 20);
            this.ConsltBeneficiaire.Text = "Conslutation des bénéficiaires";
            this.ConsltBeneficiaire.Click += new System.EventHandler(this.ConsltBeneficiaire_Click);
            // 
            // ModifBeneficiaire
            // 
            this.ModifBeneficiaire.Name = "ModifBeneficiaire";
            this.ModifBeneficiaire.Size = new System.Drawing.Size(172, 20);
            this.ModifBeneficiaire.Text = "Modification des bénéficiaire";
            this.ModifBeneficiaire.Click += new System.EventHandler(this.ModifBeneficiaire_Click);
            // 
            // SupprBeneficiaire
            // 
            this.SupprBeneficiaire.Name = "SupprBeneficiaire";
            this.SupprBeneficiaire.Size = new System.Drawing.Size(161, 20);
            this.SupprBeneficiaire.Text = "Supprime d\'un bénéficiaire";
            this.SupprBeneficiaire.Click += new System.EventHandler(this.SupprBeneficiaire_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuBénéficiaire);
            this.Name = "FrmMenu";
            this.Text = "Menu des bénéficiaire";
            this.MenuBénéficiaire.ResumeLayout(false);
            this.MenuBénéficiaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBénéficiaire;
        private System.Windows.Forms.ToolStripMenuItem MenuAjoutBénéficiaire;
        private System.Windows.Forms.ToolStripMenuItem ConsltBeneficiaire;
        private System.Windows.Forms.ToolStripMenuItem ModifBeneficiaire;
        private System.Windows.Forms.ToolStripMenuItem SupprBeneficiaire;
    }
}