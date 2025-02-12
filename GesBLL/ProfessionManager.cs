using GesLienBO;
using GesLienDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBLL
{
    public class ProfessionManager
    {
        private static ProfessionManager instance;

        public static ProfessionManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ProfessionManager();
            }
            return instance;
        }
        private ProfessionManager() { }
        public List<Profession> GetProfessions()
        {
            return ProfessionDAO.GetInstance().GetProfessions();
        }
    }
}
