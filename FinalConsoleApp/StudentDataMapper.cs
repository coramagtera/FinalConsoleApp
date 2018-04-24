using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FinalConsoleApp
{
    public class StudentDataMapper : IDataMapper<Student>
    {
        private string path;

        public StudentDataMapper()
        {
            path = AppDomain.CurrentDomain.BaseDirectory + "Students.txt";
        }

        private List<Student>GetStudents()
        {
            List<Student> students = new List<Student>();

            //read from students.txt (usging the system.id)
            if(File.Exists(path))
                {
                var sr = new StreamReader(path);
                string line;
                //read each line in students.txt and populate student object
                //with values from line whtin the fille

                while( (line = sr.ReadLine() = !null )
                {
                    var elems = line.Split(",");//ceeate array from CSV
                    var student = new Student
                    {
                        ID = Int16.Parse(elems[0]),
                        FirstName = elems[1],
                        LastName = elems[2],
                        Address = elems[3],
                        City = elems[4],
                        Province = elems[5],
                        PostalCode = elems[6],
                        Phone = elems[7],
                        Email = elems[8],
                        EnrollDate = DateTime.Parse(elems[9]),
                        Major = elems[10]

                    };
                    //add each new student ()one for each line in students.txt to list
                    students.Add(student);
                }
            }

            return students;
        }
        public List<Student> Find(string LastName)
        {
            throw new NotImplementedException();
        }

        public List<Student> Select()
        {
            return GetStudents();
        }
    }
}
