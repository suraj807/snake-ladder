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

            

            int dicenum;
            int currentBoardPosition = 0;

            int[] snake = { 2, 8, 9, 65, 87, 93, 96, 98 };
            int[] ladder = { 4, 5, 26, 29, 36, 55, 71, 90 };

            Random random = new Random();    // Creating object of Random class
            dicenum = random.Next(1, 7);     // Generating random number 0 , 1 , 2 ,3 ,4,5,6
            Console.WriteLine("snake leader game is starting 0 or ending 100 \n");
            Console.WriteLine($"After rolling Dice,The number display on the Dice is : {dicenum}");
        

            currentBoardPosition += dicenum; // currentboard = dicenumber

            Console.WriteLine($"You are now at position : {currentBoardPosition}");

            if (Array.Exists(snake, x => x == currentBoardPosition))  
            {
                currentBoardPosition -= dicenum;    // currentbordposition - dicenum eg:- 2-2=0
                Console.WriteLine($"\nYou reached at top of Snake , So You moved {dicenum} steps behind\n");
            }
            if (Array.Exists(ladder, x => x == currentBoardPosition))
            {
                Console.WriteLine($"You reached at bottom of Ladder , So You moved {dicenum} steps ahead\n");
                currentBoardPosition += dicenum; // currentbordposition + dicenum eg:- 4+4 =8
            }


            Console.WriteLine($"\nYou are now at position : {currentBoardPosition}"); 

            Console.ReadLine();


        }
    }
}
