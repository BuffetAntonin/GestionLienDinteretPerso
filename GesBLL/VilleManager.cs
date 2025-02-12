using GesLienBO;
using GesLienDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBLL
{
    public class VilleManager
    {
        private static VilleManager instance;

        public static VilleManager GetInstance()
        {
            if (instance == null)
            {
                instance = new VilleManager();
            }
            return instance;
        }

        public List<Ville> GetVilles()
        {
            return VilleDAO.GetInstance().GetVilles();
        }

    }
}
