using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] li= new int[6];
            li[2] = 2;
            li[5] = 6;
            li.Where(p => p > 0);
            Console.ReadKey();


        }
    }
}
