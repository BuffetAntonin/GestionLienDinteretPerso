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
    public class AvantageDAO
    {
        private static AvantageDAO uneInstance;

        // cette méthode creé un objet de la classe LienDAOAvantage s'il n'existe pas déjà un
        // puis retourne la réference a cet objet
        public static AvantageDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AvantageDAO();

            }
            return uneInstance;

        }
        //le constructeur par défaut est privé : il ne sera donc pas possible de créer un 
        //objet a l'exterieur de la classe avec l'instruction new...
        private AvantageDAO()
        {

        }

        public List<Avantage> GetAvantage()
        {
            int id;
            float montant;
            DateTime DateDon;
            string idBeneficiaire;
            string idEmploye;
            string idNature;


            List<Avantage> lesAvantages = new List<Avantage>();
            SqlConnection maConnexion;
            maConnexion = Connexion.GetSqlConnection();
            SqlCommand maCommand;

            maCommand = new SqlCommand("", maConnexion);
            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "spGetLesAvantages";
            SqlDataReader reader = maCommand.ExecuteReader();

            while (reader.Read())
            {
                id = (int)reader["id"];
                string lemontant = null;
                if (reader["montant"] == DBNull.Value)
                {
                    montant = default(float);
                }
                else
                {
                    lemontant = reader["montant"].ToString();
                }

                if (reader["dateDon"] == DBNull.Value)
                {
                    DateDon = default(DateTime);
                }
                else
                {
                    DateDon = (DateTime)reader["dateDon"];
                }

                float.TryParse(lemontant, out montant);

                idBeneficiaire = reader["NomBeneficiaire"].ToString();

                idEmploye = reader["LibelleNature"].ToString();

                idNature = reader["NomEmploye"].ToString();


                Avantage unAvantage = new Avantage(id, montant, DateDon, new Beneficiaire(idBeneficiaire), new Employe(idEmploye), new Nature(idNature));
                lesAvantages.Add(unAvantage);


            }
            reader.Close();

            Connexion.CloseConnexion();

            return lesAvantages;


        }

        public Avantage GetUnAvantage(int idUnAvantage)
        {
            //Declaration et création de la collection le Beneficiaire
            Avantage unAvantage = null;
            Beneficiaire unBeneficiaire ;
            Employe unEmploye;
            Nature uneNature;
           
            //Creation de l'objet commande
            SqlCommand maCommand;
            maCommand = new SqlCommand("", Connexion.GetSqlConnection());
            //creation du data Reader
            SqlDataReader monLecteur;
            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "spAvantageSltUn";
            maCommand.Parameters.Add("id", System.Data.SqlDbType.Int);
            maCommand.Parameters[0].Value = idUnAvantage;
            monLecteur = maCommand.ExecuteReader();
            while (monLecteur.Read())
            {
                int id = (int)monLecteur["id"];

                float montant ;
                string lemontant = monLecteur["montant"].ToString();
                float.TryParse(lemontant, out montant);
                DateTime DateDon = (DateTime)monLecteur["DateDon"];
                int idBeneficiaire =(int) monLecteur["idBeneficiaire"];
                int idEmploye =(int) monLecteur["idEmploye"];
                int idNature = (int)monLecteur["idNature"];


                unAvantage = new Avantage(id, montant, DateDon, new Beneficiaire(idBeneficiaire), new Employe(idEmploye), new Nature(idNature));
                unBeneficiaire = new Beneficiaire(idBeneficiaire);
                unEmploye = new Employe(idEmploye);
                uneNature = new Nature(idNature);
            }
            Connexion.CloseConnexion();
            return unAvantage;
        }

        public int AjoutAvantage(Avantage unAvantage)
        {
            SqlConnection maConnexion;
            maConnexion = Connexion.GetSqlConnection();  
            //Creation de l'objet commande
            SqlCommand maCommand;
            maCommand = new SqlCommand("", maConnexion);
            //creation du data Reader
            maCommand.CommandText = "spAvantageAjout";

            maCommand.CommandType = CommandType.StoredProcedure;

            maCommand.Parameters.Add("montant", System.Data.SqlDbType.Float);
            maCommand.Parameters["montant"].Value = unAvantage.MontantDuDon;

            maCommand.Parameters.Add("dateDon", System.Data.SqlDbType.DateTime);
            maCommand.Parameters["dateDon"].Value = unAvantage.DateDuDon;

            maCommand.Parameters.Add("idBeneficiaire", System.Data.SqlDbType.Int);
            maCommand.Parameters["idBeneficiaire"].Value = unAvantage.UnBeneficiaire.Id;

            maCommand.Parameters.Add("idEmploye", System.Data.SqlDbType.Int);
            maCommand.Parameters["idEmploye"].Value = unAvantage.UnEmploye.Id;

            maCommand.Parameters.Add("idNature", System.Data.SqlDbType.Int);
            maCommand.Parameters["idNature"].Value = unAvantage.UneNature.Id;



            int nb = maCommand.ExecuteNonQuery();
            Connexion.CloseConnexion();
            return nb;


        }
        public string SupprAvantage(int idAvantage)
        {
            string msg = "";
            try
            {
                //Creation de l'objet commande
                SqlCommand maCommand;
                maCommand = new SqlCommand("", Connexion.GetSqlConnection());
                //creation du data Reader
                maCommand.CommandType = CommandType.StoredProcedure;
                maCommand.CommandText = "spAvantageSupp";
                maCommand.Parameters.Add("id", System.Data.SqlDbType.Int);
                maCommand.Parameters[0].Value = idAvantage;

                

                int nb = maCommand.ExecuteNonQuery();
                maCommand.Connection.Close();
            }
            catch (SqlException e)
            {
                msg = e.Message;
            }

            return msg;
        }

        public int ModifAvantage(Avantage unAvantage)
        {
            //Creation de l'objet commande
            SqlCommand maCommand;
            // declare la connection 
            maCommand = new SqlCommand("", Connexion.GetSqlConnection());
            maCommand.CommandType = CommandType.StoredProcedure;
            // appelle de la procedure avec les parametre
            maCommand.CommandText = "spAvantageMdf";

            // La procédure comporte des paramètres : pour le prénom
          
            maCommand.Parameters.Add("id", System.Data.SqlDbType.Int);
            maCommand.Parameters["id"].Value = unAvantage.Id;


            maCommand.Parameters.Add("montant", System.Data.SqlDbType.Float);
            maCommand.Parameters["montant"].Value = unAvantage.MontantDuDon;

            maCommand.Parameters.Add("dateDon", System.Data.SqlDbType.DateTime);
            maCommand.Parameters["dateDon"].Value = unAvantage.DateDuDon;

            maCommand.Parameters.Add("idBeneficiaire", System.Data.SqlDbType.Int);
            maCommand.Parameters["idBeneficiaire"].Value = unAvantage.UnBeneficiaire.Id;

            maCommand.Parameters.Add("idEmploye", System.Data.SqlDbType.Int);
            maCommand.Parameters["idEmploye"].Value = unAvantage.UnEmploye.Id;

            maCommand.Parameters.Add("idNature", System.Data.SqlDbType.Int);
            maCommand.Parameters["idNature"].Value = unAvantage.UneNature.Id;
            //  faire le requette
            int nb = maCommand.ExecuteNonQuery();
            maCommand.Connection.Close();
            return nb;
        }

    }
}
