using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoApp
{
    /// <summary>
    /// StudentCourses has list of the courses each student takes 
    /// </summary>
    class StudentCourses
    {
        #region Properties
        /// <summary>
        /// Student id
        /// </summary>
        public int studentId { get; set; }
        /// <summary>
        /// course id of the course taken by student
        /// </summary>
        public int courseId { get; set; }
        /// <summary>
        /// score obtained by student for that course
        /// </summary>
        public int score { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Add new score to student profile
        /// </summary>
        /// <param name="score"></param>
        public void SetScore(int score)
        {
        }
        #endregion
    }
}
