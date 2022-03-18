using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;

namespace SomerenLogic
{
    public class VATCalculationService
    {
        VATCalculationDao vatCalculationdb;

        public VATCalculationService()
        {
            vatCalculationdb = new VATCalculationDao();
        }

        public VATCalculation GetVAT(DateTime[] maxMinDate)
        {
            VATCalculation vatCalculation = vatCalculationdb.GetVAT(maxMinDate);
            return vatCalculation;
        }
    }
}
