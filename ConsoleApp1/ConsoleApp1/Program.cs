using ConsoleApp1.Database;
using ConsoleApp1.Entites;
using ConsoleApp1.Model;
using ConsoleApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
 
        static void Main(string[] args)
        {

            #region CreateListOfTeachers

            //Loop:
            //Teacher TE1 = new Teacher()
            //{

            //    Name = Console.ReadLine(),
            //    Address = Console.ReadLine(),
            //    Telephone = Console.ReadLine(),
            //    SubjectId = int.Parse(Console.ReadLine()),
            //};

            //List<Teacher> TeacherData = new List<Teacher>();
            //TeacherData.Add(TE1);

            //TeacherRepo TR = new TeacherRepo();
            //TR.CreateListOfTeacher(TeacherData);
            //goto Loop;

            #endregion

            #region CreateListOfStudents

            //Loop:
            //Student St = new Student()
            //{
            //    
            //    Name = Console.ReadLine(),
            //    Gender = Console.ReadLine(),
            //    HireDate = DateTime.Today,
            //    SubjectsId = int.Parse(Console.ReadLine()),
            //};

            //List<Student> StudentData = new List<Student>();
            //StudentsData.Add(St);

            //StudentRepo SR = new StudentRepo();
            //SR.CreateListOfStudent(StudentData);
            //goto Loop;

            #endregion


            #region LinQ

            using (DbContainer Db = new DbContainer())
            {

                var results = from s in Db.Student
                              join St_Sb in Db.Student_Subject on s.Id equals St_Sb.StudentId
                              join Sub in Db.Subject on St_Sb.SubjectId equals Sub.Id                     
                              select new Sub_STVIewModel() { StName = s.Name, SubName = Sub.Name, StId = s.Id , NumberOfSUbject = St_Sb.SubjectId};

                foreach (var it in results)
                {
                    Console.WriteLine(it.StId + " " + it.StName + " " + it.SubName + " " + it.NumberOfSUbject);          
                }

            }

            #endregion
        }
    }
}