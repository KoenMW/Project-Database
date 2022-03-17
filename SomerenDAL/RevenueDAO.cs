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
            string query = "SELECT COUNT(DISTINCT s.sales_id) AS sales, SUM(d.price) AS turnover, COUNT(DISTINCT s.student) AS 'number_of_customers' FROM sales as s join drinks as d on d.id is not null where d.id = s.drink_id; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        public Revenue GetRevenue(DateTime startDate, DateTime endDate)
        {
            string query = $"SELECT COUNT(DISTINCT s.sales_id) AS sales, SUM(d.price) AS turnover, COUNT(DISTINCT s.student) AS 'number_of_customers' FROM sales as s join drinks as d on d.id is not null where d.id = s.drink_id and s.[date]<'{startDate.ToString("yyyy-mm-dd")}'; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private Revenue ReadTables(DataTable dataTable)
        {
            Revenue revenue = new Revenue();
            foreach (DataRow dr in dataTable.Rows)
            {                
                 revenue.Sales = (int)dr["sales"];
                 revenue.Ternover = (double)dr["turnover"];
                 revenue.NumberOfCustomers = (int)dr["number_of_customers"];
            }
            return revenue;
        }
    }
}