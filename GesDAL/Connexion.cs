using System;
using System.Collections.Generic;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienDAL
{
    static public class Connexion
    {
        static private MySqlConnection objConnex;

        // Le constructeur statique (appelé une seule fois)
        // crée un objet instance de la classe MySqlConnection
        static Connexion()
        {
            objConnex = new MySqlConnection();
            objConnex.ConnectionString = ConfigurationManager.ConnectionStrings["GSBLien"].ConnectionString;
        }

        // La méthode GetSqlConnection fournit l'objet instance de 
        // la classe MySqlConnection dans un état "connexion ouverte"
        /*public static MySqlConnection GetMySqlConnection()
        {
            // On ouvre la connexion si elle est fermée
            if (objConnex.State == System.Data.ConnectionState.Closed)
            {
                objConnex.Open();
            }
            // On retourne l'objet responsable de la connexion
            return objConnex;
        }*/
        public static MySqlConnection GetMySqlConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["GSBLien"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();  // Toujours ouvrir une nouvelle connexion
            return conn;
        }
        // La méthode CloseConnexion met l'objet instance de 
        // la classe MySqlConnection dans un état "connexion fermée"
        public static void CloseConnexion()
        {
            // Si la connexion est ouverte, on la ferme
            if (objConnex != null && objConnex.State != System.Data.ConnectionState.Closed)
            {
                objConnex.Close();
            }
        }
    }
}
