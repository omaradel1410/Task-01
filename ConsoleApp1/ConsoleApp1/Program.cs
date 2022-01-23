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


                //var results = from s in Db.Student
                //              join St_Sb in Db.Student_Subject on s.Id equals St_Sb.StudentId
                //              join Sub in Db.Subject on St_Sb.SubjectId equals Sub.Id
                //              where (s.Id == St_Sb.StudentId) && (Sub.Id == St_Sb.SubjectId)

                //             select new Sub_STVIewModel() { StName = s.Name, SubName = Sub.Name, StId = s.Id , NumberOfSUbject = St_Sb.SubjectId};

                //foreach (var it in results)
                //{
                //    Console.WriteLine(it.StId + " " + it.StName + " " + it.SubName + " " + it.NumberOfSUbject);          
                //}



                //var results = from s in Db.Student
                //              join St_Sb in Db.Student_Subject on s.Id equals St_Sb.StudentId
                //              join Sub in Db.Subject on St_Sb.SubjectId equals Sub.Id
                //              where (s.Id == St_Sb.StudentId) && (Sub.Id == St_Sb.SubjectId)
                //              select new Sub_STVIewModel()
                //              {
                //                  StName = s.Name,
                //                  SubName = Sub.Name,
                //                  StId = s.Id,
                //                  NumberOfSUbject = St_Sb.SubjectId

                //              };

                //foreach (var it in results)
                //{
                //    Console.WriteLine(it.StId + " " + it.StName + " " + it.SubName + " " + it.NumberOfSUbject);
                //}


                //var data = Db.Student.Select(x => new Sub_STVIewModel
                //{
                //    StId = x.Id,
                //    StName = x.Name,
                //    NumberOfSubject = x.Student_Subject.Count(),
                //});

                //foreach (var item in data)
                //{
                //    Console.WriteLine(item.StId + " " + item.StName + " => " + item.NumberOfSubject + " Subjects");
                //}


                Console.WriteLine("Please Enter Your Id");
                int Id = int.Parse(Console.ReadLine());

                var data = Db.Student_Subject

                    .Where(x => x.StudentId == Id)
                    .Select(x => new Sub_STVIewModel
                    {
                        StId = x.StudentId,
                        SubjectName = x.Subject.Name,
                    }).ToList();

                 foreach (var x in data)
                 {
                    Console.WriteLine(x.StId + " " + x.SubjectName);
                 }
        
            }

            #endregion
        }
    }
}