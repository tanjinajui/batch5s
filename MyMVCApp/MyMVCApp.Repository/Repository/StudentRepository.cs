using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MyMVCApp.DatabaseContext.DatabaseContext;
using MyMVCApp.Models.Models;

namespace MyMVCApp.Repository.Repository
{
    public class StudentRepository
    {
        StudentDBContext db = new  StudentDBContext();
        public bool Add(Student student)
        {
            int isExecuted = 0;
            db.Students.Add(student);
            isExecuted= db.SaveChanges();
            if (isExecuted > 0)
                return true;

            return false;
        }
        public bool Delete(Student student)
        {
            int isExecuted = 0;
            Student astudent = db.Students.FirstOrDefault(c => c.ID == student.ID);
            if (astudent!=null)
            {
                db.Students.Remove(astudent);
                isExecuted = db.SaveChanges();
            }
            
            
            if (isExecuted > 0)
                return true;
            return false;
        }
        public bool Update(Student student)
        {
            int isExecuted = 0;
            Student astudent = db.Students.FirstOrDefault(c => c.ID == student.ID);
            if (astudent != null)
            {
                astudent.Name = student.Name;
                isExecuted = db.SaveChanges();
            }
            if (isExecuted > 0)
                return true;
            return false;
        }
        public List<Student> GetAll(Student student)
        {
            return db.Students.ToList();
        }
        public Student GetByID(Student student)
        {
            Student astudent = db.Students.FirstOrDefault(c => c.ID == student.ID);
            return astudent;
        }
    }
}
