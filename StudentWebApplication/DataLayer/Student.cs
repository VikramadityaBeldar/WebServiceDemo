using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentWebApplication
{
    public class Student
    {
        public int ID { get; set; }           // Auto-increment primary key
        [Required]
        public string Name { get; set; }      // Student's full name
        [Required]
        [RegularExpression("Male|Female", ErrorMessage = "Gender must be 'Male' or 'Female'")]
        public string Gender { get; set; }    // "Male" or "Female"
        [Range(0, 100, ErrorMessage = "Marks must be between 0 and 100")]
        public int Marks { get; set; }        // Exam or test marks
    }
}