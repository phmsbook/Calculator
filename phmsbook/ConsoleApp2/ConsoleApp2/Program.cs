using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            rd.Next();
            for (int a = 0; a < 100; a++)
            {
                int i = rd.Next(1, 3);
                Console.WriteLine(i);
            }
            Console.ReadKey();
            
        }
    }
}
