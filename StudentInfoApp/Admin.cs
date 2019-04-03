using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoApp
{
    /// <summary>
    /// Admin class is the factory class.
    /// </summary>
    class Admin
    {
        public static List<Student> students = new List<Student>();
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

    }
}
