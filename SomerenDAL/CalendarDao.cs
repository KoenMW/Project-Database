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
    public class CalendarDao : BaseDao
    {
        public List<Calendar> GetCalendar()
        {
            string query = "SELECT A.activitie_name, A.StartDateTime, COUNT([AS].lecturerID)AS[nr of supervisors] FROM activities AS A LEFT JOIN ActivitySupervisor AS [AS] ON A.activitie_id =[AS].ActivityID GROUP BY  A.StartDateTime,A.activitie_name";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Calendar> ReadTables(DataTable datatable)
        {
            List<Calendar> calendar = new List<Calendar>();

            foreach (DataRow dr in datatable.Rows)
            {
                Calendar item = new Calendar()
                {
                    NrOfSupervisors = (int)Convert.ToInt32(dr["nr of supervisors"]),
                    ActivityName = (string)dr["activitie_name"].ToString(),
                    StartDate = (DateTime)dr["StartDateTime"],
                    
                };
                calendar.Add(item);
            }
            return calendar;
        }
    }
}
