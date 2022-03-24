using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT student_id, student_name, date_of_birth FROM students";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Student> GetStudentNamesAndActivities(int activityNumber)
        {
            string query = "SELECT student_id, student_name, date_of_birth, activity_number FROM students WHERE activity_number = @activity_number";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@activity_number", activityNumber);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateStudentActivity(int activity_number, int student_id)
        {

            string query = "Update students SET activity_number=@activity_number WHERE student_id=@student_id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@activity_number", activity_number);
            sqlParameters[1] = new SqlParameter("@student_id", student_id);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveStudentActivity(int student_id)
        {
            string query = "Update students SET activity_number = NULL WHERE student_id=@student_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@student_id", student_id);
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();
            string[] names = new string[2];
            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)Convert.ToInt32(dr["student_id"]),
                    Name = (string)dr["student_name"].ToString(),
                    BirthDate = (DateTime)dr["date_of_birth"]
                };
                students.Add(student);
            }
            return students;
        }
    }
}
