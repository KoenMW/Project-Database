using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class SupervisorService
    {
        SupervisorDao supervisordb;

        public SupervisorService()
        {
            supervisordb = new SomerenDAL.SupervisorDao();
        }

        public void AddSupervisor(Supervisor supervisor)
        {
            SupervisorDao superDao = new SupervisorDao();

            superDao.AddSupervisor(supervisor);
        }

        public void DeleteSupervisor(Supervisor supervisor)
        {
            SupervisorDao superDao = new SupervisorDao();

            superDao.DeleteSupervisor(supervisor);
        }
    }
}
