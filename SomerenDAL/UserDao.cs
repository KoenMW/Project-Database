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
    public class UserDao : BaseDao
    {
        public void AddUser(User user)
        {
            string query = "INSERT INTO users VALUES(@username, @password, @secretQuestion, @secretAnswer, 0);";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@username", user.Name);
            sqlParameters[1] = new SqlParameter("@password", user.Password);
            sqlParameters[2] = new SqlParameter("@secretQuestion", user.SecretQuestion);
            sqlParameters[3] = new SqlParameter("@secretAnswer", user.SecretAnswer);
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
