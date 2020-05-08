using System;
using System.Collections.Generic;
using System.Text;

namespace Masterclass_Inheritance_Challenge
{
    class Bosses:Employee
    {
        public bool CompanyCar { get; set; }

        public Bosses() { }

        public Bosses(string title, string firstName, int salary, bool companyCar)
        {
            this.Title = title;
            this.FirstName = firstName;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("Managing...");
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - is paid {2} and has a company car = {3}", this.Title, this.FirstName, this.Salary, this.CompanyCar);
        }
    }
}
