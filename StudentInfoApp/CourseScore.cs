using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoApp
{
    class CourseScore
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Score { get; set; }
        public virtual Student Student { get; set; }

    }
}
