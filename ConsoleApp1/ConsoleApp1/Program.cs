using ConsoleApp1.Database;
using ConsoleApp1.Entites;
using ConsoleApp1.Repository;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
 
        static void Main(string[] args)
        {

            #region CreateListOfTeachers

            //Loop:
            //Teachers TE1 = new Teachers()
            //{
            //    //Id = 1,
            //    Name = Console.ReadLine(),
            //    Address = Console.ReadLine(),
            //    Telephone = double.Parse(Console.ReadLine()),
            //    SubjectsId = int.Parse(Console.ReadLine()),
            //};

            //List<Teachers> TeachersData = new List<Teachers>();
            //TeachersData.Add(TE1);

            //TeachersRepo TR = new TeachersRepo();
            //TR.CreateListOfTeachers(TeachersData);
            //goto Loop;

            #endregion

            #region CreateListOfStudents

            //Loop:
            //Students St = new Students()
            //{
            //    //Id = 1,
            //    Name = Console.ReadLine(),
            //    Gender = Console.ReadLine(),
            //    HireDate = DateTime.Today,
            //    SubjectsId = int.Parse(Console.ReadLine()),

            //};

            //List<Students> StudentsData = new List<Students>();
            //StudentsData.Add(St);

            //StudentRepo SR = new StudentRepo();
            //SR.CreateListOfStudent(StudentsData);
            //goto Loop;

            #endregion


            #region LinQ

            using (DbContainer Db = new DbContainer())
            {
                var data = Db.Students.Join(Db.Subjects,
                    st => st.SubjectsId,
                    sub => sub.Id,

                    (st, sub) => new
                    {
                        sname = st.Name,
                        sub.Name
                    });

                foreach (var item in data)
                {
                    Console.WriteLine(item.sname + "\n" + item.Name);
                    Console.WriteLine("==============================================");
                }            
            }

            #endregion
        }
    }
}
