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

        public List<Etatblissement> GetEtatblissements()
        {
            //Declaration et création de la collection le client
            List<Etatblissement> lesEtatblissements = new List<Etatblissement>();
            Etatblissement uneEtablissement;
            //Creation de l'objet commande
            SqlCommand maCommand;
            maCommand = new SqlCommand("", Connexion.GetSqlConnection());
            //creation du data Reader
            SqlDataReader monLecteur;
            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "spEtabliessemntSlt";

            monLecteur = maCommand.ExecuteReader();
            while (monLecteur.Read())
            {
                int id;
                int.TryParse(monLecteur["id"].ToString(), out id);
                string libelle = monLecteur["nomEtablissement"].ToString();

                uneEtablissement = new Etatblissement(id, libelle);
                lesEtatblissements.Add(uneEtablissement);
            }
            Connexion.CloseConnexion();

            return lesEtatblissements;
        }

    }
}
