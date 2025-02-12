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
            int id;
            string libelle;



            List<Nature> lesNatures = new List<Nature>();
            SqlConnection maConnexion;
            maConnexion = Connexion.GetSqlConnection();
            SqlCommand maCommand;

            maCommand = new SqlCommand("", maConnexion);
            maCommand.CommandText = "spNatureSlt";

            SqlDataReader reader = maCommand.ExecuteReader();

            while (reader.Read())
            {
                id = (int)reader["id"];


                if (reader["libelle"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = reader["libelle"].ToString();
                }
                Nature uneNature = new Nature(id, libelle);
                lesNatures.Add(uneNature);
            }
            reader.Close();

            Connexion.CloseConnexion();

            return lesNatures;
        }
    }
}
