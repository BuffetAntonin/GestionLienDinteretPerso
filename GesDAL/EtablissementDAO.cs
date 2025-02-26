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
    public class EtablissementDAO
    {
        private static EtablissementDAO instance;

        public static EtablissementDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new EtablissementDAO();
            }
            return instance;
        }
        private EtablissementDAO() { }

        public List<Etatblissement> GetEtablissements()
        {
            List<Etatblissement> lesEtablissements = new List<Etatblissement>();

            try
            {
                using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
                {
                    using (MySqlCommand maCommand = new MySqlCommand("spEtablissementSlt", maConnexion))
                    {
                        maCommand.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataReader monLecteur = maCommand.ExecuteReader())
                        {
                            while (monLecteur.Read())
                            {
                                int id = monLecteur.GetInt32("id");
                                string libelle = monLecteur.GetString("libelle");

                                Etatblissement unEtablissement = new Etatblissement(id, libelle);
                                lesEtablissements.Add(unEtablissement);
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erreur MySQL : " + e.Message);
            }

            return lesEtablissements;
        }


    }
}
