using ConsoleApp1.Database;
using ConsoleApp1.Entites;
using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repository
{
    public class StudentRepo : IStudentRepo
    {
    

        public string CreateListOfStudent(List<Student> obj)
        {
            try
            {
                using (DbContainer Db = new DbContainer())
                {
                    Db.Student.AddRange(obj);
                    Db.SaveChanges();
                    Console.WriteLine("Data Created !");
                }
                return "Data Saved !";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                return ex.Message;
            }
        }

    }
}
