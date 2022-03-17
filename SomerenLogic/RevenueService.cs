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
    public class RevenueService
    {
        RevenueDao revenuedb;

        public RevenueService()
        {
            revenuedb = new RevenueDao();
        }

        public Revenue GetRevenue()
        {
            Revenue revenue = revenuedb.GetRevenue();
            return revenue;
        }

        public Revenue GetRevenue(DateTime startDate, DateTime endDate)
        {
            Revenue revenue = revenuedb.GetRevenue(startDate, endDate);
            return revenue;
        }
    }
}
