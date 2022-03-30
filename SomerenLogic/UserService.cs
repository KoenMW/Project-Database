using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;

namespace SomerenLogic
{
    public class UserService
    {
        UserDao userdb;

        public UserService()
        {
            userdb = new UserDao();
        }

        public void AddUser(User user)
        {
            userdb.AddUser(user);
        }
    }
}
