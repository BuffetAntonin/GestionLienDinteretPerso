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
            //Declaration et création de la collection le client
            List<Profession> LesProfessions = new List<Profession>();
            Profession uneProfesion;
            //Creation de l'objet commande
            SqlCommand maCommand;
            maCommand = new SqlCommand("", Connexion.GetSqlConnection());
            //creation du data Reader
            SqlDataReader monLecteur;
            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "spProfessionSlt";

            monLecteur = maCommand.ExecuteReader();
            while (monLecteur.Read())
            {
                int id;
                int.TryParse(monLecteur["id"].ToString(), out id);
                string libelle = monLecteur["libelle"].ToString();

                uneProfesion = new Profession(id, libelle);
                LesProfessions.Add(uneProfesion);
            }
            Connexion.CloseConnexion();

            return LesProfessions;
        }

    }
}
