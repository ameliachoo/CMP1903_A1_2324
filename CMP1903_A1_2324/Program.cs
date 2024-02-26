using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = null;
            
            Game game = new Game();
            Testing tests = new Testing();

            tests.RunTest();
            
            while (userInput != "exit")
            {
                (int sum, int firstRoll, int secondRoll, int thirdRoll) = game.RollTotal();
                
                Console.WriteLine($"First roll = {firstRoll}\nSecond roll = {secondRoll}\nThird roll = {thirdRoll}\nSum = {sum}\nPress enter to roll again or type 'exit' to exit the program:");
                userInput = Console.ReadLine();
            }
        }
    }
}
