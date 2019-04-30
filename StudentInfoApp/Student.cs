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
        /// <summary>
        /// list to store courses taken and scores  obtained by a student
        /// </summary>
        public List<CourseScore> scoreList;

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
        #endregion

        #region Constructor
        public Student()
        {
            Id = ++lastId;
            scoreList = new List<CourseScore>();
        }       
        #endregion

        #region Methods
        /// <summary>
        /// Adds new course and score to an existing student
        /// </summary>
        /// <param name="cId">course id</param>
        /// <param name="score">score obtained by student</param>
        public void AddScore(int sId, int cId, int score)
        {
            var cs = new CourseScore
            {
                StudentId = sId,
                CourseId = cId,
                Score = score
            };
            scoreList.Add(cs);
        }
        #endregion
        }

    /// <summary>
    /// Holds course ID and score obtained by the student
    /// </summary>
    class CourseScore
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Score { get; set; }
        public virtual Student Student { get; set; }



    };
}
