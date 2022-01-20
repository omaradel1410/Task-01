using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entites
{
    public class Student_Subject
    {
        public int Id { get; set; }

        public int StudentId { get; set; } // Forgin Key For Student 
        public Student Student { get; set; } // Navgation 

        public int SubjectsId { get; set; } // Forgin Key For Subjects 
        public Subject Subject { get; set; } // Navgation 

    }
}
