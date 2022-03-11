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
    public class ActivitieDao : BaseDao
    {
        public List<Activitie> GetAllActivities()
        {
            string query = "SELECT activitie_id, activitie_name, activitie_time FROM activities";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activitie> ReadTables(DataTable dataTable)
        {
            List<Activitie> activities = new List<Activitie>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activitie activitie = new Activitie()
                {
                    Id = (int)dr["activitie_id"],
                    Name = (string)(dr["activitie_name"].ToString()),
                    Time = (DateTime)dr["activitie_time"]
                };
                activities.Add(activitie);
            }
            return activities;
        }
    }
}
