using System;

namespace Lab2
{
    class Program
    {
        static void Main()
        {
            Employee e = new Employee("Joe", 80, 30000);
            e.GiveBonus(200);
            var e2 = new Employee("Beth", 81, 50000);
            e2.GiveBonus(1000);
            e2.DisplayStats();
            Console.WriteLine();

            Person.TestPersonProps();
            Console.WriteLine();
            Person.TestPersonChildren();

            Console.ReadKey();
        }
    }
}