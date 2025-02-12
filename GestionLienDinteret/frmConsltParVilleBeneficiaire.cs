using GesLienBLL;
using GesLienBO;
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
    public partial class FrmConsltParVilleBeneficiaire : Form
    {
        public FrmConsltParVilleBeneficiaire()
        {
            InitializeComponent();
            GetVille();
            dgvBeneficiaire.Visible = false;
            lblPasDeBeneficiaire.Visible=false;
        }

        private void GetVille()
        {
            List<Ville> lesVilles;
            lesVilles = VilleManager.GetInstance().GetVilles();
            cbxVille.DataSource = lesVilles;
            cbxVille.DisplayMember = "nomVille";
            cbxVille.ValueMember = "numInsee";
        }


        private void cbxVille_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int numInsee = (int)cbxVille.SelectedValue;
            List<Beneficiaire> lesBeneficiaires;
            lesBeneficiaires = BeneficiaireManager.GetInstance().GetBeneficiairesParVille(numInsee,out string message);
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
                dgvBeneficiaire.Columns["nomEtablissemnt"].Visible = false;
                dgvBeneficiaire.Columns["Rue"].HeaderText = "Adresse du beneficiaire";
                dgvBeneficiaire.Columns["Nom"].HeaderText = "Nom du beneficiaire";
                dgvBeneficiaire.Columns["laProfession"].Visible = false;
                dgvBeneficiaire.Columns["LeTypeBeneficicaire"].HeaderText = "Le type de béneficiaire";

                if (lesBeneficiaires.Count == 0)
                {
                    dgvBeneficiaire.Visible = false;
                    lblPasDeBeneficiaire.Visible = true;
                }
                else
                {
                    lblPasDeBeneficiaire.Visible = false;
                }
            }
            else
            {
                MessageBox.Show(message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
