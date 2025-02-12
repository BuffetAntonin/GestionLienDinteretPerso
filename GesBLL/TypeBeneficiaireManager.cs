using GesLienBO;
using GesLienDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBLL
{
    public class TypeBeneficiaireManager
    {
        private static TypeBeneficiaireManager instance;

        public static TypeBeneficiaireManager GetInstance()
        {
            if (instance == null)
            {
                instance = new TypeBeneficiaireManager();
            }
            return instance;
        }
        private TypeBeneficiaireManager() { }

        public List<TypeBeneficiaire> GetTypeBeneficiaires()
        {
            return TypeBeneficiaireDAO.GetInstance().GetTypeBeneficiaires();
        }

    }
}
