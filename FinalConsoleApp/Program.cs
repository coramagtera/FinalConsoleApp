using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }


        private static void ShowMenu()
        {
            Console.WriteLine("Final Console Demo");
            Console.WriteLine();


            string option;
            bool repeat = true;

            do
            {
                Console.WriteLine("Make a selection:");
                Console.WriteLine("1- Show Instructors ");
                Console.WriteLine("2- Show Students");
                Console.WriteLine("3- Find a Student");
                //Console.WriteLine("4- Find an Instructor");
                Console.WriteLine("0- Exit");
                Console.Write("Enter an option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        //Get instructors
                    //    ShowInstructors();
                        break;
                    case "2":
                        //Get students
                        ShowStudents();
                        break;
                    case "3":
                        //Find students
                       // FindStudent();
                        break;
                    //case "4":
                    //FindInstructor();
                    //FindPerson("Instructor");
                    //    break;
                    case "0":  // End
                        repeat = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Wrong option. Please re-enter\n");
                        break;
                }

            } while (repeat);
        }

        private static void ShowStudents()
        {
            //instantiate the student data mapper class
            StudentDataMapper student_mapper = new StudentDataMapper();
            // var students = student_mapper.Select();
            List <Student> students = student_mapper.Select();
            var output = new StringBuilder();
            output.AppendLine("Student ID\tFirst Name\tLast Name\tEnroll Date\tMajor");
            output.AppendLine("---------\t---------\t---------\t---------\t---------");

            foreach(var stu in students)
            {

                output.AppendLine(stu.ID.ToString ().PadRight(10));
                output.Append("\t");
                output.Append
            }
        }
    }
}
