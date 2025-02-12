using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesLienBO;
using GesLienDAL;

namespace GesLienBLL
{
    public class AvantageManager
    {



        private static AvantageManager uneInstance;

        // cette méthode creé un objet de la classe ClientDAO s'il n'existe pas déjà un
        // puis retourne la réference a cet objet
        public static AvantageManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AvantageManager();

            }
            return uneInstance;

        }
        
        //le constructeur par défaut est privé : il ne sera donc pas possible de créer un 
        //objet a l'exterieur de la classe avec l'instruction new...
        private AvantageManager()
        {
        }

        public List<Avantage> GetAvantage()
        {
            return AvantageDAO.GetInstance().GetAvantage();
        }

        public Avantage GetUnAvantage(int idAvantage)
        {
            return AvantageDAO.GetInstance().GetUnAvantage(idAvantage);
        }

        public string CreeAvantage(string unMontant, string uneDate, int unBeneficaire, int unEmploye, int uneNature)


        {

            string msgError = "";

            if (unMontant.Trim() == ",")
            {
                msgError = msgError + "veuillez renseigner un montant";
            }

            if (uneDate.Trim() == "")
            {
                msgError = msgError + "Veuillez rensigner une date ";
            }
            if (msgError != "") return msgError;



            Avantage lAvantage;
            DateTime uneDateDon;
            float unMontantint;
            DateTime.TryParse(uneDate, out uneDateDon);
            float.TryParse(unMontant, out unMontantint);
            lAvantage = new Avantage(unMontantint, uneDateDon, new Beneficiaire(unBeneficaire), new Employe(unEmploye), new Nature(uneNature));
            string msgRetourne = AvantageDAO.GetInstance().AjoutAvantage(lAvantage).ToString();
            return msgRetourne;

        }

        public string SupprAvantage(int id)
        {
            string msg = AvantageDAO.GetInstance().SupprAvantage(id);
            return msg;
        }

        public string ModifAvantage(int id,string unMontant, string uneDate, int idBeneficaire, int idEmploye, int idNature)
        {
           

            string msgError = "";

            if (unMontant.Trim() == ",")
            {
                msgError = msgError + "veuillez renseigner un montant";
            }

            if (uneDate.Trim() == "")
            {
                msgError = msgError + "Veuillez rensigner une date ";
            }
            if (msgError != "") return msgError;



            Avantage lAvantage;
            DateTime uneDateDon;
            float unMontantInt;
            DateTime.TryParse(uneDate, out uneDateDon);
            float.TryParse(unMontant, out unMontantInt);
            lAvantage = new Avantage(id,unMontantInt, uneDateDon, new Beneficiaire(idBeneficaire), new Employe(idEmploye), new Nature(idNature));
            string msgRetourne = AvantageDAO.GetInstance().ModifAvantage(lAvantage).ToString();
            return msgRetourne;
        }


    }
}
