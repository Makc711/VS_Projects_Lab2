using System;

namespace Lab2
{
    class Person
    {
        string _fam = "";
        string _status = "";
        string _health = "";
        int _age, _salary;

        const int ChildMax = 10;   //максимальное число детей
        Person[] _children = new Person[ChildMax];
        int _countChildren = 0;    //текущее число детей объекта

        public Person this[int i] 
        { //индексатор
            get => _children[(i >= 0 && i < _countChildren) ? i : 0];
            set
            {
                if (i == _countChildren && i < ChildMax) 
                {
                    _children[i] = value;
                    _countChildren++;
                }
            }
        }


        public string Fam 
        {	    //стратегия: Read,Write-once 
            set { if (_fam == "") _fam = value; }
            get => _fam;
        }

                //стратегия: Read-only
        public string Status => _status;

        public int Age 
        {       //стратегия: Read,Write 
            set
            {
                _age = value;
                if (_age < 7)
                    _status = "ребенок";
                else if (_age < 17)
                    _status = "школьник";
                else if (_age < 22)
                    _status = "студент";
                else
                    _status = "служащий";
            }
            get => _age;
        }

        public int Salary 
        {        //стратегия: Write-only 
            set => _salary = value;
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

        public static void TestPersonChildren()
        {
            Person pers1 = new Person(), pers2 = new Person();
            pers1.Fam = "Петров";
            pers1.Age = 42;
            pers1.Salary = 10000;
            pers1[pers1._countChildren] = pers2;
            pers2.Fam = "Петров";
            pers2.Age = 21;
            pers2.Salary = 1000;
            Console.WriteLine("Фам={0}, возраст={1}, статус={2}", pers1.Fam, pers1.Age, pers1.Status);
            Console.WriteLine("Сын={0}, возраст={1}, статус={2}", pers1[0].Fam, pers1[0].Age, pers1[0].Status);
        }
    }
}
