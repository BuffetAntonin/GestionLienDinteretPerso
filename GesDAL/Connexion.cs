
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienDAL
{
    static public class Connexion
    {
        static private SqlConnection objConnex;

        //le constructeur statique (appelé une seule fois)
        // crée un objet insatance de la class SqlConnection
        static Connexion()
        {
            objConnex = new SqlConnection();
            objConnex.ConnectionString = ConfigurationManager.ConnectionStrings["GSBLien"].ConnectionString;
        }
        // la méthode GetObjConnexion forunit l'objet instance de 
        // la classe SqlConnection dan un état "connexion ouverte"
        public static SqlConnection GetSqlConnection()

        {
            // on ouvre la connexion si elle est fermée
            if (objConnex.State == System.Data.ConnectionState.Closed)
            {
                objConnex.Open();
            }
            // on retourne l'objet responsable de la connexion
            return objConnex;
        }

        // la méthode CloseConnexion met l'objet instance de 
        // la classe SqlConnection dans un état "connexion fermée"
        public static void CloseConnexion()
        {

            // si la connexion est ouverte on la ferme
            if (objConnex != null && objConnex.State != System.Data.ConnectionState.Closed)
            {
                objConnex.Close();
            }

        }

    }
}