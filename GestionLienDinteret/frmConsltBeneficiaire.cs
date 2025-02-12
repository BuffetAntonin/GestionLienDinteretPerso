using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GesLienBLL;
using GesLienBO;

namespace GesLienGUI
{
    public partial class FrmConsltBeneficiaire : Form
    {
        public FrmConsltBeneficiaire()
        {
            InitializeComponent();
            List<Beneficiaire> lesBeneficiaires;
            lesBeneficiaires = BeneficiaireManager.GetInstance().GetBeneficiaires(out string message);
            if (message == "")
            {
                dgvBeneficiaire.DataSource = lesBeneficiaires;
                dgvBeneficiaire.Columns["Id"].Visible = false;
                dgvBeneficiaire.Columns["prenom"].Visible = false;
                dgvBeneficiaire.Columns["numRPPS"].Visible = false;
                dgvBeneficiaire.Columns["uneVille"].Visible = false;
                dgvBeneficiaire.Columns["unEtablissement"].Visible = false;
                dgvBeneficiaire.Columns["uneProfession"].Visible = false;
                dgvBeneficiaire.Columns["afficher"].Visible = false;
                dgvBeneficiaire.Columns["unTypeBeneficiaire"].Visible = false;
                dgvBeneficiaire.Columns["NomEtablissemnt"].HeaderText = "Le Nom d'etablissement de l'etudiant";
                dgvBeneficiaire.Columns["Rue"].HeaderText = "Adresse du beneficiaire";
                dgvBeneficiaire.Columns["Nom"].HeaderText = "Nom du beneficiaire";
                dgvBeneficiaire.Columns["LaProfession"].HeaderText = "La profession du bénéficiaire";
                dgvBeneficiaire.Columns["LeTypeBeneficicaire"].HeaderText = "Le type de béneficiaire";

                if (lesBeneficiaires.Count == 0)
                {
                    dgvBeneficiaire.Visible = false;
                }
                else
                {
                    lblPasDeBeneficiaire.Visible=false;
                }
            }
            else
            {
                MessageBox.Show(message,"ERREUR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
