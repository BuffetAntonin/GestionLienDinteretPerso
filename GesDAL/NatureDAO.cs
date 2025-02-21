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
    public class NatureDAO
    {
        private static NatureDAO uneInstance;

        // cette méthode creé un objet de la classe LienDAOAvantage s'il n'existe pas déjà un
        // puis retourne la réference a cet objet
        public static NatureDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new NatureDAO();

            }
            return uneInstance;

        }
        //le constructeur par défaut est privé : il ne sera donc pas possible de créer un 
        //objet a l'exterieur de la classe avec l'instruction new...
        private NatureDAO()
        {
        }

        public List<Nature> GetNature()
        {
            List<Nature> lesNatures = new List<Nature>();

            try
            {
                using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
                {
                    using (MySqlCommand maCommand = new MySqlCommand("spNatureSlt", maConnexion))
                    {
                        maCommand.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataReader reader = maCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("id");
                                string libelle = reader.IsDBNull(reader.GetOrdinal("libelle")) ? string.Empty : reader.GetString("libelle");

                                Nature uneNature = new Nature(id, libelle);
                                lesNatures.Add(uneNature);
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erreur MySQL : " + e.Message);
            }

            return lesNatures;
        }

    }
}
