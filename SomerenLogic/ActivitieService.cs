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
    public class ActivitieService
    {
        ActivitieDao activitiedb;

        public ActivitieService()
        {
            activitiedb = new ActivitieDao();
        }

        public List<Activitie> GetActivities()
        {
            List<Activitie> activities = activitiedb.GetAllActivities();
            return activities;
        }
    }
}
