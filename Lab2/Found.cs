using System;

namespace Lab2
{
    public class Found
    {
        protected string name;
        protected int credit;

        public Found() { }

        public Found(string name, int sum)
        {
            this.name = name;
            credit = sum;
        }

        public virtual void VirtMethod()
        {   //виртуальный метод
            Console.WriteLine("Отец: " + this.ToString());
        }

        //переопределенный метод базового класса Object
        public override string ToString()
        {
            return String.Format("поля: name = {0}, credit = {1}", name, credit);
        }

        public void NonVirtMethod()
        {
            Console.WriteLine("Мать: " + this.ToString());
        }

        public void Analysis()
        {
            Console.WriteLine("Простой анализ");
        }

        public void Work()
        {
            VirtMethod();
            NonVirtMethod();
            Analysis();
        }

        public static void TestFoundProps()
        {
            Found found = new Found("Иван", 31);
            found.Work();
            Console.WriteLine();
        }
    }
}
