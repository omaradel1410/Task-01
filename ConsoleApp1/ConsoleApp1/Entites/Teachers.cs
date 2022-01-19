using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entites
{
    [Table("Teachers")]
    public class Teachers
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Address { get; set; } 
        public double Telephone { get; set; }

        public int SubjectsId { get; set; } // Forgin Key For Subjects 
        public Subjects Subjects { get; set; }  // Navgation 
    }
}
