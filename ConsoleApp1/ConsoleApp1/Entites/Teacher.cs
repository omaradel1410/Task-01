using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entites
{
    public class Teacher
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Address { get; set; } 
        public string Telephone { get; set; }

        public int SubjectId { get; set; } // Forgin Key For Subject
        public Subject Subject { get; set; }  // Navgation 
    }
}
