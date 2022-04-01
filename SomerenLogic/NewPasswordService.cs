using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;

namespace SomerenLogic
{
    public class NewPasswordService
    {
        NewPasswordDao newpassworddb;

        public NewPasswordService()
        {
            newpassworddb = new NewPasswordDao();
        }
        public User Login(User user)
        {
            User login = newpassworddb.Login(user);
            return login;
        }
        public void UpdatePassword(User user)
        {
            newpassworddb.UpdatePassword(user);
        }
    }
}
