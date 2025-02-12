using GesLienBO;
using GesLienDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBLL
{
    public class NatureManager
    {
       
            private static NatureManager uneInstance;

            // cette méthode creé un objet de la classe ClientDAO s'il n'existe pas déjà un
            // puis retourne la réference a cet objet
            public static NatureManager GetInstance()
            {
                if (uneInstance == null)
                {
                    uneInstance = new NatureManager();

                }
                return uneInstance;

            }
            //le constructeur par défaut est privé : il ne sera donc pas possible de créer un 
            //objet a l'exterieur de la classe avec l'instruction new...
            private NatureManager()
            {
            }

            public List<Nature> GetNature()
            {
                return NatureDAO.GetInstance().GetNature();
            }
        
    }
}
