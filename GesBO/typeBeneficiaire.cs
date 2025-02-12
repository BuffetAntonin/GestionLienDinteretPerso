using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBO
{
    public class TypeBeneficiaire
    {
        private int id;
        private string libelle;

        public TypeBeneficiaire(int id)
        {
            this.id = id;
        }
        public TypeBeneficiaire(string libelle)
        {
            this.libelle = libelle;
        }

        public TypeBeneficiaire(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
