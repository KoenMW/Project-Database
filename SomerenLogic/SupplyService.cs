using SomerenDAL.SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class SupplyService
    {
        SupplyDao supplydb;

        public SupplyService()
        {
            supplydb = new SupplyDao();
        }

        public List<Supply> GetDrink()
        {
            List<Supply> supply = supplydb.GetDrink();
            return supply;
        }
        public void UpdateDrink(Supply drink)
        {
            
            supplydb.UpdateDrink(drink);
        }
    
}
}
