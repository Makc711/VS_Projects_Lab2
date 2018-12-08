namespace Lab2
{
    class Person
    {
        string fam = "", status = "", health = "";
        int age = 0, salary = 0;

        public string Fam 
        {	    //стратегия: Read,Write-once 
            set { if (fam == "") fam = value; }
            get { return fam; }
        }

        public string Status 
        {		//стратегия: Read-only
            get { return status; }
        }

        public int Age 
        {       //стратегия: Read,Write 
            set
            {
                age = value;
                if (age < 7)
                    status = "ребенок";
                else if (age < 17)
                    status = "школьник";
                else if (age < 22)
                    status = "студент";
                else
                    status = "служащий";
            }
            get { return age; }
        }

        public int Salary 
        {        //стратегия: Write-only 
            set { salary = value; }
        }
    }
}
