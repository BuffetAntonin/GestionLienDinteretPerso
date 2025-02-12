using GesLienBLL;
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
    public partial class FrmAjoutAvantage : Form
    {
        public FrmAjoutAvantage()
        {
            

            InitializeComponent();
            

            // La valeur qui sera affichée
            cbxBeneficaire.DisplayMember = "nom";

            // Pour prendre la clé
            cbxBeneficaire.ValueMember = "id";

            // On envoie les clients à la liste déroulante
            cbxBeneficaire.DataSource = BeneficiaireManager.GetInstance().GetBeneficiaires(out string message);
            //--------------------------------------------------------------------------



            // La valeur qui sera affichée
            cbxEmploye.DisplayMember = "nom";

            // Pour prendre la clé
            cbxEmploye.ValueMember = "id";

            // On envoie les clients à la liste déroulante
            cbxEmploye.DataSource = EmployeManager.GetInstance().GetEmploye();

            //--------------------------------------------------------------------------

            // La valeur qui sera affichée
            cbxNature.DisplayMember = "libelle";

            // Pour prendre la clé
            cbxNature.ValueMember = "id";

            // On envoie les clients à la liste déroulante
            cbxNature.DataSource = NatureManager.GetInstance().GetNature();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string verif = AvantageManager.GetInstance().CreeAvantage(mtbMontant.Text, dateDatedon.Text, (int)cbxBeneficaire.SelectedValue, (int)cbxEmploye.SelectedValue, (int)cbxNature.SelectedValue);
            if (verif == "")
            {
                MessageBox.Show("L'ajout c'est bien passer");
            }
            else
            {
                MessageBox.Show("L'ajout ne c'est pas bien passer");

            }

        }
    }
}
