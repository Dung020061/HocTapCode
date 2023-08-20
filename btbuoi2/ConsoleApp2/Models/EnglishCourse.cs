using System;
using System.Collections.Generic;

namespace ConsoleApp2.Models
{
    public partial class EnglishCourse
    {
        public int EnglishCoursesid { get; set; }
        public string EnglishTopic { get; set; }
        public string EnglishInstructor { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

     
      

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
