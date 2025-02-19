using GesLienDAL;
using GesLienBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
            List<Employe> lesEmployes = new List<Employe>();

            try
            {
                using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
                {
                    using (MySqlCommand maCommand = new MySqlCommand("spDelegueMedicalSlt", maConnexion))
                    {
                        maCommand.CommandType = CommandType.StoredProcedure;

                        // Ajout du paramètre pour filtrer les employés
                        maCommand.Parameters.Add("id", MySqlDbType.Int32).Value = 4;

                        using (MySqlDataReader reader = maCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("id");
                                string nom = reader.IsDBNull(reader.GetOrdinal("nom")) ? null : reader.GetString("nom");

                                Employe unEmploye = new Employe(id, nom);
                                lesEmployes.Add(unEmploye);
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erreur MySQL : " + e.Message);
            }

            return lesEmployes;
        }



    }
}
