using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class StudentRepoV2 : IStudentRepo
    {
        public List<Student> GetAll() { 
            //
            //
            return new List<Student> { new Student() };
        }
        public bool CreateStudent()
        {
            //
            //
            return true;
        }

        public bool Create(Student s)
        {
            throw new NotImplementedException();
        }

        public List<Student> Get()
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Student s)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
