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
    public class VilleDAO
    {
        private static VilleDAO instance;

        public static VilleDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new VilleDAO();
            }
            return instance;
        }
        private VilleDAO() { }

        public List<Ville> GetVilles()
        {
            List<Ville> lesVilles = new List<Ville>();

            try
            {
                using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
                {
                    using (MySqlCommand maCommand = new MySqlCommand("spVilleSlt", maConnexion))
                    {
                        maCommand.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataReader monLecteur = maCommand.ExecuteReader())
                        {
                            while (monLecteur.Read())
                            {
                                int id = monLecteur.GetInt32("numInsee");
                                string libelle = monLecteur.IsDBNull(monLecteur.GetOrdinal("nomVille")) ? string.Empty : monLecteur.GetString("nomVille");
                                int codePostal = monLecteur.GetInt32("codePostal");

                                Ville uneVille = new Ville(id, libelle, codePostal);
                                lesVilles.Add(uneVille);
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erreur MySQL : " + e.Message);
            }

            return lesVilles;
        }


    }
}
