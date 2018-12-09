using System;

namespace Lab2
{
    public class Derived : Found
    {
        protected int debet;

        public Derived() { }

        public Derived(String name, int cred, int deb) : base(name, cred)
        {
            debet = deb;
        }

        public void DerivedMethod()
        {	//новый метод потомка
            Console.WriteLine("Это метод класса Derived");
        }

        public new void Analysis()
        {   //сокрытие метода родителя
            base.Analysis();
            Console.WriteLine("Сложный анализ");
        }

        public void Analysis(int level)
        {   // перегрузка метода
            base.Analysis();
            Console.WriteLine("Анализ глубины {0}", level);
        }

        public override String ToString()
        {   //переопределение метода
            return String.Format("поля: name = {0}, credit = {1},debet ={2}", name, credit, debet);
        }

        // переопределение метода  родителя
        public override void VirtMethod()
        {
            Console.WriteLine("Сын: " + this.ToString());
        }

        public new void Work()
        {
            DerivedMethod();
            VirtMethod();
            Analysis(15);
        }

        public static void TestDerivedProps()
        {
            Derived derived = new Derived("Сергей", 31, 25);
            derived.Work();
            Console.WriteLine();
        }
    }
}
