using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesLienBO;

namespace GesLienDAL
{
    public class BeneficiaireDAO
    {
        #region Methode Instance de classe
        private static BeneficiaireDAO instance;
        /// <summary>
        ///  Permet d'appel les méthodes de la classe BeneficiaireDAO
        /// </summary>
        /// <returns></returns>
        public static BeneficiaireDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new BeneficiaireDAO();
            }
            return instance;
        }
        private BeneficiaireDAO() { }


        #endregion

        #region Methode Ajout
        /// <summary>
        /// Exécute la procédure d'ajout pour un bénéficiaire dans base de données et retourne un message.
        /// </summary>
        /// <param name="unBenficiaire">Récupérer un objet de la classe de bénéficiaire</param>
        /// <returns></returns>
        public string AjoutBeneficiaire(Beneficiaire unBenficiaire)
        {
            //Déclare les variables utilisées.
            string msg = "";
            try
            {
                //Creation de l'objet commande
                SqlCommand maCommand;
                // declare la connection 
                maCommand = new SqlCommand("", Connexion.GetSqlConnection());
                maCommand.CommandType = CommandType.StoredProcedure;
                // appelle de la procedure avec les parametre
                maCommand.CommandText = "spBeneficiaireAjout";
                maCommand.Parameters.Add("nom", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[0].Value = unBenficiaire.Nom;
                maCommand.Parameters.Add("rue", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[1].Value = unBenficiaire.Rue;
                maCommand.Parameters.Add("prenom", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[2].Value = unBenficiaire.Prenom;
                maCommand.Parameters.Add("numRPPS", System.Data.SqlDbType.Decimal);
                maCommand.Parameters[3].Value = unBenficiaire.NumRPPS;
                maCommand.Parameters.Add("idProfession", System.Data.SqlDbType.Int);
                maCommand.Parameters[4].Value = unBenficiaire.UneProfession.Id;
                maCommand.Parameters.Add("idEtatblissement", System.Data.SqlDbType.Int);
                maCommand.Parameters[5].Value = unBenficiaire.UnEtablissement.Id;
                maCommand.Parameters.Add("idtypeBeneficiaire", System.Data.SqlDbType.Int);
                maCommand.Parameters[6].Value = unBenficiaire.UnTypeBeneficiaire.Id;
                maCommand.Parameters.Add("numInsee", System.Data.SqlDbType.Int);
                maCommand.Parameters[7].Value = unBenficiaire.UneVille.NumInsee;
                //  faire le requette sql
                int nb = maCommand.ExecuteNonQuery();
                maCommand.Connection.Close();
                //Retourne une chaîne de caractère vide.
                return msg;
            }
            catch (SqlException e)
            {
                msg = e.Message;
            }
            //Retourne une chaîne de caractère avec un message d'erreur.
            return msg;
        }

        #endregion

        /// <summary>
        /// Exécute la procédure existe le bénéficiaire de la base de données et retourne un message avec nombre intérieur.
        /// </summary>
        /// <param name="unBenficiaire">Récupérer un objet de la classe de bénéficiaire</param>
        /// <returns></returns>
        public string ExisteBeneficiaire(Beneficiaire unBenficiaire)
        {
            //Déclare les variables utilisées.
            string msg = "";
            try
            {
                //Creation de l'objet commande
                SqlCommand maCommand;
                // declare la connection 
                maCommand = new SqlCommand("", Connexion.GetSqlConnection());
                maCommand.CommandType = CommandType.StoredProcedure;
                // appelle de la procedure avec les parametre
                maCommand.CommandText = "spExisteMemeBef";
                maCommand.Parameters.Add("nom", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[0].Value = unBenficiaire.Nom;
                maCommand.Parameters.Add("rue", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[1].Value = unBenficiaire.Rue;
                maCommand.Parameters.Add("prenom", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[2].Value = unBenficiaire.Prenom;
                maCommand.Parameters.Add("numRPPS", System.Data.SqlDbType.Decimal);
                maCommand.Parameters[3].Value = unBenficiaire.NumRPPS;
                maCommand.Parameters.Add("idProfession", System.Data.SqlDbType.Int);
                maCommand.Parameters[4].Value = unBenficiaire.UneProfession.Id;
                maCommand.Parameters.Add("idEtatblissement", System.Data.SqlDbType.Int);
                maCommand.Parameters[5].Value = unBenficiaire.UnEtablissement.Id;
                maCommand.Parameters.Add("idtypeBeneficiaire", System.Data.SqlDbType.Int);
                maCommand.Parameters[6].Value = unBenficiaire.UnTypeBeneficiaire.Id;
                maCommand.Parameters.Add("numInsee", System.Data.SqlDbType.Int);
                maCommand.Parameters[7].Value = unBenficiaire.UneVille.NumInsee;
                //  faire le requette
                msg = maCommand.ExecuteScalar().ToString();
                Connexion.CloseConnexion();
                //Retourne un nombre dans une chaîne de caractère.
                return msg;
            }
            catch (SqlException e)
            {
                //Retourne une chaîne de caractère avec un message d'erreur.
                msg = e.Message;
            }
            return msg;
        }

        #region Methode Get
        /// <summary>
        /// Exécute la procédure de sélection pour les bénéficiaires d'une année d'un avantage dans la base de données et retourne un message.
        /// </summary>
        /// <param name="annee">Récupère un nombre entier correspondant à l'année du bénéficiaire.</param>
        /// <param name="msg">Retourne une chaîne de caractère vide si la sélection c'est bien passé sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public List<Beneficiaire> GetBeneficiairesParAvantagesAnnee(int annee, out string msg)
        {
            //Declaration et création de la collection le client
            List<Beneficiaire> lesBeneficiaires = new List<Beneficiaire>();
            try
            {
                Beneficiaire unBeneficiaire;
                TypeBeneficiaire unTypeBeneficiaire;
                //Creation de l'objet commande
                SqlCommand maCommand;
                maCommand = new SqlCommand("", Connexion.GetSqlConnection());
                //creation du data Reader
                SqlDataReader monLecteur;
                maCommand.CommandType = CommandType.StoredProcedure;
                maCommand.CommandText = "spBeneficiaireParAvantages";
                maCommand.Parameters.Add("annee", System.Data.SqlDbType.Int);
                maCommand.Parameters[0].Value = annee;
                monLecteur = maCommand.ExecuteReader();
                //Lis le date reader récupère et crée un objet de la classe bénéficière
                while (monLecteur.Read())
                {
                    string nom = monLecteur["nom"].ToString();
                    string adresse = monLecteur["adresse"].ToString();
                    unTypeBeneficiaire = new TypeBeneficiaire(monLecteur["TypeBeneficiaire"].ToString());
                    unBeneficiaire = new Beneficiaire(nom, adresse, unTypeBeneficiaire);
                    lesBeneficiaires.Add(unBeneficiaire);
                }
                Connexion.CloseConnexion();
                msg = "";
            }
            catch (SqlException e)
            {
                msg = e.Message;
            }
            //Retourne une liste de bénéficiers et un message d'erreur.
            return lesBeneficiaires;
        }
        /// <summary>
        /// Exécute la procédure de sélection pour les bénéficiaires d'une période de la convention dans la base de données et retourne un message.
        /// </summary>
        /// <param name="dateDebut">Récupère la date du début.</param>
        /// <param name="dateFin">Récupère la date du fin.</param>
        /// <param name="msg">Retourne une chaîne de caractère vide si la sélection c'est bien passé sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public List<Beneficiaire> GetBeneficiairesConventionPeriode(DateTime dateDebut, DateTime dateFin, out string msg)
        {

            //Declaration et création de la collection le client
            List<Beneficiaire> lesBeneficiaires = new List<Beneficiaire>();
            try
            {
                Beneficiaire unBeneficiaire;
                TypeBeneficiaire unTypeBeneficiaire;

                //Creation de l'objet commande
                SqlCommand maCommand;
                maCommand = new SqlCommand("", Connexion.GetSqlConnection());
                //creation du data Reader
                SqlDataReader monLecteur;
                maCommand.CommandType = CommandType.StoredProcedure;
                maCommand.CommandText = "spBeneficiaireConventionPeriode";
                maCommand.Parameters.Add("dateDebut", System.Data.SqlDbType.DateTime);
                maCommand.Parameters[0].Value = dateDebut;
                maCommand.Parameters.Add("dateFin", System.Data.SqlDbType.DateTime);
                maCommand.Parameters[1].Value = dateFin;
                monLecteur = maCommand.ExecuteReader();
                //Lis le date reader récupère et crée un objet de la classe bénéficière
                while (monLecteur.Read())
                {

                    string nom = monLecteur["nom"].ToString();
                    string adresse = monLecteur["adresse"].ToString();
                    unTypeBeneficiaire = new TypeBeneficiaire(monLecteur["TypeBeneficiaire"].ToString());
                    unBeneficiaire = new Beneficiaire(nom, adresse, unTypeBeneficiaire);
                    lesBeneficiaires.Add(unBeneficiaire);
                }
                Connexion.CloseConnexion();
                msg = "";
            }
            catch (SqlException e)
            {
                msg = e.Message;
            }
            //Retourne une liste de bénéficiers et un message d'erreur.
            return lesBeneficiaires;
        }
        /// <summary>
        /// Exécute la procédure de sélection pour les bénéficiaires d'une ville dans la base de données et retourne un message.
        /// </summary>
        /// <param name="numInsee">Récupère un nombre entier correspondant à la ville.</param>
        /// <param name="msg">Retourne une chaîne de caractère vide si la sélection c'est bien passé sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public List<Beneficiaire> GetBeneficiairesParVille(int numInsee, out string msg)
        {
            List<Beneficiaire> lesBeneficiaires = new List<Beneficiaire>();
            try
            {
                //Declaration et création de la collection le client
                Beneficiaire unBeneficiaire;
                TypeBeneficiaire unTypeBeneficiaire;
                //Creation de l'objet commande
                SqlCommand maCommand;
                maCommand = new SqlCommand("", Connexion.GetSqlConnection());
                //creation du data Reader
                SqlDataReader monLecteur;
                maCommand.CommandType = CommandType.StoredProcedure;
                maCommand.CommandText = "spBeneficiaireParVille";
                maCommand.Parameters.Add("numInsee", System.Data.SqlDbType.Int);
                maCommand.Parameters[0].Value = numInsee;
                monLecteur = maCommand.ExecuteReader();
                //Lis le date reader récupère et crée un objet de la classe bénéficière
                while (monLecteur.Read())
                {
                    string nom = monLecteur["nom"].ToString();
                    string adresse = monLecteur["adresse"].ToString();
                    unTypeBeneficiaire = new TypeBeneficiaire(monLecteur["TypeBeneficiaire"].ToString());
                    unBeneficiaire = new Beneficiaire(nom, adresse, unTypeBeneficiaire);
                    lesBeneficiaires.Add(unBeneficiaire);
                }
                Connexion.CloseConnexion();
                msg = "";
            }
            catch (SqlException e)
            {
                msg = e.Message;
            }
            //Retourne une liste de bénéficiers et un message d'erreur.
            return lesBeneficiaires;
        }
        /// <summary>
        /// Exécute la procédure de sélection pour les bénéficiaires d'une profession dans la base de données et retourne un message.
        /// </summary>
        /// <param name="idProfession">Récupère un nombre entier correspondant à la profession.</param>
        /// <param name="msg">Retourne une chaîne de caractère vide si la sélection c'est bien passé sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public List<Beneficiaire> GetBeneficiairesParProfession(int idProfession, out string msg)
        {
            List<Beneficiaire> lesBeneficiaires = new List<Beneficiaire>();
            try
            {
                //Declaration et création de la collection le client
                Beneficiaire unBeneficiaire;
                Profession uneProfession;
                TypeBeneficiaire unTypeBeneficiaire;

                //Creation de l'objet commande
                SqlCommand maCommand;
                maCommand = new SqlCommand("", Connexion.GetSqlConnection());
                //creation du data Reader
                SqlDataReader monLecteur;
                maCommand.CommandType = CommandType.StoredProcedure;
                maCommand.CommandText = "spBeneficiaireParProfession";
                maCommand.Parameters.Add("idProfession", System.Data.SqlDbType.Int);
                maCommand.Parameters[0].Value = idProfession;
                monLecteur = maCommand.ExecuteReader();
                //Lis le date reader récupère et crée un objet de la classe bénéficière
                while (monLecteur.Read())
                {

                    string nom = monLecteur["nom"].ToString();
                    string prenom = monLecteur["prenom"].ToString();
                    string adresse = monLecteur["adresse"].ToString();
                    int numRPPS = (int)monLecteur["numRPPS"];
                    int idProf = (int)monLecteur["idProfession"];
                    unTypeBeneficiaire = new TypeBeneficiaire(monLecteur["TypeBeneficiaire"].ToString());
                    uneProfession = new Profession(idProf);
                    unBeneficiaire = new Beneficiaire(nom, adresse, prenom, numRPPS, uneProfession, unTypeBeneficiaire);
                    lesBeneficiaires.Add(unBeneficiaire);
                }
                Connexion.CloseConnexion();
                msg = "";
            }
            catch (SqlException e)
            {
                msg = e.Message;
            }
            //Retourne une liste de bénéficiers et un message d'erreur.
            return lesBeneficiaires;
        }
        /// <summary>
        /// Exécute la procédure de sélection pour les bénéficiaires dans la base de données et retourne un message.
        /// </summary>
        /// <param name="msg">Retourne une chaîne de caractère vide si la sélection c'est bien passé sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public List<Beneficiaire> GetLesBeneficiaires(out string msg)
        {
            //Declaration et création de la collection le client
            List<Beneficiaire> lesBeneficiaires = new List<Beneficiaire>();
            try
            {
                Beneficiaire unBeneficiaire;
                TypeBeneficiaire unTypeBeneficiaire;
                Profession uneProfession;
                Etatblissement unEtatblissement;
                //Creation de l'objet commande
                SqlCommand maCommand;
                maCommand = new SqlCommand("", Connexion.GetSqlConnection());
                //creation du data Reader
                SqlDataReader monLecteur;
                maCommand.CommandType = CommandType.StoredProcedure;
                maCommand.CommandText = "spBeneficiaire";
                monLecteur = maCommand.ExecuteReader();
                //Lis le date reader récupère et crée un objet de la classe bénéficière
                while (monLecteur.Read())
                {
                    string vl = monLecteur["id"].ToString();
                    int id;
                    int.TryParse(vl, out id);
                    string nom = monLecteur["nom"].ToString();
                    string adresse = monLecteur["adresse"].ToString();
                    unEtatblissement = new Etatblissement(monLecteur["nomEtablissement"].ToString());
                    uneProfession = new Profession(monLecteur["libelleProfession"].ToString());
                    unTypeBeneficiaire = new TypeBeneficiaire(monLecteur["TypeBeneficiaire"].ToString());
                    unBeneficiaire = new Beneficiaire(id, nom, adresse, unEtatblissement, uneProfession, unTypeBeneficiaire);
                    lesBeneficiaires.Add(unBeneficiaire);
                }
                Connexion.CloseConnexion();
                msg = "";
            }
            catch (SqlException e)
            {
                msg = e.Message;
            }
            //Retourne une liste de bénéficiers et un message d'erreur.
            return lesBeneficiaires;
        }
        /// <summary>
        /// Exécute la procédure de sélection pour un bénéficiaire dans la base de données et retourne un message.
        /// </summary>
        /// <param name="idUnBeneficiaire">Récupère un nombre entier correspondant à un bénéficiaire</param>
        /// <param name="msg">Retourne une chaîne de caractère vide si la sélection c'est bien passé sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public Beneficiaire GetUnBeneficiaire(int idUnBeneficiaire, out string msg)
        {
            //Declaration et création de la collection le Beneficiaire
            Beneficiaire unBeneficiaire = null; 
            try
            {
                TypeBeneficiaire unTypeBeneficiaire;
                Profession uneProfession;
                Etatblissement unEtatblissement;
                Ville uneVille;
                int numRPPS;
                int idEtablissement;
                int idProfession;
                //Creation de l'objet commande
                SqlCommand maCommand;
                maCommand = new SqlCommand("", Connexion.GetSqlConnection());
                //creation du data Reader
                SqlDataReader monLecteur;
                maCommand.CommandType = CommandType.StoredProcedure;
                maCommand.CommandText = "spBeneficiaireSltUn";
                maCommand.Parameters.Add("id", System.Data.SqlDbType.Int);
                maCommand.Parameters[0].Value = idUnBeneficiaire;
                monLecteur = maCommand.ExecuteReader();
                //Lis le date reader récupère et crée un objet de la classe bénéficière
                monLecteur.Read();
                string nom = monLecteur["nom"].ToString();
                string prenom = monLecteur["prenom"].ToString();
                string rue = monLecteur["rue"].ToString();
                if (monLecteur["numRPPS"] == DBNull.Value)
                {
                    numRPPS = default(int);
                }
                else
                {
                    numRPPS = (int)monLecteur["numRPPS"];
                }
                if (monLecteur["idEtatblissement"] == DBNull.Value)
                {
                    idEtablissement = default(int);
                }
                else
                {
                    idEtablissement = (int)monLecteur["idEtatblissement"];

                }
                if (monLecteur["idProfession"] == DBNull.Value)
                {
                    idProfession = default(int);
                }
                else
                {
                    idProfession = (int)monLecteur["idProfession"];

                }
                int idTypeBeneficiaire = (int)monLecteur["idtypeBeneficiaire"];
                int numInsee = (int)monLecteur["numInsee"];
                unEtatblissement = new Etatblissement(idEtablissement);
                uneProfession = new Profession(idProfession);
                uneVille = new Ville(numInsee);
                unTypeBeneficiaire = new TypeBeneficiaire(idTypeBeneficiaire);
                unBeneficiaire = new Beneficiaire(idUnBeneficiaire, nom, rue, prenom, numRPPS, uneVille, unEtatblissement, uneProfession, unTypeBeneficiaire);
                Connexion.CloseConnexion();
                msg = "";
            }
            catch (SqlException e)
            {
                msg = e.Message;
            }
            //Retourne un bénéficiers et un message d'erreur.
            return unBeneficiaire;

        }
        #endregion

        #region Methode Modification
        /// <summary>
        /// Exécute la procédure modification pour un bénéficiaire dans base de données et retourne un message.
        /// </summary>
        /// <param name="unBenficiaire"></param>
        /// <returns></returns>
        public string ModifBeneficiaire(Beneficiaire unBenficiaire)
        {
            //Déclare les variables utilisées.
            string msg = "";
            try
            {
                //Creation de l'objet commande
                SqlCommand maCommand;
                // declare la connection 
                maCommand = new SqlCommand("", Connexion.GetSqlConnection());
                maCommand.CommandType = CommandType.StoredProcedure;
                // appelle de la procedure avec les parametre
                maCommand.CommandText = "spBeneficiaireMdf";
                maCommand.Parameters.Add("id", System.Data.SqlDbType.Int);
                maCommand.Parameters[0].Value = unBenficiaire.Id;
                maCommand.Parameters.Add("nom", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[1].Value = unBenficiaire.Nom;
                maCommand.Parameters.Add("rue", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[2].Value = unBenficiaire.Rue;
                maCommand.Parameters.Add("prenom", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[3].Value = unBenficiaire.Prenom;
                maCommand.Parameters.Add("numRPPS", System.Data.SqlDbType.Decimal);
                maCommand.Parameters[4].Value = unBenficiaire.NumRPPS;
                maCommand.Parameters.Add("idProfession", System.Data.SqlDbType.Int);
                maCommand.Parameters[5].Value = unBenficiaire.UneProfession.Id;
                maCommand.Parameters.Add("idEtatblissement", System.Data.SqlDbType.Int);
                maCommand.Parameters[6].Value = unBenficiaire.UnEtablissement.Id;
                maCommand.Parameters.Add("idtypeBeneficiaire", System.Data.SqlDbType.Int);
                maCommand.Parameters[7].Value = unBenficiaire.UnTypeBeneficiaire.Id;
                maCommand.Parameters.Add("numInsee", System.Data.SqlDbType.Int);
                maCommand.Parameters[8].Value = unBenficiaire.UneVille.NumInsee;
                //  faire le requette
                int nb = maCommand.ExecuteNonQuery();
                maCommand.Connection.Close();
                //Retourne un nombre dans une chaîne de caractère.
                return msg;
            }
            catch (SqlException e)
            {
                //Retourne une chaîne de caractère avec un message d'erreur.
                msg = e.Message;
            }
            return msg; ;
        }

        #endregion

        #region Methode Supprime
        /// <summary>
        /// Exécute la procédure supprimée pour un bénéficiaire dans base de données pour un bénéficiaire et retourne un message.
        /// </summary>
        /// <param name="idBenficiaire">Récupérer un objet de la classe de bénéficiaire</param>
        /// <returns></returns>
        public string supprBeneficiaire(int idBenficiaire)
        {
            //Déclare les variables utilisées.
            string msg = "";
            try
            {
                //Creation de l'objet commande
                SqlCommand maCommand;
                maCommand = new SqlCommand("", Connexion.GetSqlConnection());
                //creation du data Reader
                maCommand.CommandType = CommandType.StoredProcedure;
                maCommand.CommandText = "spBeneficiaireSupp";
                maCommand.Parameters.Add("id", System.Data.SqlDbType.Int);
                maCommand.Parameters[0].Value = idBenficiaire;
                int nb = maCommand.ExecuteNonQuery();
                maCommand.Connection.Close();
            }
            catch (SqlException e)
            {
                msg = e.Message;
            }
            //Retourne une chaîne de caractère vide ou un message d'erreur.
            return msg;
        }
        #endregion


    }
}
