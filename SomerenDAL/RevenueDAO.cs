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
    public class RevenueDao : BaseDao
    {
        public Revenue GetRevenue()
        {
            string query = "use [2122_INF1a_db6] SELECT SUM([sold]) AS 'sales', sold* price AS 'revenue', count(bought_drink) as 'number_of_customers' FROM drinks, students GROUP BY sold, price";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private Revenue ReadTables(DataTable dataTable)
        {
            Revenue revenue = new Revenue();
            foreach (DataRow dr in dataTable.Rows)
            {                
                 revenue.Sales = (int)dr["sales"];
                 revenue.Ternover = (float)dr["revenue"];
                 revenue.NumberOfCustomers = (int)dr["number_of_customers"];
            }
            return revenue;
        }
    }
}