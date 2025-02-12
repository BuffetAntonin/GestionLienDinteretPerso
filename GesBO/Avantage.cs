using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBO
{
    public class Avantage
    {
        private int id;
        private float montant;
        private DateTime dateDon;
        private Beneficiaire unBeneficiaire;
        private Employe unEmploye;
        private Nature uneNature;
       


       

        public Avantage(float montant, DateTime dateDon, Beneficiaire unBeneficiaire, Employe unEmploye, Nature uneNature)
        {
            this.montant = montant;
            this.dateDon = dateDon;
            this.unBeneficiaire = unBeneficiaire;
            this.unEmploye = unEmploye;
            this.uneNature = uneNature;
           
        }

        public Avantage(int unMontant, DateTime uneDateDon, Beneficiaire beneficiaire, Employe employe, Nature nature)
        {
            this.montant = unMontant;
            this.dateDon = uneDateDon;
            this.unBeneficiaire = beneficiaire;
            this.unEmploye = employe;
            this.uneNature = nature;
        }

        public Avantage(int id, float montant, DateTime dateDon, Beneficiaire unBeneficiaire, Employe unEmploye, Nature uneNature)
        {
            this.id = id;
            this.montant = montant;
            this.dateDon = dateDon;
            this.unBeneficiaire = unBeneficiaire;
            this.unEmploye = unEmploye;
            this.uneNature = uneNature;
        }

        public int Id { get => id; set => id = value; }
        public float MontantDuDon { get => montant; set => montant = value; }
        public DateTime DateDuDon { get => dateDon; set => dateDon = value; }
        public Beneficiaire UnBeneficiaire { get => unBeneficiaire; set => unBeneficiaire = value; }
        public Employe UnEmploye { get => unEmploye; set => unEmploye = value; }
        public Nature UneNature { get => uneNature; set => uneNature = value; }

        public string NomDuBeneficiaire { get => unBeneficiaire.Nom; }
        public string EmployeResponsable { get => unEmploye.Nom; }
        public string NatureDeLavantage { get => uneNature.Libelle; }

        public string AfficherCaractAvantage { get => dateDon+"/"+unBeneficiaire.Nom+"/"+montant ;  }

    }
}
