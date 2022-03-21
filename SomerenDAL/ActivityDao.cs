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
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT activitie_id, activitie_name, StartDateTime FROM activities";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activitie = new Activity()
                {
                    Id = (int)dr["activitie_id"],
                    Name = (string)(dr["activitie_name"].ToString()),
                    Time = (DateTime)dr["StartDateTime"]
                };
                activities.Add(activitie);
            }
            return activities;
        }
    }
}
