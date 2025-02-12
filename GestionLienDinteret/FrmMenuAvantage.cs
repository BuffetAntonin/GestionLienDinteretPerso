using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesLienGUI
{
    public partial class FrmMenuAvantage : Form
    {
        public FrmMenuAvantage()
        {
            InitializeComponent();
        }

        private void ajoutCaractéristiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créer un objet de la classe du formulaire à appeler
            FrmAjoutAvantage leFormAppel = new FrmAjoutAvantage();

            // Afficher le formulaire
            leFormAppel.Show();
        }

        private void modifCaractéristiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créer un objet de la classe du formulaire à appeler
            FrmModifAvantage leFormAppel = new FrmModifAvantage();

            // Afficher le formulaire
            leFormAppel.Show();
        }

        private void suppressionCaractéristiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créer un objet de la classe du formulaire à appeler
            FrmSuppAvantage leFormAppel = new FrmSuppAvantage();

            // Afficher le formulaire
            leFormAppel.Show();
        }

        private void consultationCaractéristiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créer un objet de la classe du formulaire à appeler
            FrmConsultAvantage leFormAppel = new FrmConsultAvantage();

            // Afficher le formulaire
            leFormAppel.Show();
        }
    }
}
