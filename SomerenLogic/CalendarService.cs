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
    public class CalendarService
    {
        CalendarDao calendardb;
        public CalendarService()
        {
            calendardb = new CalendarDao();
        }

        public List<Calendar> GetCalendar()
        {
            List<Calendar> calendar = calendardb.GetCalendar();
            return calendar;
        }
    }
}
