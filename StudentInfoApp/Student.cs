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

        

        
        }

    
}
