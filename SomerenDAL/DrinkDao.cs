using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetDrinks()
        {
            string query = "SELECT id, drink, price, stock FROM drinks";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable datatable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in datatable.Rows)
            {
                Drink drink = new Drink()
                {
                    Number = (int)Convert.ToInt32(dr["id"]),
                    Name = (string)dr["drink"].ToString(),
                    Price = (int)Convert.ToInt32(dr["price"]),
                };
                drinks.Add(drink);
            }
            return drinks;
        }

        public void UpdateStock(Drink stock)
        {
            string query = "UPDATE drinks SET stock=@stock WHERE id=@id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@stock", stock.Stock - 1);
            sqlParameters[1] = new SqlParameter("@id", stock.Number);
            ExecuteEditQuery(query, sqlParameters);
        }

        public Drink GetByName(string name)
        {
            string query = "SELECT id, drink, price, stock FROM drinks WHERE drink=@name";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@name", name);

            List<Drink> drink = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            return drink[0];
        }


    }
}

