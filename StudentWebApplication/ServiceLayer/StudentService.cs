using StudentWebApplication.RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentWebApplication.ServiceLayer
{
    public class StudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService()
        {
            _repository = new StudentRepository();
        }

        public Student GetStudentById(int id)
        {
            if (id <= 0) throw new ArgumentException("Invalid ID");
            return _repository.GetStudentById(id);
        }
    }

}