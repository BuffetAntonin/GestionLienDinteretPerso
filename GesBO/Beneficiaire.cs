using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBO
{
    public class Beneficiaire
    {
        private int id;
        private string nom;
        private string rue;
        private string prenom;
        private int? numRPPS;
        private Ville uneVille;
        private Etatblissement unEtablissement;
        private Profession uneProfession;
        private TypeBeneficiaire unTypeBeneficiaire;

        public Beneficiaire(int id)
        {
            this.id = id;
        }

        public Beneficiaire(string nom)
        {
            this.nom = nom;
        }

        public Beneficiaire(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }
        public Beneficiaire(int id, string nom, string rue, Etatblissement unEtablissement, Profession uneProfession, TypeBeneficiaire unTypeBeneficiaire)
        {
            this.id = id;
            this.nom = nom;
            this.rue = rue;
            this.unEtablissement = unEtablissement;
            this.uneProfession = uneProfession;
            this.unTypeBeneficiaire = unTypeBeneficiaire;
        }
        public Beneficiaire(int id,string nom, string rue, string prenom, int? numRPPS, Ville uneVille, Etatblissement unEtablissement, Profession uneProfession, TypeBeneficiaire unTypeBeneficiaire)
        {
            this.id = id;
            this.nom = nom;
            this.rue = rue;
            this.prenom = prenom;
            this.numRPPS = numRPPS;
            this.uneVille = uneVille;
            this.unEtablissement = unEtablissement;
            this.uneProfession = uneProfession;
            this.unTypeBeneficiaire = unTypeBeneficiaire;
        }
        public Beneficiaire(string nom, string rue, string prenom, int? numRPPS, Ville uneVille, Etatblissement unEtablissement, Profession uneProfession, TypeBeneficiaire unTypeBeneficiaire)
        {
            this.nom = nom;
            this.rue = rue;
            this.prenom = prenom;
            this.numRPPS = numRPPS;
            this.uneVille = uneVille;
            this.unEtablissement = unEtablissement;
            this.uneProfession = uneProfession;
            this.unTypeBeneficiaire = unTypeBeneficiaire;
        }

        public Beneficiaire(string nom, string rue, TypeBeneficiaire unTypeBeneficiaire)
        {
            this.nom = nom;
            this.rue = rue;
            this.unTypeBeneficiaire = unTypeBeneficiaire;
        }
        public Beneficiaire(string nom, string rue,string prenom,int? numRPPS,Profession uneProfession, TypeBeneficiaire unTypeBeneficiaire)
        {
            this.nom=nom;
            this.rue = rue;
            this.prenom=prenom;
            this.numRPPS = numRPPS;
            this.uneProfession=uneProfession;
            this.unTypeBeneficiaire=unTypeBeneficiaire;
        }

        /// <summary>
        /// Retourne un l'id
        /// </summary>
        public int Id { get => id;}
        /// <summary>
        /// Retourne le nom d'un bénéficiaire ou le modifie.
        /// </summary>
        public string Nom { get => nom; set => nom = value; }
        /// <summary>
        /// Retourne le rue d'un bénéficiaire ou le modifie.
        /// </summary>
        public string Rue { get => rue; set => rue = value; }
        /// <summary>
        /// Retourne le prenom d'un bénéficiaire ou le modifie.
        /// </summary>
        public string Prenom { get => prenom; set => prenom = value; }
        /// <summary>
        /// Retourne le Numéro RPPS d'un bénéficiaire pour le professionnel de santé ou le modifie.
        /// </summary>
        public int? NumRPPS { get => numRPPS; set => numRPPS = value; }
        /// <summary>
        /// Retourne un objet d'une ville.
        /// </summary>
        public Ville UneVille { get => uneVille;}
        /// <summary>
        /// Retourne un objet d'un établissement.
        /// </summary>
        public Etatblissement UnEtablissement { get => unEtablissement;}
        /// <summary>
        /// Retourne un objet d'une profession.
        /// </summary>
        public Profession UneProfession { get => uneProfession;}
        /// <summary>
        /// Retourne un objet d'un type de bénéficiers.
        /// </summary>
        public TypeBeneficiaire UnTypeBeneficiaire { get => unTypeBeneficiaire;}
        /// <summary>
        /// Retourne le nom et l'adresse d'un bénéficiaire.
        /// </summary>
        public string Afficher { get => nom + " " + rue; }
        /// <summary>
        /// Retourne le nom de l'établissement pour l'étudiant.
        /// </summary>
        public string NomEtablissemnt { get => unEtablissement.Libelle;}
        /// <summary>
        /// Retourne le nom de la profession pour le professionnel de santé.
        /// </summary>
        public string LaProfession { get => UneProfession.Libelle;}
        /// <summary>
        /// Retourne le libelle du type de bénéficiaire.
        /// </summary>
        public string LeTypeBeneficicaire { get => unTypeBeneficiaire.Libelle;}

    }
}
