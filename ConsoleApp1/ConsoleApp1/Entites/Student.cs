using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entites
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public DateTime HireDate { get; set; }

        public ICollection<Subject> Subject { get; set; }

    }
}
