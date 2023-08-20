using System;
using System.Collections.Generic;

namespace ConsoleApp2.Models
{
    public partial class Course
    {
        public Course()
        {
            EnglishCourses = new HashSet<EnglishCourse>();
            MathCourses = new HashSet<MathCourse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }

        public virtual ICollection<EnglishCourse> EnglishCourses { get; set; }
        public virtual ICollection<MathCourse> MathCourses { get; set; }
    }
}
