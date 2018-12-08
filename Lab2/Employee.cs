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
}
