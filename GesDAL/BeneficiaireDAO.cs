using System;
using System.Collections.Generic;
using System.Data;
using GesLienBO;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace GesLienDAL
{
    public class BeneficiaireDAO
    {
        #region Methode Instance de classe
        private static BeneficiaireDAO instance;

        /// <summary>
        /// Permet d'appeler les méthodes de la classe BeneficiaireDAO.
        /// </summary>
        /// <returns>Une instance unique de BeneficiaireDAO</returns>
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
        /// Exécute la procédure d'ajout pour un bénéficiaire dans la base de données et retourne un message.
        /// </summary>
        /// <param name="unBeneficiaire">Récupérer un objet de la classe de bénéficiaire</param>
        /// <returns></returns>
        public string AjoutBeneficiaire(Beneficiaire unBeneficiaire)
        {
            // Déclare la variable de message d'erreur.
            string msg = "";

            try
            {
                // Création de l'objet commande MySQL
                MySqlCommand maCommand = new MySqlCommand("", Connexion.GetMySqlConnection());
                maCommand.CommandType = CommandType.StoredProcedure;

                // Appel de la procédure stockée avec les paramètres
                maCommand.CommandText = "spBeneficiaireAjout";
                maCommand.Parameters.Add("nom", MySqlDbType.VarChar).Value = unBeneficiaire.Nom;
                maCommand.Parameters.Add("rue", MySqlDbType.VarChar).Value = unBeneficiaire.Rue;
                maCommand.Parameters.Add("prenom", MySqlDbType.VarChar).Value = unBeneficiaire.Prenom;
                maCommand.Parameters.Add("numRPPS", MySqlDbType.Decimal).Value = unBeneficiaire.NumRPPS;
                maCommand.Parameters.Add("idProfession", MySqlDbType.Int32).Value = unBeneficiaire.UneProfession.Id;
                maCommand.Parameters.Add("idEtablissement", MySqlDbType.Int32).Value = unBeneficiaire.UnEtablissement.Id;
                maCommand.Parameters.Add("idTypeBeneficiaire", MySqlDbType.Int32).Value = unBeneficiaire.UnTypeBeneficiaire.Id;
                maCommand.Parameters.Add("numInsee", MySqlDbType.Int32).Value = unBeneficiaire.UneVille.NumInsee;

                // Exécution de la requête
                int nb = maCommand.ExecuteNonQuery();

                // Fermeture de la connexion
                maCommand.Connection.Close();

                // Retourne une chaîne vide si tout s'est bien passé.
                return msg;
            }
            catch (MySqlException e)
            {
                msg = e.Message;
            }

            // Retourne un message d'erreur en cas d'exception.
            return msg;
        }

        #endregion

        #region Methode Existence
        public string ExisteBeneficiaire(Beneficiaire unBeneficiaire)
        {
            // Déclare la variable pour stocker le message (ou le résultat).
            string msg = "";

            try
            {
                // Création de l'objet commande
                MySqlCommand maCommand = new MySqlCommand("", Connexion.GetMySqlConnection());
                maCommand.CommandType = CommandType.StoredProcedure;

                // Appelle de la procédure stockée
                maCommand.CommandText = "spExisteMemeBef";
                maCommand.Parameters.Add("nom", MySqlDbType.VarChar).Value = unBeneficiaire.Nom;
                maCommand.Parameters.Add("rue", MySqlDbType.VarChar).Value = unBeneficiaire.Rue;
                maCommand.Parameters.Add("prenom", MySqlDbType.VarChar).Value = unBeneficiaire.Prenom;
                maCommand.Parameters.Add("numRPPS", MySqlDbType.Decimal).Value = unBeneficiaire.NumRPPS;
                maCommand.Parameters.Add("idProfession", MySqlDbType.Int32).Value = unBeneficiaire.UneProfession.Id;
                maCommand.Parameters.Add("idEtablissement", MySqlDbType.Int32).Value = unBeneficiaire.UnEtablissement.Id;
                maCommand.Parameters.Add("idTypeBeneficiaire", MySqlDbType.Int32).Value = unBeneficiaire.UnTypeBeneficiaire.Id;
                maCommand.Parameters.Add("numInsee", MySqlDbType.Int32).Value = unBeneficiaire.UneVille.NumInsee;

                // Exécuter la requête et récupérer le résultat
                object result = maCommand.ExecuteScalar();
                if (result != null)
                {
                    msg = result.ToString();
                }

                // Fermer la connexion après exécution
                Connexion.CloseConnexion();

                // Retourne le résultat
                return msg;
            }
            catch (MySqlException e)
            {
                // Retourne le message d'erreur en cas d'exception
                msg = e.Message;
            }

            return msg;
        }

        #endregion

        #region Methode Get
        /// <summary>
        /// Exécute la procédure de sélection pour les bénéficiaires d'une année d'un avantage dans la base de données et retourne un message.
        /// </summary>
        /// <param name="annee">Récupère un nombre entier correspondant à l'année du bénéficiaire.</param>
        /// <param name="msg">Retourne une chaîne de caractère vide si la sélection s'est bien passée, sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public List<Beneficiaire> GetBeneficiairesParAvantagesAnnee(int annee, out string msg)
        {
            // Déclaration et création de la collection des bénéficiaires
            List<Beneficiaire> lesBeneficiaires = new List<Beneficiaire>();
            msg = ""; // Initialisation du message

            try
            {
                Beneficiaire unBeneficiaire;
                TypeBeneficiaire unTypeBeneficiaire;

                // Création de l'objet commande
                MySqlCommand maCommand = new MySqlCommand("", Connexion.GetMySqlConnection());

                // Création du data reader
                MySqlDataReader monLecteur;

                maCommand.CommandType = CommandType.StoredProcedure;

                // Appelle de la procédure stockée avec les paramètres
                maCommand.CommandText = "spBeneficiaireParAvantages";
                maCommand.Parameters.Add("annee", MySqlDbType.Int32);
                maCommand.Parameters[0].Value = annee;

                // Exécution de la requête
                monLecteur = maCommand.ExecuteReader();

                // Lecture du data reader, récupération et création des objets de la classe Bénéficiaire
                while (monLecteur.Read())
                {
                    string nom = monLecteur["nom"].ToString();
                    string adresse = monLecteur["adresse"].ToString();

                    // Création d'un objet TypeBeneficiaire
                    unTypeBeneficiaire = new TypeBeneficiaire(monLecteur["TypeBeneficiaire"].ToString());

                    // Création de l'objet Bénéficiaire
                    unBeneficiaire = new Beneficiaire(nom, adresse, unTypeBeneficiaire);

                    // Ajout du bénéficiaire à la liste
                    lesBeneficiaires.Add(unBeneficiaire);
                }

                // Fermeture du DataReader après utilisation
                monLecteur.Close();

                // Fermeture de la connexion
                Connexion.CloseConnexion();
            }
            catch (MySqlException e)
            {
                // Capture du message d'erreur SQL en cas d'exception
                msg = e.Message;
            }

            // Retourne une liste de bénéficiaires et un message d'erreur s'il y en a un
            return lesBeneficiaires;
        }

        /// <summary>
        /// Exécute la procédure de sélection pour les bénéficiaires d'une période de la convention dans la base de données et retourne un message.
        /// </summary>
        /// <param name="dateDebut">Récupère la date du début.</param>
        /// <param name="dateFin">Récupère la date de fin.</param>
        /// <param name="msg">Retourne une chaîne de caractère vide si la sélection s'est bien passée, sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public List<Beneficiaire> GetBeneficiairesConventionPeriode(DateTime dateDebut, DateTime dateFin, out string msg)
        {
            // Déclaration et création de la collection des bénéficiaires
            List<Beneficiaire> lesBeneficiaires = new List<Beneficiaire>();
            msg = ""; // Initialisation du message

            try
            {
                Beneficiaire unBeneficiaire;
                TypeBeneficiaire unTypeBeneficiaire;

                // Création de l'objet commande
                MySqlCommand maCommand = new MySqlCommand("", Connexion.GetMySqlConnection());

                // Création du data reader
                MySqlDataReader monLecteur;

                maCommand.CommandType = CommandType.StoredProcedure;

                // Appelle de la procédure stockée avec les paramètres
                maCommand.CommandText = "spBeneficiaireConventionPeriode";
                maCommand.Parameters.Add("dateDebut", MySqlDbType.DateTime);
                maCommand.Parameters[0].Value = dateDebut;
                maCommand.Parameters.Add("dateFin", MySqlDbType.DateTime);
                maCommand.Parameters[1].Value = dateFin;

                // Exécution de la requête
                monLecteur = maCommand.ExecuteReader();

                // Lecture du data reader, récupération et création des objets de la classe Bénéficiaire
                while (monLecteur.Read())
                {
                    string nom = monLecteur["nom"].ToString();
                    string adresse = monLecteur["adresse"].ToString();

                    // Création d'un objet TypeBeneficiaire
                    unTypeBeneficiaire = new TypeBeneficiaire(monLecteur["TypeBeneficiaire"].ToString());

                    // Création de l'objet Bénéficiaire
                    unBeneficiaire = new Beneficiaire(nom, adresse, unTypeBeneficiaire);

                    // Ajout du bénéficiaire à la liste
                    lesBeneficiaires.Add(unBeneficiaire);
                }

                // Fermeture du DataReader après utilisation
                monLecteur.Close();

                // Fermeture de la connexion
                Connexion.CloseConnexion();
            }
            catch (MySqlException e)
            {
                // Capture du message d'erreur SQL en cas d'exception
                msg = e.Message;
            }

            // Retourne une liste de bénéficiaires et un message d'erreur s'il y en a un
            return lesBeneficiaires;
        }

        /// <summary>
        /// Exécute la procédure de sélection pour les bénéficiaires d'une ville dans la base de données et retourne un message.
        /// </summary>
        /// <param name="numInsee">Récupère un nombre entier correspondant à la ville.</param>
        /// <param name="msg">Retourne une chaîne de caractère vide si la sélection s'est bien passée, sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public List<Beneficiaire> GetBeneficiairesParVille(int numInsee, out string msg)
        {
            // Déclaration et création de la collection des bénéficiaires
            List<Beneficiaire> lesBeneficiaires = new List<Beneficiaire>();
            msg = ""; // Initialisation du message

            try
            {
                Beneficiaire unBeneficiaire;
                TypeBeneficiaire unTypeBeneficiaire;

                // Création de l'objet commande
                MySqlCommand maCommand = new MySqlCommand("", Connexion.GetMySqlConnection());

                // Création du DataReader
                MySqlDataReader monLecteur;

                maCommand.CommandType = CommandType.StoredProcedure;

                // Appel de la procédure stockée avec les paramètres
                maCommand.CommandText = "spBeneficiaireParVille";
                maCommand.Parameters.Add("numInsee", MySqlDbType.Int32).Value = numInsee;

                // Exécution de la requête
                monLecteur = maCommand.ExecuteReader();

                // Lecture du DataReader, récupération et création des objets de la classe Bénéficiaire
                while (monLecteur.Read())
                {
                    string nom = monLecteur["nom"].ToString();
                    string adresse = monLecteur["adresse"].ToString();

                    // Création d'un objet TypeBeneficiaire
                    unTypeBeneficiaire = new TypeBeneficiaire(monLecteur["TypeBeneficiaire"].ToString());

                    // Création de l'objet Bénéficiaire
                    unBeneficiaire = new Beneficiaire(nom, adresse, unTypeBeneficiaire);

                    // Ajout du bénéficiaire à la liste
                    lesBeneficiaires.Add(unBeneficiaire);
                }

                // Fermeture du DataReader après utilisation
                monLecteur.Close();

                // Fermeture de la connexion
                Connexion.CloseConnexion();
            }
            catch (MySqlException e)
            {
                // Capture du message d'erreur SQL en cas d'exception
                msg = e.Message;
            }

            // Retourne une liste de bénéficiaires et un message d'erreur s'il y en a un
            return lesBeneficiaires;
        }

        /// <summary>
        /// Exécute la procédure de sélection pour les bénéficiaires d'une profession dans la base de données et retourne un message.
        /// </summary>
        /// <param name="idProfession">Récupère un nombre entier correspondant à la profession.</param>
        /// <param name="msg">Retourne une chaîne de caractère vide si la sélection s'est bien passée, sinon retourne le message d'erreur.</param>
        /// <returns>Liste des bénéficiaires correspondant à la profession.</returns>
        public List<Beneficiaire> GetBeneficiairesParProfession(int idProfession, out string msg)
        {
            // Déclaration et création de la collection des bénéficiaires
            List<Beneficiaire> lesBeneficiaires = new List<Beneficiaire>();
            msg = ""; // Initialisation du message

            try
            {
                Beneficiaire unBeneficiaire;
                Profession uneProfession;
                TypeBeneficiaire unTypeBeneficiaire;

                // Création de l'objet commande
                MySqlCommand maCommand = new MySqlCommand("", Connexion.GetMySqlConnection());

                // Création du DataReader
                MySqlDataReader monLecteur;

                maCommand.CommandType = CommandType.StoredProcedure;

                // Appel de la procédure stockée avec les paramètres
                maCommand.CommandText = "spBeneficiaireParProfession";
                maCommand.Parameters.Add("idProfession", MySqlDbType.Int32).Value = idProfession;

                // Exécution de la requête
                monLecteur = maCommand.ExecuteReader();

                // Lecture du DataReader, récupération et création des objets de la classe Bénéficiaire
                while (monLecteur.Read())
                {
                    string nom = monLecteur["nom"].ToString();
                    string prenom = monLecteur["prenom"].ToString();
                    string adresse = monLecteur["adresse"].ToString();
                    int numRPPS = Convert.ToInt32(monLecteur["numRPPS"]);
                    int idProf = Convert.ToInt32(monLecteur["idProfession"]);

                    // Création des objets associés
                    unTypeBeneficiaire = new TypeBeneficiaire(monLecteur["TypeBeneficiaire"].ToString());
                    uneProfession = new Profession(idProf);
                    unBeneficiaire = new Beneficiaire(nom, adresse, prenom, numRPPS, uneProfession, unTypeBeneficiaire);

                    // Ajout du bénéficiaire à la liste
                    lesBeneficiaires.Add(unBeneficiaire);
                }

                // Fermeture du DataReader après utilisation
                monLecteur.Close();

                // Fermeture de la connexion
                Connexion.CloseConnexion();
            }
            catch (MySqlException e)
            {
                // Capture du message d'erreur SQL en cas d'exception
                msg = e.Message;
            }

            // Retourne une liste de bénéficiaires et un message d'erreur s'il y en a un
            return lesBeneficiaires;
        }

        /// <summary>
        /// Exécute la procédure de sélection pour les bénéficiaires dans la base de données et retourne un message.
        /// </summary>
        /// <param name="msg">Retourne une chaîne de caractère vide si la sélection s'est bien passée, sinon retourne le message d'erreur.</param>
        /// <returns>Liste des bénéficiaires</returns>
        public List<Beneficiaire> GetLesBeneficiaires(out string msg)
        {
            // Déclaration et création de la collection des bénéficiaires
            List<Beneficiaire> lesBeneficiaires = new List<Beneficiaire>();
            msg = ""; // Initialisation du message

            try
            {
                Beneficiaire unBeneficiaire;
                TypeBeneficiaire unTypeBeneficiaire;
                Profession uneProfession;
                Etatblissement unEtatblissement;

                // Création de l'objet commande
                MySqlCommand maCommand = new MySqlCommand("", Connexion.GetMySqlConnection());

                // Création du DataReader
                MySqlDataReader monLecteur;

                maCommand.CommandType = CommandType.StoredProcedure;

                // Appel de la procédure stockée
                maCommand.CommandText = "spBeneficiaire";

                // Exécution de la requête
                monLecteur = maCommand.ExecuteReader();

                // Lecture du DataReader, récupération et création des objets de la classe Bénéficiaire
                while (monLecteur.Read())
                {
                    // Récupération des valeurs depuis la base de données
                    int id = Convert.ToInt32(monLecteur["id"]);
                    string nom = monLecteur["nom"].ToString();
                    string adresse = monLecteur["adresse"].ToString();

                    // Création des objets liés
                    unEtatblissement = new Etatblissement(monLecteur["nomEtablissement"].ToString());
                    uneProfession = new Profession(monLecteur["libelleProfession"].ToString());
                    unTypeBeneficiaire = new TypeBeneficiaire(monLecteur["TypeBeneficiaire"].ToString());

                    // Instanciation du bénéficiaire et ajout à la liste
                    unBeneficiaire = new Beneficiaire(id, nom, adresse, unEtatblissement, uneProfession, unTypeBeneficiaire);
                    lesBeneficiaires.Add(unBeneficiaire);
                }

                // Fermeture du DataReader après utilisation
                monLecteur.Close();

                // Fermeture de la connexion
                Connexion.CloseConnexion();
            }
            catch (MySqlException e)
            {
                // Capture du message d'erreur SQL en cas d'exception
                msg = e.Message;
            }

            // Retourne une liste de bénéficiaires et un message d'erreur s'il y en a un
            return lesBeneficiaires;
        }

        /// <summary>
        /// Exécute la procédure stockée pour récupérer un bénéficiaire spécifique dans la base de données et retourne un message.
        /// </summary>
        /// <param name="idUnBeneficiaire">L'identifiant du bénéficiaire à récupérer.</param>
        /// <param name="msg">Retourne une chaîne vide si la sélection s'est bien passée, sinon retourne le message d'erreur.</param>
        /// <returns>Un objet Beneficiaire ou null en cas d'erreur.</returns>
        public Beneficiaire GetUnBeneficiaire(int idUnBeneficiaire, out string msg)
        {
            // Initialisation des variables
            Beneficiaire unBeneficiaire = null;
            msg = "";

            try
            {
                // Déclaration des objets liés
                TypeBeneficiaire unTypeBeneficiaire;
                Profession uneProfession;
                Etatblissement unEtatblissement;
                Ville uneVille;
                int numRPPS, idEtablissement, idProfession;

                // Création de l'objet commande
                MySqlCommand maCommand = new MySqlCommand("", Connexion.GetMySqlConnection());

                // Définition du type de commande comme procédure stockée
                maCommand.CommandType = CommandType.StoredProcedure;

                // Appel de la procédure stockée MySQL
                maCommand.CommandText = "spBeneficiaireSltUn";

                // Ajout du paramètre d'entrée
                maCommand.Parameters.AddWithValue("@id", idUnBeneficiaire);

                // Exécution de la requête
                MySqlDataReader monLecteur = maCommand.ExecuteReader();

                // Lecture des résultats
                if (monLecteur.Read())
                {
                    // Extraction des données depuis le DataReader
                    string nom = monLecteur["nom"].ToString();
                    string prenom = monLecteur["prenom"].ToString();
                    string rue = monLecteur["rue"].ToString();

                    // Vérification des valeurs NULL dans la base de données
                    numRPPS = monLecteur["numRPPS"] != DBNull.Value ? Convert.ToInt32(monLecteur["numRPPS"]) : 0;
                    idEtablissement = monLecteur["idEtatblissement"] != DBNull.Value ? Convert.ToInt32(monLecteur["idEtatblissement"]) : 0;
                    idProfession = monLecteur["idProfession"] != DBNull.Value ? Convert.ToInt32(monLecteur["idProfession"]) : 0;

                    int idTypeBeneficiaire = Convert.ToInt32(monLecteur["idtypeBeneficiaire"]);
                    int numInsee = Convert.ToInt32(monLecteur["numInsee"]);

                    // Création des objets associés
                    unEtatblissement = new Etatblissement(idEtablissement);
                    uneProfession = new Profession(idProfession);
                    uneVille = new Ville(numInsee);
                    unTypeBeneficiaire = new TypeBeneficiaire(idTypeBeneficiaire);

                    // Instanciation de l'objet Beneficiaire
                    unBeneficiaire = new Beneficiaire(idUnBeneficiaire, nom, rue, prenom, numRPPS, uneVille, unEtatblissement, uneProfession, unTypeBeneficiaire);
                }

                // Fermeture du lecteur
                monLecteur.Close();

                // Fermeture de la connexion MySQL
                Connexion.CloseConnexion();
            }
            catch (MySqlException e)
            {
                // Capture du message d'erreur MySQL
                msg = e.Message;
            }

            // Retourne le bénéficiaire trouvé ou null en cas d'erreur
            return unBeneficiaire;
        }


        #endregion

        #region Methode Modification
        /// <summary>
        /// Exécute la procédure modification pour un bénéficiaire dans la base de données MySQL et retourne un message.
        /// </summary>
        /// <param name="unBeneficiaire">Objet représentant le bénéficiaire à modifier.</param>
        /// <returns>Un message indiquant le succès ou l'échec de l'opération.</returns>
        public string ModifBeneficiaire(Beneficiaire unBeneficiaire)
        {
            // Déclare la variable du message de retour.
            string msg = "";
            try
            {
                // Création de l'objet commande avec une connexion MySQL
                using (MySqlCommand maCommand = new MySqlCommand("spBeneficiaireMdf", Connexion.GetMySqlConnection()))
                {
                    maCommand.CommandType = CommandType.StoredProcedure;

                    // Ajout des paramètres pour la procédure stockée
                    maCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = unBeneficiaire.Id;
                    maCommand.Parameters.Add("@nom", MySqlDbType.VarChar).Value = unBeneficiaire.Nom;
                    maCommand.Parameters.Add("@rue", MySqlDbType.VarChar).Value = unBeneficiaire.Rue;
                    maCommand.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = unBeneficiaire.Prenom;
                    maCommand.Parameters.Add("@numRPPS", MySqlDbType.Decimal).Value = unBeneficiaire.NumRPPS;
                    maCommand.Parameters.Add("@idProfession", MySqlDbType.Int32).Value = unBeneficiaire.UneProfession.Id;
                    maCommand.Parameters.Add("@idEtablissement", MySqlDbType.Int32).Value = unBeneficiaire.UnEtablissement.Id;
                    maCommand.Parameters.Add("@idTypeBeneficiaire", MySqlDbType.Int32).Value = unBeneficiaire.UnTypeBeneficiaire.Id;
                    maCommand.Parameters.Add("@numInsee", MySqlDbType.Int32).Value = unBeneficiaire.UneVille.NumInsee;

                    // Exécute la requête
                    int nb = maCommand.ExecuteNonQuery();

                    // Retourne un message selon le résultat
                    msg = (nb > 0) ? "Modification réussie." : "Aucune modification effectuée.";
                }
            }
            catch (MySqlException e)
            {
                // Capture l'erreur et retourne un message d'erreur
                msg = "Erreur MySQL : " + e.Message;
            }
            return msg;
        }


        #endregion

        #region Methode Suppression
        /// <summary>
        /// Exécute la procédure de suppression pour un bénéficiaire dans la base de données MySQL et retourne un message.
        /// </summary>
        /// <param name="idBeneficiaire">L'identifiant du bénéficiaire à supprimer.</param>
        /// <returns>Un message indiquant le succès ou l'échec de l'opération.</returns>
        public string SupprBeneficiaire(int idBeneficiaire)
        {
            // Déclare la variable du message de retour.
            string msg = "";
            try
            {
                // Création de l'objet commande avec une connexion MySQL
                using (MySqlCommand maCommand = new MySqlCommand("spBeneficiaireSupp", Connexion.GetMySqlConnection()))
                {
                    maCommand.CommandType = CommandType.StoredProcedure;

                    // Ajout du paramètre pour la procédure stockée
                    maCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = idBeneficiaire;

                    // Exécute la requête
                    int nb = maCommand.ExecuteNonQuery();

                    // Retourne un message selon le résultat
                    msg = (nb > 0) ? "Suppression réussie." : "Aucune suppression effectuée.";
                }
            }
            catch (MySqlException e)
            {
                // Capture l'erreur et retourne un message d'erreur
                msg = "Erreur MySQL : " + e.Message;
            }
            return msg;
        }


        #endregion
    }
}
