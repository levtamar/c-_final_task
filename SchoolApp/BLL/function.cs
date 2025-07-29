using DAL;
using Entities;

namespace BLL
{
    public class function
    {

     Database1 Database = new Database1();
        List<Students> StudentsList = new List<Students>();
        List<Teachers> TeachersList = new List<Teachers>();

        public List<Students> LoadStudentsDetails()
        {
            var reader = Database.ReadFromDbStudents();
            while (reader.Read())
            {
                Students student = new Students
                {
                    ID = reader["ID"].ToString(),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    HomePhone = reader["HomePhone"].ToString(),
                    BirthdayYear = reader["BirthdayYear"].ToString(),
                    Class = reader["Class"].ToString(),
                    Address = reader["Address"].ToString()
                };
                StudentsList.Add(student);
            }
            reader.Close();
            return StudentsList;
        }
        public List<Teachers> LoadTeachersDetails()
        {
            var reader = Database.ReadFromDbTeachers();
            while (reader.Read())
            {
                Teachers teacher = new Teachers()
                {
                    ID = reader["ID"].ToString(),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Phone = reader["Phone"].ToString(),
                    MailAddress = reader["MailAddress"].ToString(),
                };
                TeachersList.Add(teacher);
            }
            reader.Close();
            return TeachersList;
        }
    }
}