using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите наименование: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите количество: ");
            int kolvo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите стоимость: ");
            float stoimost = (float)Convert.ToDouble(Console.ReadLine());

            TovarClass TC = new TovarClass(name, kolvo, stoimost);
            TC.NewMethod(TC);
        }
    }
    class TovarClass
    {
        private string Name;
        private int Kolvo;
        private float Stoimost;
        public TovarClass(string name, int kolvo, float stoimost)
        {
            Name = name;
            Kolvo = kolvo;
            Stoimost = stoimost;
        }
        public TovarClass()
        {
            Name = "";
            Kolvo = 0;
            Stoimost = 0;
        }
        public void NewMethod(TovarClass TC)
        {
            Console.WriteLine(TC.Name + " " + TC.Kolvo + " " + TC.Stoimost);
            Console.ReadLine();
        }
    }
}
