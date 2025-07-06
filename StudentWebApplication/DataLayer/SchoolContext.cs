using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentWebApplication.DataLayer
{  
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolContext") { }

        public DbSet<Student> Students { get; set; }

        //public Student GetStudentByIdFromSP(int studentId)
        //{
        //    return this.Database.SqlQuery<Student>(
        //        "EXEC spGetStudentById @p0", studentId).FirstOrDefault();
        //}

        public Student GetStudentByIdFromSP(int studentId)
        {
            // Run the stored procedure and get a list of students
            var result = Database.SqlQuery<Student>("EXEC spGetStudentById @p0", studentId);

            // Return the first student from the result or null if no match found
            return result.FirstOrDefault();
        }
    }

}