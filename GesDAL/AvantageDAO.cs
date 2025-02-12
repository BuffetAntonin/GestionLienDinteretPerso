using GesLienBO;
using GesLienDAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

/// <summary>
/// Classe DAO pour gérer les opérations sur les avantages.
/// </summary>
public class AvantageDAO
{
    /// <summary>
    /// Récupère la liste de tous les avantages.
    /// </summary>
    /// <returns>Liste des avantages</returns>
    public static List<Avantage> GetAvantage()
    {
        List<Avantage> lesAvantages = new List<Avantage>();

        try
        {
            using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
            {
                MySqlCommand maCommand = new MySqlCommand("CALL spGetLesAvantages", maConnexion);
                using (MySqlDataReader reader = maCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["id"];
                        float montant = reader["montant"] == DBNull.Value ? 0 : Convert.ToSingle(reader["montant"]);
                        DateTime DateDon = reader["dateDon"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["dateDon"];
                        string idBeneficiaire = reader["NomBeneficiaire"].ToString();
                        string idEmploye = reader["LibelleNature"].ToString();
                        string idNature = reader["NomEmploye"].ToString();

                        Avantage unAvantage = new Avantage(id, montant, DateDon, new Beneficiaire(idBeneficiaire), new Employe(idEmploye), new Nature(idNature));
                        lesAvantages.Add(unAvantage);
                    }
                }

                // Ancien code supprimé :
                // Connexion.CloseConnexion();
            }
        }
        catch (MySqlException e)
        {
            Console.WriteLine("Erreur MySQL : " + e.Message);
        }

        return lesAvantages;
    }

    /// <summary>
    /// Récupère un avantage spécifique en fonction de son ID.
    /// </summary>
    /// <param name="id">Identifiant de l'avantage</param>
    /// <returns>Un objet Avantage</returns>
    public static Avantage GetUnAvantage(int id)
    {
        Avantage unAvantage = null;

        try
        {
            using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
            {
                using (MySqlCommand maCommand = new MySqlCommand("CALL spAvantageSltUn(@id)", maConnexion))
                {
                    maCommand.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = maCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            float montant = reader["montant"] == DBNull.Value ? 0 : Convert.ToSingle(reader["montant"]);
                            DateTime DateDon = reader["dateDon"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["dateDon"];
                            string idBeneficiaire = reader["NomBeneficiaire"].ToString();
                            string idEmploye = reader["LibelleNature"].ToString();
                            string idNature = reader["NomEmploye"].ToString();

                            unAvantage = new Avantage(id, montant, DateDon, new Beneficiaire(idBeneficiaire), new Employe(idEmploye), new Nature(idNature));
                        }
                    }
                }

                // Ancien code supprimé :
                // Connexion.CloseConnexion();
            }
        }
        catch (MySqlException e)
        {
            Console.WriteLine("Erreur MySQL : " + e.Message);
        }

        return unAvantage;
    }

    /// <summary>
    /// Ajoute un nouvel avantage à la base de données.
    /// </summary>
    /// <param name="unAvantage">L'avantage à ajouter</param>
    /// <returns>Nombre de lignes affectées</returns>
    public static int AjoutAvantage(Avantage unAvantage)
    {
        int nb = 0;

        try
        {
            using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
            {
                using (MySqlCommand maCommand = new MySqlCommand("CALL spAvantageAjout(@montant, @dateDon, @idBeneficiaire, @idEmploye, @idNature)", maConnexion))
                {
                    maCommand.Parameters.AddWithValue("@montant", unAvantage.MontantDuDon);
                    maCommand.Parameters.AddWithValue("@dateDon", unAvantage.DateDuDon);
                    maCommand.Parameters.AddWithValue("@idBeneficiaire", unAvantage.UnBeneficiaire.Id);
                    maCommand.Parameters.AddWithValue("@idEmploye", unAvantage.UnEmploye.Id);
                    maCommand.Parameters.AddWithValue("@idNature", unAvantage.UneNature.Id);

                    nb = maCommand.ExecuteNonQuery();
                }

                // Ancien code supprimé :
                // Connexion.CloseConnexion();
            }
        }
        catch (MySqlException e)
        {
            Console.WriteLine("Erreur lors de l'ajout : " + e.Message);
        }

        return nb;
    }

    /// <summary>
    /// Supprime un avantage de la base de données.
    /// </summary>
    /// <param name="id">Identifiant de l'avantage</param>
    /// <returns>Nombre de lignes affectées</returns>
    public static int SupprAvantage(int id)
    {
        int nb = 0;

        try
        {
            using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
            {
                using (MySqlCommand maCommand = new MySqlCommand("CALL spAvantageSupp(@id)", maConnexion))
                {
                    maCommand.Parameters.AddWithValue("@id", id);
                    nb = maCommand.ExecuteNonQuery();
                }

                // Ancien code supprimé :
                // Connexion.CloseConnexion();
            }
        }
        catch (MySqlException e)
        {
            Console.WriteLine("Erreur lors de la suppression : " + e.Message);
        }

        return nb;
    }

    /// <summary>
    /// Modifie un avantage existant dans la base de données.
    /// </summary>
    /// <param name="unAvantage">L'avantage modifié</param>
    /// <returns>Nombre de lignes affectées</returns>
    public static int ModifAvantage(Avantage unAvantage)
    {
        int nb = 0;

        try
        {
            using (MySqlConnection maConnexion = Connexion.GetMySqlConnection())
            {
                using (MySqlCommand maCommand = new MySqlCommand("CALL spAvantageMdf(@id, @montant, @dateDon, @idBeneficiaire, @idEmploye, @idNature)", maConnexion))
                {
                    maCommand.Parameters.AddWithValue("@id", unAvantage.Id);
                    maCommand.Parameters.AddWithValue("@montant", unAvantage.MontantDuDon);
                    maCommand.Parameters.AddWithValue("@dateDon", unAvantage.DateDuDon);
                    maCommand.Parameters.AddWithValue("@idBeneficiaire", unAvantage.UnBeneficiaire.Id);
                    maCommand.Parameters.AddWithValue("@idEmploye", unAvantage.UnEmploye.Id);
                    maCommand.Parameters.AddWithValue("@idNature", unAvantage.UneNature.Id);

                    nb = maCommand.ExecuteNonQuery();
                }

                // Ancien code supprimé :
                // Connexion.CloseConnexion();
            }
        }
        catch (MySqlException e)
        {
            Console.WriteLine("Erreur lors de la modification : " + e.Message);
        }

        return nb;
    }
}
