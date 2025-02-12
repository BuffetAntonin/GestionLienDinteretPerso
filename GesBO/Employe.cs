using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBO
{
    public class Employe
    {
        private int id;
        private string nom;
        private string prenom;
        private DateTime dateEmbauche;
        private TypeEmploye unTypeEmploye;

        public Employe(int id)
        {
            this.id = id;
        }

        public Employe(string nom)
        {
            this.nom = nom;
        }

        public Employe(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public Employe(int id, string nom, string prenom, DateTime dateEmbauche, TypeEmploye unTypeEmploye)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateEmbauche = dateEmbauche;
            this.unTypeEmploye = unTypeEmploye;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
        public TypeEmploye UnTypeEmploye { get => unTypeEmploye; set => unTypeEmploye = value; }
    }
}
