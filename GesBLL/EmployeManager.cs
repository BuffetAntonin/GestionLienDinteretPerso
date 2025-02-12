using GesLienBO;
using GesLienDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBLL
{
    public class EmployeManager
    {
        private static EmployeManager uneInstance;

        // cette méthode creé un objet de la classe ClientDAO s'il n'existe pas déjà un
        // puis retourne la réference a cet objet
        public static EmployeManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EmployeManager();

            }
            return uneInstance;

        }
        //le constructeur par défaut est privé : il ne sera donc pas possible de créer un 
        //objet a l'exterieur de la classe avec l'instruction new...
        private EmployeManager()
        {
        }

        public List<Employe> GetEmploye()
        {
            return EmployeDAO.GetInstance().GetEmploye();
        }
    }
}
