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
    public class SupervisorDao : BaseDao
    {
        public void AddSupervisor(Supervisor supervisor)
        {
            string query = "INSERT INTO ActivitySupervisor (LecturerID, ActivityID) VALUES (@LecturerID, @ActivityID); ";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@LecturerID", supervisor.LecturerId);
            sqlParameters[1] = new SqlParameter("@ActivityID", supervisor.ActivityId);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteSupervisor(Supervisor supervisor)
        {
            string query = "DELETE FROM ActivitySupervisor WHERE LecturerID = @LecturerID AND ActivityID = @ActivityID; ";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@LecturerID", supervisor.LecturerId);
            sqlParameters[1] = new SqlParameter("@ActivityID", supervisor.ActivityId);
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
