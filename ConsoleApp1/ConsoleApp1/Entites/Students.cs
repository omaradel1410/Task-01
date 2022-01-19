using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entites
{
    [Table("Students")]
    public class Students
    {

        //public Students()
        //{
        //    this.Subject = new HashSet<Subjects>();
        //}


        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public DateTime HireDate { get; set; }


        public int SubjectsId { get; set; } // Forgin Key For Subjects 
        public Subjects Subjects { get; set; } // Navgation 

        public virtual ICollection<Subjects> Subject { get; set; }


}
}
