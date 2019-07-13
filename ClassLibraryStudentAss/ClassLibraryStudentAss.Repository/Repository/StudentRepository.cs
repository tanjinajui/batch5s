using ClassLibraryStudentAss.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryStudentAss.Repository.Repository
{
    public class StudentRepository
    {
        public string AddStudent(Student student)
        {
            return "Student ID: " + student.Id + "Name: " + student.Name + "Roll: " + student.RollNo + "Address: "
                + student.Address + "Contact: " + student.Contact;
        }
    }
}
