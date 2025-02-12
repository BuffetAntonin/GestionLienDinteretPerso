using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBO
{
    public class Ville
    {
        private int numInsee;
        private string nomVille;
        private int codePostal;

        public Ville(int numInsee)
        {
            this.numInsee = numInsee;
        }

        public Ville(int numInsee, string nomVille, int codePostal)
        {
            this.numInsee = numInsee;
            this.nomVille = nomVille;
            this.codePostal = codePostal;
        }

        public int NumInsee { get => numInsee; set => numInsee = value; }
        public string NomVille { get => nomVille; set => nomVille = value; }
        public int CodePostal { get => codePostal; set => codePostal = value; }


    }
}
