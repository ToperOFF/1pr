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
        }

    }
    class TovarClass
    {
        public string Name;
        public int Kolvo;
        public float Stoimost;
        public TovarClass(string name, int kolvo, float stoimost)
        {
            Name = name;
            Kolvo = kolvo;
            Stoimost = stoimost;
        }
    }
}
