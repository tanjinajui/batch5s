using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new { ID = 1, nameof = "Jui", Address = "Dhaka", LoyaltyPoint = 134 };
            var student = new[]
            {
                new{Id= 1, Name = "Tanjina", Roll= 1},
                new {Id=2, Name="Jui", Roll= 1},
                new {Id=2, Name="Moli",Roll= 1}
        };
            //foreach(var s in student)
            //{
            //    Console.WriteLine( s.Id + "" + s.Name+ ""+ s.Roll);
            //}
            //Console.ReadKey();
            ShowStudents(student);
        }
        public static void ShowStudents(dynamic student)
        {
            int count = 1;
            Console.WriteLine();
            foreach (var s in student)
            {
                Console.WriteLine("Student Id: " + s.Id + " " + "\nName:" + s.Name + "" + " Roll: "+ s.Roll);
                
            }
            Console.ReadKey();
        }
    }
            
    }

