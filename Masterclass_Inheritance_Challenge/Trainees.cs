using System;
using System.Collections.Generic;
using System.Text;

namespace Masterclass_Inheritance_Challenge
{
    class Trainees:Employee
    {
        public int SchoolHours { get; set; }

        public Trainees() { }

        public Trainees(string title, string firstName, int salary,int schoolHours)
        {
            this.Title = title;
            this.FirstName = firstName;
            this.Salary = salary;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("Learning...");
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - is paid {2} and is in training for {3} hours a week", this.Title, this.FirstName, this.Salary, this.SchoolHours);
        }
    }
}
