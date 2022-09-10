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
            bool wrong = false;
            int score = 0;


            while (wrong == false)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(0, 3);


                Console.WriteLine("Guess a number between 1 and 3: ");
                int guess = int.Parse(Console.ReadLine());


                if (guess == randomNumber)
                {
                    Console.WriteLine("You guessed correct!");
                    score++;
                }
                else
                {
                    wrong = false;
                    Console.WriteLine(score + " Points");
                    Console.WriteLine("__________________________________________________");
                    score = 0;
                }
            }



            Console.ReadLine();
        }
    }
}
