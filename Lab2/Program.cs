using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    enum EmpType : byte
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VP = 9
    }

    struct Employee
    {
        public EmpType title;
        public string name;
        public short deptID;
    }

    class StructTester
    {
        static void Main(string[] args)
        {
            Employee fred;
            fred.deptID = 40;
            fred.name = "Fred";
            fred.title = EmpType.Grunt;
        }
    }
}
