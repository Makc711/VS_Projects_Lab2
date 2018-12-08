namespace Lab2
{
    class Person
    {
        string _fam = "";
        string _status = "";
        string _health = "";
        int _age, _salary;

        public string Fam 
        {	    //стратегия: Read,Write-once 
            set { if (_fam == "") _fam = value; }
            get => _fam;
        }

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
    }
}
