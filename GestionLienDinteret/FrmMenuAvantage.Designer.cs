namespace GesLienGUI
{
    partial class FrmMenuAvantage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajoutCaractéristiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifCaractéristiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionCaractéristiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationCaractéristiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutCaractéristiquesToolStripMenuItem,
            this.modifCaractéristiqueToolStripMenuItem,
            this.suppressionCaractéristiquesToolStripMenuItem,
            this.consultationCaractéristiqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajoutCaractéristiquesToolStripMenuItem
            // 
            this.ajoutCaractéristiquesToolStripMenuItem.Name = "ajoutCaractéristiquesToolStripMenuItem";
            this.ajoutCaractéristiquesToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.ajoutCaractéristiquesToolStripMenuItem.Text = "Ajout Caractéristiques";
            this.ajoutCaractéristiquesToolStripMenuItem.Click += new System.EventHandler(this.ajoutCaractéristiquesToolStripMenuItem_Click);
            // 
            // modifCaractéristiqueToolStripMenuItem
            // 
            this.modifCaractéristiqueToolStripMenuItem.Name = "modifCaractéristiqueToolStripMenuItem";
            this.modifCaractéristiqueToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.modifCaractéristiqueToolStripMenuItem.Text = "Modif caractéristique";
            this.modifCaractéristiqueToolStripMenuItem.Click += new System.EventHandler(this.modifCaractéristiqueToolStripMenuItem_Click);
            // 
            // suppressionCaractéristiquesToolStripMenuItem
            // 
            this.suppressionCaractéristiquesToolStripMenuItem.Name = "suppressionCaractéristiquesToolStripMenuItem";
            this.suppressionCaractéristiquesToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.suppressionCaractéristiquesToolStripMenuItem.Text = "Suppression Caractéristiques";
            this.suppressionCaractéristiquesToolStripMenuItem.Click += new System.EventHandler(this.suppressionCaractéristiquesToolStripMenuItem_Click);
            // 
            // consultationCaractéristiqueToolStripMenuItem
            // 
            this.consultationCaractéristiqueToolStripMenuItem.Name = "consultationCaractéristiqueToolStripMenuItem";
            this.consultationCaractéristiqueToolStripMenuItem.Size = new System.Drawing.Size(169, 20);
            this.consultationCaractéristiqueToolStripMenuItem.Text = "Consultation Caractéristique";
            this.consultationCaractéristiqueToolStripMenuItem.Click += new System.EventHandler(this.consultationCaractéristiqueToolStripMenuItem_Click);
            // 
            // FrmMenuAvantage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMenuAvantage";
            this.Text = "FrmMenuAvantage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajoutCaractéristiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifCaractéristiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionCaractéristiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationCaractéristiqueToolStripMenuItem;
    }
}