using GesLienBO;
using GesLienDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBLL
{
    public class EtablissementManager
    {
        private static EtablissementManager instance;

        public static EtablissementManager GetInstance()
        {
            if (instance == null)
            {
                instance = new EtablissementManager();
            }
            return instance;
        }
        private EtablissementManager() { }

        public List<Etatblissement> GetEtatblissements()
        {
            return EtablissementDAO.GetInstance().GetEtablissements();
        }
    }
}
