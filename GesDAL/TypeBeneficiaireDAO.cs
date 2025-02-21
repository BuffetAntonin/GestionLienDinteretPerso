using GesLienBO;
using MySql.Data.MySqlClient;
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
            List<TypeBeneficiaire> lesTypeBeneficiaires = new List<TypeBeneficiaire>();

            try
            {
                using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
                {
                    using (MySqlCommand maCommand = new MySqlCommand("spTypeBeneficiaireSlt", maConnexion))
                    {
                        maCommand.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataReader monLecteur = maCommand.ExecuteReader())
                        {
                            while (monLecteur.Read())
                            {
                                int id = monLecteur.GetInt32("id");
                                string libelle = monLecteur.IsDBNull(monLecteur.GetOrdinal("libelle")) ? string.Empty : monLecteur.GetString("libelle");

                                TypeBeneficiaire unTypeBeneficiaire = new TypeBeneficiaire(id, libelle);
                                lesTypeBeneficiaires.Add(unTypeBeneficiaire);
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erreur MySQL : " + e.Message);
            }

            return lesTypeBeneficiaires;
        }


    }
}
