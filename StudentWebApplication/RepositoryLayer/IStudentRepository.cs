using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWebApplication.RepositoryLayer
{
    public interface IStudentRepository
    {
        Student GetStudentById(int id);
    }

}
