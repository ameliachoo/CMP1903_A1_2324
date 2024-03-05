using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
    
    internal class Program {
        
        static void Main(string[] args) {
            
            // Variable to store user input
            string userInput = null;
            
            // Create instances of the Game and Testing classes
            Game game = new Game();
            Testing tests = new Testing();
            
            // Runs tests to ensure correctness of the game logic (works in debug mode)
            tests.RunTest();
            
            while (userInput != "exit") {
                
                // Rolls three dice and retrieves the total and individual roll values
                (int sum, int firstRoll, int secondRoll, int thirdRoll) = game.RollTotal();
                
                // Displays the results of the dice rolls and the total sum to the user
                Console.WriteLine($"First roll = {firstRoll}\nSecond roll = {secondRoll}\nThird roll = {thirdRoll}\nSum = {sum}\nPress enter to roll again or type 'exit' to exit the program:");
                // Reads user input to continue rolling or exit the program
                userInput = Console.ReadLine();
            }
        }
    }
}
