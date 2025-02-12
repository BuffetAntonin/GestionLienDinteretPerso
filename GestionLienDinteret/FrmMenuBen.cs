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
    public partial class FrmMenuBen : Form
    {
        public FrmMenuBen()
        {
            InitializeComponent();
        }

        private void MenuAjoutBénéficiaire_Click(object sender, EventArgs e)
        {
            FrmAjoutBeneficiaire frmAjoutBeneficiaire = new FrmAjoutBeneficiaire();
            frmAjoutBeneficiaire.Show();
        }

        private void ConsltBeneficiaire_Click(object sender, EventArgs e)
        {
            FrmConsltBeneficiaire frmConsltBeneficiaire = new FrmConsltBeneficiaire();
            frmConsltBeneficiaire.Show();
        }

        private void ModifBeneficiaire_Click(object sender, EventArgs e)
        {
            FrmModifBeneficiaire frmModif = new FrmModifBeneficiaire();
            frmModif.Show();
        }

        private void SupprBeneficiaire_Click(object sender, EventArgs e)
        {
            FrmSuppBeneficiaire frmSupp = new FrmSuppBeneficiaire();
            frmSupp.Show();
        }
    }
}
