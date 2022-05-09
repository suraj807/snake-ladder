using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game\n");
           
            int dicenum;   //var

            Random random = new Random();    // Creating object of Random class
            dicenum = random.Next(1, 7);    // Generating random number 0 , 1 , 2 ,3 ,4,5,6
            Console.WriteLine($"After rolling Dice,The number display on the Dice is : {dicenum}");

            Console.ReadLine();

            
        }
    }
}
