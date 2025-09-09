using DAL.EF;
using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StudentRepo : IRepo<Student,int,bool>, IStudentFeature
    {
        UMSContext db;
        public StudentRepo() {
            db = new UMSContext();
        }
        public bool Create(Student s) { 
            db.Students.Add(s);
            return db.SaveChanges() > 0;
        }
        public Student Get(int id) { 
        
            return db.Students.Find(id);
        }
        public List<Student> Get() { 
            return db.Students.ToList();
        }
        public bool Update(Student s) { return true; }
        public bool Delete(int id) { return false; }

        public float CalculateCgpa(int id) {
            //GPA Calc
            //Credit Calc
            //Retake Grade Map
            //Final Cgpa
            return 3.45f;
        }
    }
}
