using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            while (int.TryParse(Console.ReadLine(), out num))
            {   
                if (num > 0)
                    Tower.Hanoi(num);
                else
                    Console.WriteLine("enter a number >0");
                
            }
        }

       

    }
}
