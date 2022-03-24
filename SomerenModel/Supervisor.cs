using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Supervisor
    {
        public Supervisor(int lecturerId, int activityId)
        {
            LecturerId = lecturerId;
            ActivityId = activityId;
        }

        public int LecturerId { get; set; }
        public int ActivityId { get; set; }   
               

    }

    
}
