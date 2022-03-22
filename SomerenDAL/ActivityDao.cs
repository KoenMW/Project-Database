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
            string query = "SELECT activitie_id, activitie_name, [Description], StartDateTime, EndDateTime FROM activities";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Activity GetByName(string name)
        {
            string query = "SELECT activitie_id, activitie_name, [Description], StartDateTime, EndDateTime FROM activities WHERE activitie_name=@name";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@name", name);
            List<Activity> activities = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return activities[0];
        }

        public void UpdateActivity(Activity activity)
        {
            string query = "UPDATE activities SET activitie_name = @name, [Description] = @description, StartDateTime = @startDate, EndDateTime = @endDate WHERE activitie_id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@name", activity.Name);
            sqlParameters[1] = new SqlParameter("@description", activity.Description);
            sqlParameters[2] = new SqlParameter("@startDate", activity.StartTime);
            sqlParameters[3] = new SqlParameter("@endDate", activity.EndTime);
            sqlParameters[4] = new SqlParameter("@id", activity.Id);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void InsertActivity(Activity activity)
        {
            string query = "INSERT INTO activities VALUES(@id, @name, @description, @startDate, @endDate);";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@name", activity.Name);
            sqlParameters[1] = new SqlParameter("@description", activity.Description);
            sqlParameters[2] = new SqlParameter("@startDate", activity.StartTime.ToString("yyyy-MM-dd"));
            sqlParameters[3] = new SqlParameter("@endDate", activity.EndTime.ToString("yyyy-MM-dd"));
            sqlParameters[4] = new SqlParameter("@id", activity.Id);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DeleteActivity(Activity activity)
        {
            string query = "DELETE FROM activities WHERE activitie_id = @id;";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", activity.Id);
            ExecuteEditQuery(query, sqlParameters);
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
                    Description = (string)(dr["Description"].ToString()),
                    StartTime = (DateTime)dr["StartDateTime"],
                    EndTime = (DateTime)dr["EndDateTime"]
                };
                activities.Add(activitie);
            }
            return activities;
        }
    }
}
