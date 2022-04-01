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
    public class NewPasswordDao:BaseDao
    {
        public User Login(User user)
        {
            string query = "SELECT secretQuestion, secretAnswer FROM users WHERE username = @username";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@username", user.Name);
            
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private User ReadTables(DataTable dataTable)
        {
            User login = new User();
            foreach (DataRow dr in dataTable.Rows)
            {
                login.SecretAnswer = (string)dr["secretAnswer"];
                login.SecretQuestion = (string)dr["secretQuestion"];
            }
            return login;
        }
        public void UpdatePassword(User user)
        {
            string query = "Update users SET password=@password WHERE username=@username";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@username", user.Name);
            sqlParameters[1] = new SqlParameter("@password", HashString(new byte[user.Password.Length], user.Password));
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
