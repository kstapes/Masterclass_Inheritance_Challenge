using System;

namespace Masterclass_Inheritance_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Floor Worker", "John", 25000);
            Console.WriteLine(emp.ToString());
            emp.Work();
            emp.Pause();

            Bosses boss = new Bosses("Floor Manager", "David", 40000, true);
            Console.WriteLine(boss.ToString());
            boss.Work();
            boss.Lead();
            boss.Pause();

            Trainees trainee = new Trainees("Floor Trainee", "Michael", 18000, 20);
            Console.WriteLine(trainee.ToString());
            trainee.Learn();

            
        }
    }
}
