using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoApp
{
    /// <summary>
    /// Admin class is the factory class.
    /// </summary>
    static class Admin
    {
        public static List<Student> students = new List<Student>();
        public static List<Course> courses = new List<Course>();

        /// <summary>
        /// Static method to add a new student to the list of students
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="email"></param>
        /// <param name="dob"></param>
        /// <returns></returns>
        public static Student AddStudent(string name, string address, string email, DateTime dob)
        {
            var s1 = new Student
            {
                Name = name,
                Address = address,
                Email = email,
                Dob = dob
            };
            students.Add(s1);
            return s1;
        }

        public static IEnumerable<Student> GetAllStudents()
        {
            return students;
        }

        public static Course AddCourse(string name, int creditHours)
        {
            var c1 = new Course
            {
                Name = name,
                CreditHours = creditHours
            };
            courses.Add(c1);
            return c1;
        }

        public  static IEnumerable<Course> GetAllCourses()
        {
            return courses;
        }
    }
}
