using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    class Instructor:Person
    {
        //instrucyor all propereits from person
        //instucotr spesfic properites
        public DateTime HireDate { get; set; }//property

        private string _rank; //private field

        public string Rank
        {
            get
            {
                int years = YearsOfWork(this.HireDate);
                if(years >=25)
                {

                    _rank = Ranking.DistinguisedProfesser.ToString();
                }
                else if(years >= 20)
                {
                    _rank = Ranking.FullProfesser.ToString();
                }
                else if (years >= 15)
                {
                    _rank = Ranking.AssociateProfesser.ToString();
                }
                else if (years >= 10)
                {
                    _rank = Ranking.AssitantProfesser.ToString();
                }
                else
                {
                    _rank = Ranking.Instructor.ToString();
                }
                return _rank;
            }
            set
            {
                _rank = value;
            }
        }

        //ranking enum
        private enum Ranking:Byte
        {
            Instructor=1,
            AssitantProfesser = 2,
            AssociateProfesser = 3,
            FullProfesser=4,
            DistinguisedProfesser
        }

        private static int YearsOfWork(DateTime HireDate)
        {
            DateTime now = DateTime.Today;
            int yrsExp = now.Year - HireDate.Year;
            if (HireDate.AddYears(yrsExp) > now)
                yrsExp--;

            return yrsExp;
        }

        public string InstructorName
        {
            get
            {
                return FirstName + " " + LastName;
            }


        }

    }
}
