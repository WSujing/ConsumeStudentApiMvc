using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConsumeStudentApiMvc.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string StudentId { get; set; }

        [Required]
        [MaxLength(100)]        
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Address { get; set; }

        [Required]
        [Display(Name ="Course")]
        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}