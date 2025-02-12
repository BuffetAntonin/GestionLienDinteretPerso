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
    public partial class FrmConsltBeneficiaireConventionPeriode : Form
    {
        public FrmConsltBeneficiaireConventionPeriode()
        {
            InitializeComponent();
            dgvBeneficiaire.Visible = false;
            lblPasDeBeneficiaire.Visible = false;
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            dgvBeneficiaire.Visible = false;
            lblPasDeBeneficiaire.Visible = false;
            List<Beneficiaire> beneficiaires = new List<Beneficiaire>();
            beneficiaires = BeneficiaireManager.GetInstance().GetBeneficiairesConventionPeriode(dTPDateDebut.Text, dTPDateFin.Text, out string message);
            if (message == "")
            {
                dgvBeneficiaire.DataSource = beneficiaires;
                dgvBeneficiaire.Columns["Id"].Visible = false;
                dgvBeneficiaire.Columns["prenom"].Visible = false;
                dgvBeneficiaire.Columns["numRPPS"].Visible = false;
                dgvBeneficiaire.Columns["uneVille"].Visible = false;
                dgvBeneficiaire.Columns["unEtablissement"].Visible = false;
                dgvBeneficiaire.Columns["uneProfession"].Visible = false;
                dgvBeneficiaire.Columns["afficher"].Visible = false;
                dgvBeneficiaire.Columns["unTypeBeneficiaire"].Visible = false;
                dgvBeneficiaire.Columns["nomEtablissemnt"].Visible = false;
                dgvBeneficiaire.Columns["laProfession"].Visible = false;
                dgvBeneficiaire.Columns["Rue"].HeaderText = "Adresse du beneficiaire";
                dgvBeneficiaire.Columns["Nom"].HeaderText = "Nom du beneficiaire";

                if (beneficiaires.Count == 0)
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
                MessageBox.Show("Erreur : "+message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

