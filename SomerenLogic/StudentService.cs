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
    public class StudentService
    {
        StudentDao studentdb;

        public StudentService()
        {
            studentdb = new StudentDao();
        }

        public List<Student> GetStudents()
        {
            List<Student> students = studentdb.GetAllStudents();
            return students;
        }
        public List<Student> GetStudentNamesAndActivities(int activityNumber)
        {
            List<Student> students = studentdb.GetStudentNamesAndActivities(activityNumber);
            return students;
        }
        public void UpdateStudentActivity(int activity_number, int student_id)
        {
            studentdb.UpdateStudentActivity(activity_number, student_id);
        }
        public void RemoveStudentActivity(int student_id)
        {
            studentdb.RemoveStudentActivity(student_id);
        }
    }
}
