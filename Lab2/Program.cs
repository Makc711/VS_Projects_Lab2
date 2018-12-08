using System;

namespace Lab2
{
    enum EmpType : byte
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VP = 9
    }

    class Employee
    {
        private string _fullName;
        private int _empId;
        private float _currPay;

        public Employee() { }

        public Employee(string fullName, int empID, float currPay)
        {
            _fullName = fullName;
            _empId = empID;
            _currPay = currPay;
        }

        public void GiveBonus(float amount)
        {
            _currPay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _fullName);
            Console.WriteLine("Pay: {0}", _currPay);
            Console.WriteLine("ID: {0}", _empId);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Joe", 80, 30000);
            e.GiveBonus(200);
            var e2 = new Employee("Beth", 81, 50000);
            e2.GiveBonus(1000);
            e2.DisplayStats();

            Console.ReadKey();
        }
    }
}