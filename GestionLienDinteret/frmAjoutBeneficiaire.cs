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
    public partial class FrmAjoutBeneficiaire : Form
    {
        public FrmAjoutBeneficiaire()
        {
            InitializeComponent();
            // Déclare des variables.
            List<TypeBeneficiaire> lesTypeBeneficiaire;
            // Appel de méthode pour afficher une liste de type de bénéficiaire
            lesTypeBeneficiaire = TypeBeneficiaireManager.GetInstance().GetTypeBeneficiaires();
            cbxTypeBeneficiaire.DataSource = lesTypeBeneficiaire;
            cbxTypeBeneficiaire.DisplayMember = "libelle";
            cbxTypeBeneficiaire.ValueMember = "id";
        }
 
        private void GetVille()
        {
            // Déclare des variables.
            List<Ville> lesVilles;
            lesVilles = VilleManager.GetInstance().GetVilles();
            cbxVille.DataSource = lesVilles;
            cbxVille.DisplayMember = "nomVille";
            cbxVille.ValueMember = "numInsee";
        }
        private void GetProfesions()
        {
            //Déclare des variables.
            List<Profession> professions;
            // Appel de méthode pour afficher une liste une profession
            professions = ProfessionManager.GetInstance().GetProfessions();
            cbxProfession.DataSource = professions;
            cbxProfession.DisplayMember = "Libelle";
            cbxProfession.ValueMember = "id";
        }
        private void GetEtablissements()
        {
            //Déclare des variables.
            List<Etatblissement> etatblissements;
            // Appel de méthode pour afficher une liste d'établissement
            etatblissements = EtablissementManager.GetInstance().GetEtatblissements();
            cbxEtablissement.DataSource = etatblissements;
            cbxEtablissement.DisplayMember = "Libelle";
            cbxEtablissement.ValueMember = "id";
        }

        private void cbxTypeBeneficiaire_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxTypeBeneficiaire.Enabled = false;
            int id = (int)cbxTypeBeneficiaire.SelectedValue;
            GetVille();
            GetProfesions();
            GetEtablissements();
            pnlBeneficiaire.Visible = true;
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

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtRue.Text = "";
            mTBRPPS.Text = "";
            pnlBeneficiaire.Visible = false;
            pnlEtablissement.Visible = false;
            pnlPrenom.Visible = false;
            pnlProfession.Visible = false;
            cbxTypeBeneficiaire.Enabled = true;
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            // Déclare des variables.
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
            // Appel de méthode pour ajouter un bénéficiaire
            string msg = BeneficiaireManager.GetInstance().AjoutBeneficiaire(nom, rue, prenom, numRPPS, idVille, idEtablissement, idProfession, idTypeBeneficiaire);
            if (msg == "")
            {
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtRue.Text = "";
                mTBRPPS.Text = "";
                pnlBeneficiaire.Visible = false;
                pnlEtablissement.Visible = false;
                pnlPrenom.Visible = false;
                pnlProfession.Visible = false;
                cbxTypeBeneficiaire.Enabled = true;
                MessageBox.Show("L'ajout, c'est bien passer", "Reussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreux : " + msg, "Erreux", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
