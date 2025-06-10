using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.After_OCP
{
    internal class WHQuestion : Question
    {
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
        }
    }
}
