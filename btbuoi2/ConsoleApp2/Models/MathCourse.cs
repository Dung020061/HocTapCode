using System;
using System.Collections.Generic;

namespace ConsoleApp2.Models
{
    public partial class MathCourse
    {
        public int Id { get; set; }
        public string MathTopic { get; set; }
        public string MathInstructor { get; set; }
        public int? CoursesId { get; set; }

        public virtual Course Courses { get; set; }
    }
}
