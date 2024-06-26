﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Zadaca.models
{
    public abstract class Person : object
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
    public class Teacher : Person
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class Student : Person
    {
        public int Grade { get; set; }
    }


}
