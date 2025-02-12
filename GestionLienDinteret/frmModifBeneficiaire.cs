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
    public partial class FrmModifBeneficiaire : Form
    {
        public FrmModifBeneficiaire()
        {
            InitializeComponent();
            Beneficiaire();
        }


        private void cbxBeneficiaire_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idBeneficiaire = (int)cbxBeneficiaire.SelectedValue;
            Beneficiaire beneficiaire;
            beneficiaire = BeneficiaireManager.GetInstance().GetUnBeneficiaire(idBeneficiaire, out string message);
            if (message == "")
            {
                pnlBeneficiaire.Visible = true;
                txtNom.Text = beneficiaire.Nom;
                txtRue.Text = beneficiaire.Rue;
                GetVille();
                GetProfesions();
                GetEtablissements();
                GetTypeBeneficiaire();
                cbxVille.SelectedValue = beneficiaire.UneVille.NumInsee;
                cbxTypeBeneficiaire.SelectedValue = beneficiaire.UnTypeBeneficiaire.Id;
                cbxBeneficiaire.Enabled = false;
                if (beneficiaire.UnTypeBeneficiaire.Id == 1)
                {
                    pnlPrenom.Visible = true;
                    pnlProfession.Visible = true;
                    txtPrenom.Text = beneficiaire.Prenom;
                    mTBRPPS.Text = Convert.ToString(beneficiaire.NumRPPS);
                    cbxProfession.SelectedValue = beneficiaire.UneProfession.Id;
                }
                if (beneficiaire.UnTypeBeneficiaire.Id == 2)
                {
                    pnlPrenom.Visible = true;
                    pnlEtablissement.Visible = true;
                    txtPrenom.Text = beneficiaire.Prenom;
                    cbxEtablissement.SelectedValue = beneficiaire.UnEtablissement.Id;
                }
            }
            else
            {
                MessageBox.Show("Erreux: " + message, "Erreux", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetVille()
        {
            List<Ville> lesVilles;
            lesVilles = VilleManager.GetInstance().GetVilles();
            cbxVille.DataSource = lesVilles;
            cbxVille.DisplayMember = "nomVille";
            cbxVille.ValueMember = "numInsee";
        }
        private void GetProfesions()
        {
            List<Profession> professions;
            professions = ProfessionManager.GetInstance().GetProfessions();
            cbxProfession.DataSource = professions;
            cbxProfession.DisplayMember = "Libelle";
            cbxProfession.ValueMember = "id";
        }
        private void GetEtablissements()
        {
            List<Etatblissement> etatblissements;
            etatblissements = EtablissementManager.GetInstance().GetEtatblissements();
            cbxEtablissement.DataSource = etatblissements;
            cbxEtablissement.DisplayMember = "Libelle";
            cbxEtablissement.ValueMember = "id";
        }
        private void Beneficiaire()
        {
            List<Beneficiaire> lesBeneficiaire;
            lesBeneficiaire = BeneficiaireManager.GetInstance().GetBeneficiaires(out string message);
            if (message == "")
            {
                cbxBeneficiaire.DataSource = lesBeneficiaire;
                cbxBeneficiaire.DisplayMember = "afficher";
                cbxBeneficiaire.ValueMember = "id";
                if (lesBeneficiaire.Count == 0)
                {
                    cbxBeneficiaire.Visible = false;
                    cbxBeneficiaire.Enabled = false;
                    lblBeneficiaire.Visible = false;
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
        private void GetTypeBeneficiaire()
        {
            List<TypeBeneficiaire> lesTypeBeneficiaire;
            lesTypeBeneficiaire = TypeBeneficiaireManager.GetInstance().GetTypeBeneficiaires();
            cbxTypeBeneficiaire.DataSource = lesTypeBeneficiaire;
            cbxTypeBeneficiaire.DisplayMember = "libelle";
            cbxTypeBeneficiaire.ValueMember = "id";
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            pnlBeneficiaire.Visible = false;
            pnlEtablissement.Visible = false;
            pnlPrenom.Visible = false;
            pnlProfession.Visible = false;
            cbxBeneficiaire.Enabled = true;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            int idBeneficiaire = (int)cbxBeneficiaire.SelectedValue;
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string rue = txtRue.Text;
            string valeurSaisie = mTBRPPS.Text;
            int numRPPS;
            int.TryParse(valeurSaisie, out numRPPS);
            int idVille = (int)cbxVille.SelectedValue;
            int idProfession = (int)cbxProfession.SelectedValue;
            int idEtablissement = (int)cbxEtablissement.SelectedValue;
            int idTypeBeneficiaire = (int)cbxTypeBeneficiaire.SelectedValue;
            string msg = BeneficiaireManager.GetInstance().ModifBeneficiaire(idBeneficiaire, nom, rue, prenom, numRPPS, idVille, idEtablissement, idProfession, idTypeBeneficiaire);
            if (msg == "")
            {
                pnlBeneficiaire.Visible = false;
                pnlEtablissement.Visible = false;
                pnlPrenom.Visible = false;
                pnlProfession.Visible = false;
                cbxBeneficiaire.Enabled = true;
                MessageBox.Show("La modification s'est bien passée", "Réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Beneficiaire();
            }
            else
            {
                MessageBox.Show("Erreux: " + msg, "Erreux", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxTypeBeneficiaire_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = (int)cbxTypeBeneficiaire.SelectedValue;
            GetProfesions();
            GetEtablissements();
            pnlPrenom.Visible = false;
            pnlBeneficiaire.Visible = true;
            pnlEtablissement.Visible = false;
            pnlProfession.Visible = false;
            pnlEtablissement.Visible = false;
            if (id == 1)
            {
                pnlPrenom.Visible = true;
                pnlProfession.Visible = true;
            }
            if (id == 2)
            {
                pnlPrenom.Visible = true;
                pnlEtablissement.Visible = true;
            }
        }
    }
}
