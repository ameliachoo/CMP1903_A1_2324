using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
    
    internal class Die {
        
        // Static random number generator for all instances of Die
        private static Random _rnd = new Random();
        
        /// <summary>
        /// Represents the current value of the die roll
        /// </summary>
        public int DiceRoll = _rnd.Next(1, 7);
        
        /// <summary>
        /// Rolls the die and returns the result
        /// </summary>
        /// <returns> Returns the DiceRoll </returns>
        public int Roll() {
            
            // Generate a random number between 1 and 6 (inclusive) to simulate a die roll
            DiceRoll = _rnd.Next(1, 7);
            
            // Return the result of the die roll
            return DiceRoll;
        }
    }
}
