﻿using ConsoleApp1.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    internal interface IStudentRepo
    {
        public string CreateListOfStudent(List<Student> obj);


    }
}
