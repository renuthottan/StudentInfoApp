using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentInfoApp
{
    /// <summary>
    /// Admin class is the factory class.
    /// </summary>
    public static class Admin
    {
        private static AdminContext db = new AdminContext();

        /// <summary>
        /// Adds new student
        /// </summary>
        /// <param name="name">name of student</param>
        /// <param name="address">address of student</param>
        /// <param name="email">email of student</param>
        /// <param name="dob">date of birth of student</param>
        /// <returns>newly created student account</returns>
        public static Student AddStudent(string name, string address, string email, DateTime dob)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("name", "Name is required!");
            }
            if (string.IsNullOrEmpty(address) || string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentNullException("address", "Address is required!");
            }
            if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentNullException("email", "Email address is required!");
            }
            var s1 = new Student
            {
                Name = name,
                Address = address,
                Email = email,
                Dob = dob
            };

            db.Students.Add(s1);
            db.SaveChanges();

            return s1;
        }

        /// <summary>
        /// Obtain all students info
        /// </summary>
        /// <returns>list of students</returns>
        public static IEnumerable<Student> GetAllStudents()
        {
            return db.Students;
        }

        /// <summary>
        /// Adds new course
        /// </summary>
        /// <param name="name">Course name</param>
        /// <param name="creditHours">credit hours for the course</param>
        /// <returns>newly created course</returns>
        public static Course AddCourse(string name, int creditHours)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name", "Name is required!");
            
            var c1 = new Course
            {
                Name = name,
                CreditHours = creditHours
            };
            db.Courses.Add(c1);
            db.SaveChanges();
            return c1;
        }

        /// <summary>
        /// Obtain all course info
        /// </summary>
        /// <returns>list of courses</returns>
        public  static IEnumerable<Course> GetAllCourses()
        {
            return db.Courses;
        }

        /// <summary>
        /// Adds score and course details to existing student profile
        /// </summary>
        /// <param name="sId">student id</param>
        /// <param name="cId">course id of course taken by student</param>
        /// <param name="score">score obtained by student for particular course</param>
        public static void AddStudentScore(int sId, int cId, int score)
        {
            var student = GetStudentByStudentId(sId);
            var cs = new CourseScore
            {
                StudentId = sId,
                CourseId = cId,
                Score = score
            };
            db.CourseScores.Add(cs);
            db.SaveChanges();
        }

        /// <summary>
        /// Obtain student details using student ID
        /// </summary>
        /// <param name="sId">Id of student</param>
        /// <returns>student account</returns>
        public static Student GetStudentByStudentId(int sId)
        {
            var student = db.Students.SingleOrDefault(s => s.Id == sId);
            if (student == null)
            {
                return null;
            }
            return student;
        }

        public static IEnumerable<CourseScore>
            GetScoresForStudent(int sId)
        {
            return db.CourseScores
                .Where(c => c.StudentId == sId);
        }



    }
}
