using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoApp
{
    /// <summary>
    /// Course holds infor about all available courses
    /// Can add new courses
    /// </summary>
    class Course
    {
        #region Properties
        /// <summary>
        /// unique id of the course
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// name of the course
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// no of credit hours for the course
        /// </summary>
        public int creditHours { get; set; }
        /// <summary>
        /// Add new score to student profile
        /// </summary>
        public double studentScore { get; set; }
        #endregion

    }

}
