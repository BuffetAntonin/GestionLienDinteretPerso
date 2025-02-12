using GesLienDAL;
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
    public class EmployeDAO
    {
        private static EmployeDAO uneInstance;

        // cette méthode creé un objet de la classe LienDAOAvantage s'il n'existe pas déjà un
        // puis retourne la réference a cet objet
        public static EmployeDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EmployeDAO();

            }
            return uneInstance;

        }
        //le constructeur par défaut est privé : il ne sera donc pas possible de créer un 
        //objet a l'exterieur de la classe avec l'instruction new...
        private EmployeDAO()
        {

        }
        public List<Employe> GetEmploye()
        {
            int id;
            string nom;
            
            

            List<Employe> lesEmployes = new List<Employe>();
            SqlConnection maConnexion;
            maConnexion = Connexion.GetSqlConnection();
            SqlCommand maCommand;

            maCommand = new SqlCommand("", maConnexion);
            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "spDelegueMedicalSlt";

            maCommand.Parameters.Add("id", SqlDbType.Int);
            maCommand.Parameters["id"].Value = 4;

            SqlDataReader reader = maCommand.ExecuteReader();


            while (reader.Read())
            {
               id = (int)reader["id"];

                if (reader["nom"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = reader["nom"].ToString();
                }

                Employe unEmploye = new Employe(id, nom);
                lesEmployes.Add(unEmploye);
            }

            reader.Close();

            Connexion.CloseConnexion();

            return lesEmployes;
        }


    }
 }
