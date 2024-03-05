using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 
{
    internal class Game {
        
        // Three instances of the Die class to represent the three dice rolled in the game
        private Die _die1 = new Die();
        private Die _die2 = new Die();
        private Die _die3 = new Die();
        
        /// <summary>
        /// Simulates rolling three dice
        /// Returns the total sum along with individual roll values
        /// </summary>
        /// <returns> Returns the total, roll1, roll2 and roll3 </returns>
        public (int total, int roll1, int roll2, int roll3) RollTotal() {
            
            // Rolls each die and stores the result in variables
            int roll1 = _die1.Roll();
            int roll2 = _die2.Roll();
            int roll3 = _die3.Roll();
            
            // Calculate the total sum of the three rolls
            int total = roll1 + roll2 + roll3;

            // Returns a tuple containing the total sum and individual roll values
            return (total, roll1, roll2, roll3);
        }
    }
}
