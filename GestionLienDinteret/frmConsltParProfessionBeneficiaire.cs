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
    public partial class FrmConsltParProfessionBeneficiaire : Form
    {
        public FrmConsltParProfessionBeneficiaire()
        {
            InitializeComponent();
            GetProfesions();
            dgvBeneficiaire.Visible = false;
            lblPasDeBeneficiaire.Visible = false;
        }

        private void cbxProfession_SelectionChangeCommitted(object sender, EventArgs e)
        {

            int idProfession = (int)cbxProfession.SelectedValue;
            List<Beneficiaire> lesBeneficiaires;
            lesBeneficiaires = BeneficiaireManager.GetInstance().GetBeneficiairesParProfession(idProfession, out string message);
            dgvBeneficiaire.DataSource = lesBeneficiaires;
            dgvBeneficiaire.Columns["Id"].Visible = false;
            dgvBeneficiaire.Columns["uneVille"].Visible = false;
            dgvBeneficiaire.Columns["unEtablissement"].Visible = false;
            dgvBeneficiaire.Columns["uneProfession"].Visible = false;
            dgvBeneficiaire.Columns["unTypeBeneficiaire"].Visible = false;
            dgvBeneficiaire.Columns["nomEtablissemnt"].Visible = false;
            dgvBeneficiaire.Columns["afficher"].Visible = false;
            dgvBeneficiaire.Columns["Rue"].HeaderText = "Adresse du profession de sante";
            dgvBeneficiaire.Columns["Nom"].HeaderText = "Nom du profession de sante";
            dgvBeneficiaire.Columns["prenom"].HeaderText = "Prenom du profession de sante";
            dgvBeneficiaire.Columns["LaProfession"].HeaderText = "La profession";
            if (message == "")
            {

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
        private void GetProfesions()
        {
            List<Profession> professions;
            professions = ProfessionManager.GetInstance().GetProfessions();
            cbxProfession.DataSource = professions;
            cbxProfession.DisplayMember = "Libelle";
            cbxProfession.ValueMember = "id";
        }


    }
}
