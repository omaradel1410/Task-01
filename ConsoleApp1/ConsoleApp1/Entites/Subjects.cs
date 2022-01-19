using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entites
{
    [Table("Subjects")]
    public class Subjects
    {

        //public Subjects()
        //{
        //    this.Students = new HashSet<Students>();
        //}



        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Students> Students { get; set; }
        public ICollection<Teachers> Teachers { get; set; }

    }
}
