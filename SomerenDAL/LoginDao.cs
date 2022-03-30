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
    public class LoginDao : BaseDao
    {
        public Login Login(string username, string password)
        {
            string query = "SELECT userId FROM users WHERE username=@username AND password=@password";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@username", username);
            sqlParameters[1] = new SqlParameter("@password", HashString(password));
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private Login ReadTables(DataTable dataTable)
        {
            Login login = new Login();
            foreach (DataRow dr in dataTable.Rows)
            {
                login.UserId = (int)dr["userId"];
            }
            return login;
        }
    }
}