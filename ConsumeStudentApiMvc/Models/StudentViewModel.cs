using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumeStudentApiMvc.Models
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}