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
    public partial class FrmConsltBeneficiaireParAvantagesAnnee : Form
    {
        public FrmConsltBeneficiaireParAvantagesAnnee()
        {
            InitializeComponent();
            DateTime dateTime = DateTime.Now;
            int anneeEnCour = dateTime.Year;
            List<int> annees = new List<int>();
            int anneeDebut = anneeEnCour - 5;
            for (int i = anneeEnCour; i > anneeDebut; i--)
            {
                annees.Add(i);
            }
            cbxAnne.DataSource = annees;
            dgvBeneficiaire.Visible = false;
            lblPasDeBeneficiaire.Visible = false;
        }

        private void cbxAnne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int anneeSelectionne = (int)cbxAnne.SelectedValue;
            List<Beneficiaire> lesAnnees = new List<Beneficiaire>();

            lesAnnees = BeneficiaireManager.GetInstance().GetBeneficiairesParAvantagesAnnee(anneeSelectionne, out string message);
            if (message == "")
            {
                dgvBeneficiaire.DataSource = lesAnnees;
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

                if (lesAnnees.Count == 0)
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
