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
    public partial class FrmModifAvantage : Form
    {
        public FrmModifAvantage()
        {
           
            InitializeComponent();
            // On envoie les clients à la liste déroulante


            // La valeur qui sera affichée
            cbxAvantage.DisplayMember = "AfficherCaractAvantage";

            // Pour prendre la clé
            cbxAvantage.ValueMember = "id";
            cbxAvantage.DataSource = AvantageManager.GetInstance().GetAvantage();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int idAvantage = (int)cbxAvantage.SelectedValue;
            int idBeneficiaire = (int)cbxBeneficiaire.SelectedValue;
            int idNature = (int)cbxNature.SelectedValue;
            int idEmploye = (int)cbxEmploye.SelectedValue;
            string msg = AvantageManager.GetInstance().ModifAvantage(idAvantage, txtmontant.Text, dtpDateDatedon.Text, idBeneficiaire, idEmploye,idNature) ;
            if (msg == "")
            {

                MessageBox.Show("Erreur: " + msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                pnlAvantage.Visible = false;
                cbxAvantage.Enabled = true;
                MessageBox.Show("la Modification, c'est bien passer", "Reussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Avantage();
            }
        }

        private void cbxAvantage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxAvantage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idAvantage = (int)cbxAvantage.SelectedValue;

            Avantage UnAvantage;

            UnAvantage = AvantageManager.GetInstance().GetUnAvantage(idAvantage);

            txtmontant.Text = UnAvantage.MontantDuDon.ToString();
            dtpDateDatedon.Text = UnAvantage.DateDuDon.ToString();
            pnlAvantage.Visible = true;
            GetBeneficiare(UnAvantage);
            GetEmploye(UnAvantage);
            GetNature(UnAvantage);

            
        }
        private void Avantage()
        {
            List<Avantage> lesAvantages;
            lesAvantages = AvantageManager.GetInstance().GetAvantage();
            cbxBeneficiaire.DataSource = lesAvantages;
            cbxBeneficiaire.DisplayMember = "AfficherCaractAvantage";
            cbxBeneficiaire.ValueMember = "id";
        }
        private void GetBeneficiare(Avantage unAvantage)
        {
            List<Beneficiaire> lesBeneficiaires;
            lesBeneficiaires = BeneficiaireManager.GetInstance().GetBeneficiaires(out string message);
            cbxBeneficiaire.DataSource = lesBeneficiaires;
            cbxBeneficiaire.DisplayMember = "nom";
            cbxBeneficiaire.ValueMember = "id";
            cbxBeneficiaire.SelectedValue = unAvantage.UnBeneficiaire.Id;
        }

        private void GetEmploye(Avantage unAvantage)
        {
            List<Employe> lesEmployes;
            lesEmployes = EmployeManager.GetInstance().GetEmploye();
            cbxEmploye.DataSource = lesEmployes;
            cbxEmploye.DisplayMember = "nom";
            cbxEmploye.ValueMember = "id";
            cbxNature.SelectedValue = unAvantage.UneNature.Id;
        }

        private void GetNature(Avantage unAvantage)
        {
            List<Nature> lesNatures;
            lesNatures = NatureManager.GetInstance().GetNature();
            cbxNature.DataSource = lesNatures;
            cbxNature.DisplayMember = "libelle";
            cbxNature.ValueMember = "id";
            cbxEmploye.SelectedValue = unAvantage.UnEmploye.Id;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            pnlAvantage.Visible = false;

            cbxAvantage.Enabled = true;
        }
    }
}
