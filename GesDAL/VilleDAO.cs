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
            //Declaration et création de la collection le client
            List<Ville> lesVille = new List<Ville>();
            Ville uneVille;
            //Creation de l'objet commande
            SqlCommand maCommand;
            maCommand = new SqlCommand("", Connexion.GetSqlConnection());
            //creation du data Reader
            SqlDataReader monLecteur;
            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "spVilleSlt";

            monLecteur = maCommand.ExecuteReader();
            while (monLecteur.Read())
            {
                int id;
                int.TryParse(monLecteur["numInsee"].ToString(), out id);
                string libelle = monLecteur["nomVille"].ToString();
                int codePostal;
                int.TryParse(monLecteur["codePostal"].ToString(), out codePostal);

                uneVille = new Ville(id, libelle, codePostal);
                lesVille.Add(uneVille);
            }
            Connexion.CloseConnexion();

            return lesVille;
        }

    }
}
