using GesLienBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienDAL
{
    public class TypeBeneficiaireDAO
    {
        private static TypeBeneficiaireDAO instance;

        public static TypeBeneficiaireDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new TypeBeneficiaireDAO();
            }
            return instance;
        }
        private TypeBeneficiaireDAO() { }

        public List<TypeBeneficiaire> GetTypeBeneficiaires()
        {
            //Declaration et création de la collection le client
            List<TypeBeneficiaire> lesTypeBeneficiaire = new List<TypeBeneficiaire>();
            TypeBeneficiaire unTypeBeneficiaire;
            //Creation de l'objet commande
            SqlCommand maCommand;
            maCommand = new SqlCommand("", Connexion.GetSqlConnection());
            //creation du data Reader
            SqlDataReader monLecteur;
            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "spTypeBeneficiaireSlt";

            monLecteur = maCommand.ExecuteReader();
            while (monLecteur.Read())
            {
                int id;
                int.TryParse(monLecteur["id"].ToString(), out id);
                string libelle = monLecteur["libelle"].ToString();

                unTypeBeneficiaire = new TypeBeneficiaire(id, libelle);
                lesTypeBeneficiaire.Add(unTypeBeneficiaire);
            }
            Connexion.CloseConnexion();

            return lesTypeBeneficiaire;
        }

    }
}
