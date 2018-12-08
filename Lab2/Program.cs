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

            TestPersonProps();

            Console.ReadKey();
        }

        public static void TestPersonProps()
        {
            Person pers1 = new Person();
            pers1.Fam = "Петров";
            pers1.Age = 21;
            pers1.Salary = 1000;
            Console.WriteLine("Фам={0}, возраст={1}, статус={2}", pers1.Fam, pers1.Age, pers1.Status);
            pers1.Fam = "Иванов";
            pers1.Age += 1;
            Console.WriteLine("Фам={0}, возраст={1}, статус={2}", pers1.Fam, pers1.Age, pers1.Status);
        }
    }
}