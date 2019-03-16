using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoApp
{
    /// <summary>
    /// Student class holds all student information
    /// </summary>
    class Student
    {
        #region Properties
        /// <summary>
        /// unique id for student
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// student first and last name
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// address of student 
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// email address of student 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// date of birth of student
        /// </summary>
        public DateTime dob { get; set; }
        /// <summary>
        /// List of courses taken by student
        /// </summary>
        public List<Course> courseList;
      
        #endregion

        #region Methods
        /// <summary>
        /// method to calculate GPA of a student
        /// </summary>
        public double CalculateGPA ()
        {
        }
        /// <summary>
        /// method to add course and score to student profile
        /// </summary>
        /// <param name="course">object of class Course</param>
        public void AddCourse (Course course)
        {
        }
        #endregion
    }
}
