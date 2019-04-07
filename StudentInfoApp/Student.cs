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
        #region statics
        private static int lastId = 0;
        #endregion
        #region Properties
        /// <summary>
        /// unique id for student
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// student first and last name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// address of student 
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// email address of student 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// date of birth of student
        /// </summary>
        public DateTime Dob { get; set; }

        public List<CourseScore> courseList;

        #endregion

        #region Constructor
        public Student()
        {
            Id = ++lastId;
            courseList = new List<CourseScore>();
        }       

    
    #endregion
    #region Methods

    public void AddScore(int cId, int score)
        {
            var cs = new CourseScore
            {
                CourseId = cId,
                Score = score
            };
            courseList.Add(cs);
        }

        #endregion
    }


    class CourseScore
    {
        public int CourseId;
        public int Score;
    
    };
}
