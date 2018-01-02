using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 15; j >= 0; j--)
            {
                for (int t = 0; t <= j; t++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
}
