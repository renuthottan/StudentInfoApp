using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoApp
{
    /// <summary>
    /// Course holds information about all available courses
    /// Can add new courses
    /// </summary>
    class Course
    {
        #region statics
        private static int lastId = 0;
        #endregion

        #region Properties
        /// <summary>
        /// unique id of the course
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// name of the course
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// no of credit hours for the course
        /// </summary>
        public int CreditHours { get; set; }

        #endregion

        #region Constructor
        public Course()
        {
            Id = ++lastId;
        }
        #endregion

    }

}
