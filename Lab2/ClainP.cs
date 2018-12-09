using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class ClainP : IProps
    {
        public ClainP() { }

        void IProps.Prop1(string s)
        {
            Console.WriteLine(s);
        }

        void IProps.Prop2(string name, int val)
        {
            Console.WriteLine("name = {0}, val ={1}", name, val);
        }

        // Пример обертывания закрытых методов:
        public void MyProp1(string s)
        { // Кастинг:
            ((IProps)this).Prop1(s);
        }

        public void MyProp2(string s, int x)
        { // Кастинг:
            ((IProps)this).Prop2(s, x);
        }

        public static void TestClainIProps()
        {
            Console.WriteLine("Объект класса ClainP вызывает открытые методы!");
            ClainP clain = new ClainP();
            clain.MyProp1("Свойство 1 объекта");
            clain.MyProp2("Владимир", 44);
            Console.WriteLine("Объект класса IProps вызывает открытые методы!");
            IProps ip = (IProps)clain;
            ip.Prop1("интерфейс: свойство");
            ip.Prop2("интерфейс: свойство", 77);
            Console.WriteLine();
        }
    }
}
