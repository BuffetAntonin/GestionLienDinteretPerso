using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBO
{
    public class Convention
    {
        private int id;
        private DateTime dateDebut;
        private DateTime dateFin;
        private string commentaire;
        private Beneficiaire unBeneficiaire;
        private NatureConvention uneNatureConvention;
        private Employe unEmploye;

        public Convention(int id, DateTime dateDebut, DateTime dateFin, string commentaire, Beneficiaire unBeneficiaire, NatureConvention uneNatureConvention, Employe unEmploye)
        {
            this.id = id;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.commentaire = commentaire;
            this.unBeneficiaire = unBeneficiaire;
            this.uneNatureConvention = uneNatureConvention;
            this.unEmploye = unEmploye;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public Beneficiaire UnBeneficiaire { get => unBeneficiaire; set => unBeneficiaire = value; }
        public NatureConvention UneNatureConvention { get => uneNatureConvention; set => uneNatureConvention = value; }
        public Employe UnEmploye { get => unEmploye; set => unEmploye = value; }
    }
}
