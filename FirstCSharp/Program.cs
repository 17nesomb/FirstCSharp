using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many pizzas would you like to eat? ");
            int answer = int.Parse(Console.ReadLine());

            for(int i = 0; i < answer; i++)
            {
                Console.WriteLine("Eat Pizza number " + (i+1));
            }
            
            Console.ReadLine();
        }
    }
}
