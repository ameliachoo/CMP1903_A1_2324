using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        //Method
        public int RunTest()
        {
            Game game = new Game();

            for (int i = 0; i < 1000; i++)
            {
                (int sum, int firstRoll, int secondRoll, int thirdRoll) = game.RollTotal();

                Debug.Assert(sum >= 3 && sum <= 18);
                Debug.Assert(firstRoll >= 1 && firstRoll <= 6);
                Debug.Assert(secondRoll >= 1 && secondRoll <= 6);
                Debug.Assert(thirdRoll >= 1 && thirdRoll <= 6);
            }
            
            Console.WriteLine("All tests passed.");
            return 0;
        }
    }
}
