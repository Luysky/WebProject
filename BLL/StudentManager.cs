using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class StudentManager : IStudentManager
    {
       
        private IStudentDB StudentDb { get; }

        public StudentManager (IStudentDB studentDB)
        {
            StudentDb = studentDB;
        }

        public List<Student> GetStudentById(int Id)
        {
            return StudentDb.GetStudentById(Id);
        }
    }
}
