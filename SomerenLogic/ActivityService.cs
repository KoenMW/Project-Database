﻿using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class ActivityService
    {
        ActivityDao activitiedb;

        public ActivityService()
        {
            activitiedb = new ActivityDao();
        }

        public List<Activity> GetActivities()
        {
            List<Activity> activities = activitiedb.GetAllActivities();
            return activities;
        }

        public Activity GetById(string id)
        {
            return activitiedb.GetById(id);
        }

        public void UpdateActivity(Activity activity)
        {
            activitiedb.UpdateActivity(activity);
        }

        public void InserActivity(Activity activity)
        {
            activitiedb.InsertActivity(activity);
        }

        public void DeleteActivity(Activity activity)
        {
            activitiedb.DeleteActivity(activity);
        }
    }
}
