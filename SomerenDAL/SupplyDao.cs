using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
namespace SomerenDAL
{
    namespace SomerenDAL
    {
        public class SupplyDao : BaseDao
        {
           
            public List<Supply> GetDrink()
            {
                string query = "SELECT id, drink, stock FROM drinks WHERE stock > 1 AND Price IN(SELECT price FROM drinks WHERE price > 1) ORDER BY stock, price";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }

            private List<Supply> ReadTables(DataTable dataTable)
            {
                List<Supply> supplies = new List<Supply>();
                foreach (DataRow dr in dataTable.Rows)
                {
                    Supply supply = new Supply();
                    {
                        supply.Id = (int)dr["id"];
                        supply.Stock = (int)dr["stock"];
                        supply.Drink = (string)dr["drink"];
                    };
                    supplies.Add(supply);
                }
                return supplies;
            }
            public void UpdateDrink(Supply drink)
            {
                
                string query = "Update drinks SET stock=@stock WHERE Id=@Id";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@stock", drink.Stock);
                sqlParameters[1] = new SqlParameter("@id", drink.Id);
                ExecuteEditQuery(query, sqlParameters);
            }
        }
    }
}
