using System;
using System.Collections.Generic;
using System.Text;

namespace Masterclass_Inheritance_Challenge
{
    class Employee
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee() { }

        public Employee(string title, string firstName, int salary) 
        {
            this.Title = title;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("Working...");
        }

        public void Pause()
        {
            Console.WriteLine("taking a break...\n");
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - is paid {2}", this.Title, this.FirstName, this.Salary);
        }
    }
}
