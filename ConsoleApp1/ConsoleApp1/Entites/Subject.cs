using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entites
{
    public class Subject
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Student> Student { get; set; }
        public ICollection<Teacher> Teachers { get; set; }

    }
}
