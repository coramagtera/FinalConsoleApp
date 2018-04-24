using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    public class Student:Person
    {
        //the : is the inheritance sumbol
        //student is inherting all the properites from Person

        //stiedemt specofoc prperties
        public DateTime EnrollDate { get; set; }

        public string Major { get; set; }

        //read only property

        public string StudentName
        {
            get
            {
                //return FirstName + "" + LastName;
                return LastName + ", " + FirstName;
            }
        }

        public static implicit operator Student(Student v)
        {
            throw new NotImplementedException();
        }
    }
}
