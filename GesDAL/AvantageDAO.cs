using GesLienBO;
using GesLienDAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Classe DAO pour gérer les opérations sur les avantages.
/// </summary>
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

    /// <summary>
    /// Récupère la liste de tous les avantages.
    /// </summary>
    /// <returns>Liste des avantages</returns>
    public List<Avantage> GetAvantage()
    {
        int id;
        float montant;
        DateTime DateDon;
        string idBeneficiaire;
        string idEmploye;
        string idNature;

        List<Avantage> lesAvantages = new List<Avantage>();

        // Récupération de la connexion MySQL
        using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
        {
            using (MySqlCommand maCommand = new MySqlCommand("spGetLesAvantages", maConnexion))
            {
                maCommand.CommandType = CommandType.StoredProcedure;

                // Exécution de la requête
                using (MySqlDataReader reader = maCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32("id");

                        // Gestion de la valeur null pour 'montant'
                        montant = reader.IsDBNull(reader.GetOrdinal("montant")) ? 0 : reader.GetFloat("montant");

                        // Gestion de la valeur null pour 'dateDon'
                        DateDon = reader.IsDBNull(reader.GetOrdinal("dateDon")) ? default(DateTime) : reader.GetDateTime("dateDon");

                        // Récupération des chaînes de caractères
                        idBeneficiaire = reader["NomBeneficiaire"].ToString();
                        idEmploye = reader["LibelleNature"].ToString();
                        idNature = reader["NomEmploye"].ToString();

                        // Création de l'objet Avantage
                        Avantage unAvantage = new Avantage(
                            id, montant, DateDon,
                            new Beneficiaire(idBeneficiaire),
                            new Employe(idEmploye),
                            new Nature(idNature)
                        );

                        lesAvantages.Add(unAvantage);
                    }
                }
            }
        }

        return lesAvantages;
    }


    /// <summary>
    /// Récupère un avantage spécifique en fonction de son ID.
    /// </summary>
    /// <param name="id">Identifiant de l'avantage</param>
    /// <returns>Un objet Avantage</returns>
    public Avantage GetUnAvantage(int idUnAvantage)
    {
        // Déclaration des objets nécessaires
        Avantage unAvantage = null;

        using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
        {
            using (MySqlCommand maCommand = new MySqlCommand("spAvantageSltUn", maConnexion))
            {
                maCommand.CommandType = CommandType.StoredProcedure;
                maCommand.Parameters.Add("id", MySqlDbType.Int32).Value = idUnAvantage;

                using (MySqlDataReader monLecteur = maCommand.ExecuteReader())
                {
                    while (monLecteur.Read())
                    {
                        int id = monLecteur.GetInt32("id");

                        // Gestion de la conversion du montant
                        float montant = monLecteur.IsDBNull(monLecteur.GetOrdinal("montant")) ? 0 : monLecteur.GetFloat("montant");

                        // Gestion de la conversion de la date
                        DateTime DateDon = monLecteur.IsDBNull(monLecteur.GetOrdinal("DateDon")) ? default(DateTime) : monLecteur.GetDateTime("DateDon");

                        int idBeneficiaire = monLecteur.GetInt32("idBeneficiaire");
                        int idEmploye = monLecteur.GetInt32("idEmploye");
                        int idNature = monLecteur.GetInt32("idNature");

                        // Création de l'objet Avantage
                        unAvantage = new Avantage(id, montant, DateDon,
                            new Beneficiaire(idBeneficiaire),
                            new Employe(idEmploye),
                            new Nature(idNature));
                    }
                }
            }
        }

        return unAvantage;
    }


    /// <summary>
    /// Ajoute un nouvel avantage à la base de données.
    /// </summary>
    /// <param name="unAvantage">L'avantage à ajouter</param>
    /// <returns>Nombre de lignes affectées</returns>
    public int AjoutAvantage(Avantage unAvantage)
    {
        int nb = 0;

        using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
        {
            using (MySqlCommand maCommand = new MySqlCommand("spAvantageAjout", maConnexion))
            {
                // Définition de la commande comme une procédure stockée
                maCommand.CommandType = CommandType.StoredProcedure;

                // Ajout des paramètres
                maCommand.Parameters.Add("montant", MySqlDbType.Float).Value = unAvantage.MontantDuDon;
                maCommand.Parameters.Add("dateDon", MySqlDbType.DateTime).Value = unAvantage.DateDuDon;
                maCommand.Parameters.Add("idBeneficiaire", MySqlDbType.Int32).Value = unAvantage.UnBeneficiaire.Id;
                maCommand.Parameters.Add("idEmploye", MySqlDbType.Int32).Value = unAvantage.UnEmploye.Id;
                maCommand.Parameters.Add("idNature", MySqlDbType.Int32).Value = unAvantage.UneNature.Id;

                // Exécution de la requête
                nb = maCommand.ExecuteNonQuery();
            }
        }

        return nb;
    }


    /// <summary>
    /// Supprime un avantage de la base de données.
    /// </summary>
    /// <param name="id">Identifiant de l'avantage</param>
    /// <returns>Nombre de lignes affectées</returns>
    public string SupprAvantage(int idAvantage)
    {
        string msg = "";
        try
        {
            using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
            {
                using (MySqlCommand maCommand = new MySqlCommand("spAvantageSupp", maConnexion))
                {
                    // Définition de la commande comme une procédure stockée
                    maCommand.CommandType = CommandType.StoredProcedure;

                    // Ajout des paramètres
                    maCommand.Parameters.Add("id", MySqlDbType.Int32).Value = idAvantage;

                    // Exécution de la requête
                    int nb = maCommand.ExecuteNonQuery();
                }
            }
        }
        catch (MySqlException e)
        {
            msg = e.Message;
        }

        return msg;
    }


    /// <summary>
    /// Modifie un avantage existant dans la base de données.
    /// </summary>
    /// <param name="unAvantage">L'avantage modifié</param>
    /// <returns>Nombre de lignes affectées</returns>
    public int ModifAvantage(Avantage unAvantage)
    {
        int nb = 0;
        try
        {
            using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
            {
                using (MySqlCommand maCommand = new MySqlCommand("spAvantageMdf", maConnexion))
                {
                    maCommand.CommandType = CommandType.StoredProcedure;

                    // Ajout des paramètres
                    maCommand.Parameters.Add("id", MySqlDbType.Int32).Value = unAvantage.Id;
                    maCommand.Parameters.Add("montant", MySqlDbType.Float).Value = unAvantage.MontantDuDon;
                    maCommand.Parameters.Add("dateDon", MySqlDbType.DateTime).Value = unAvantage.DateDuDon;
                    maCommand.Parameters.Add("idBeneficiaire", MySqlDbType.Int32).Value = unAvantage.UnBeneficiaire.Id;
                    maCommand.Parameters.Add("idEmploye", MySqlDbType.Int32).Value = unAvantage.UnEmploye.Id;
                    maCommand.Parameters.Add("idNature", MySqlDbType.Int32).Value = unAvantage.UneNature.Id;

                    // Exécution de la requête
                    nb = maCommand.ExecuteNonQuery();
                }
            }
        }
        catch (MySqlException e)
        {
            Console.WriteLine("Erreur MySQL : " + e.Message);
        }

        return nb;
    }

}
