using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace SomerenDAL
{
    public class VATCalculationDao : BaseDao
    {
        public VATCalculation GetVAT(DateTime[] maxMinDate)
        {
            string query = "SELECT alcoholic, [date], price FROM sales AS S JOIN drinks AS D on D.id = S.drink_id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters), maxMinDate);

        }
        private VATCalculation ReadTable(DataTable dataTable, DateTime[] maxMinDate)
        {
            VATCalculation vatCalculation = new VATCalculation();

            foreach (DataRow dr in dataTable.Rows)
            {
                //((DateTime)dr["date"] <= DateTime.ParseExact("31-03-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture) && (DateTime)dr["date"] >= DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture))
                DateTime date = (DateTime)dr["date"];
                if ((DateTime)dr["date"] >= maxMinDate[0] && (DateTime)dr["date"] <= maxMinDate[1])
                {
                    float vatPercentage = 10;
                    if ((bool)dr["alcoholic"])
                    {
                        vatPercentage = 21;
                        vatCalculation.HighTariff += ((float)Convert.ToSingle(dr["price"]) / (100 + vatPercentage)) * vatPercentage;
                        vatCalculation.AmountHighTariff++;
                    }
                    else
                    {
                        vatCalculation.LowTariff += ((float)Convert.ToSingle(dr["price"]) / (100 + vatPercentage)) * vatPercentage;
                        vatCalculation.AmountLowTariff++;
                    }
                }
            }

            return vatCalculation;
        }
    }
}
