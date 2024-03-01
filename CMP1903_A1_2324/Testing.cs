﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /// <summary>
        /// The testing class contains a method for 'RunTest' which is responsible for executing tests on the 'Game' object
        /// The method creates an instance of the 'Game' class and then iterates through a loop 1000 times to conduct multiple tests
        /// After completing the tests, it prints a message indicating that all tests have been successful
        /// </summary>
        /// <returns> Returns 0 if all tests pass </returns>

        /* Int works well for allowing multiple exit codes to indicate different results from testing. */
        /* This isn't implemented, so consider using bool for successful/failed test results, or void since there is currently only one return statement. */
        public int RunTest()
        {
            // Creates a new instance of the Game class
            Game game = new Game();
            
            // Loops 1000 times to run multiple tests
            for (int i = 0; i < 1000; i++)
            {
                // Destructuring assignment to get values from RollTotal method
                (int sum, int firstRoll, int secondRoll, int thirdRoll) = game.RollTotal();
                
                // Assertion to ensure the sum is between 3 and 18
                Debug.Assert(sum >= 3 && sum <= 18);
                // Assertion to ensure the value of all three dice is between 1 and 6
                Debug.Assert(firstRoll >= 1 && firstRoll <= 6);
                Debug.Assert(secondRoll >= 1 && secondRoll <= 6);
                Debug.Assert(thirdRoll >= 1 && thirdRoll <= 6);
            }
            
            /* When running in Release mode, the program still outputs the following message, even though tests aren't run. */
            /* Consider using Debug.WriteLine() instead. */

            // Prints message indicating all tests passed
            Console.WriteLine("All tests passed.");

            /* As mentioned elsewhere, could use a bool instead, as this runs even if tests fail. */

            // Returns 0 to indicate success
            return 0;
        }
    }
}
