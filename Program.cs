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

            Console.WriteLine(TC.Name + " " + TC.Kolvo + " " + TC.Stoimost);

        }
    }
    class TovarClass
    {
        public string Name;
        public int Kolvo;
        public float Stoimost;
    }
}
