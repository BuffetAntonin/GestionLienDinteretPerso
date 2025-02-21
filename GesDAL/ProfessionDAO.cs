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
    public class ProfessionDAO
    {
        private static ProfessionDAO instance;

        public static ProfessionDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new ProfessionDAO();
            }
            return instance;
        }
        private ProfessionDAO() { }

        public List<Profession> GetProfessions()
        {
            List<Profession> lesProfessions = new List<Profession>();

            try
            {
                using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
                {
                    using (MySqlCommand maCommand = new MySqlCommand("spProfessionSlt", maConnexion))
                    {
                        maCommand.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataReader monLecteur = maCommand.ExecuteReader())
                        {
                            while (monLecteur.Read())
                            {
                                int id = monLecteur.GetInt32("id");
                                string libelle = monLecteur.IsDBNull(monLecteur.GetOrdinal("libelle")) ? string.Empty : monLecteur.GetString("libelle");

                                Profession uneProfession = new Profession(id, libelle);
                                lesProfessions.Add(uneProfession);
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erreur MySQL : " + e.Message);
            }

            return lesProfessions;
        }


    }
}
