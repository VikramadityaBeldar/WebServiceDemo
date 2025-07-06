using StudentWebApplication.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentWebApplication.RepositoryLayer
{
    public class StudentRepository : IStudentRepository
    {
        public Student GetStudentById(int id)
        {
            using (var context = new SchoolContext())
            {
                return context.GetStudentByIdFromSP(id);
            }
        }
    }

}