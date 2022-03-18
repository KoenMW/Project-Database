using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class DrinkService
    {
        DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new SomerenDAL.DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinkdb.GetDrinks();
            return drinks;
        }

        public void UpdateStock(Drink stock)
        {
            drinkdb.UpdateStock(stock);
        }
        public Drink GetByName(string name)
        {
            return drinkdb.GetByName(name);
        }
    }
}
