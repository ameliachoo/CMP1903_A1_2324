using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private Die _die1 = new Die();
        private Die _die2 = new Die();
        private Die _die3 = new Die();
        
        //Methods
        public (int total, int roll1, int roll2, int roll3) RollTotal()
        {
            int roll1 = _die1.Roll();
            int roll2 = _die2.Roll();
            int roll3 = _die3.Roll();
            
            int total = roll1 + roll2 + roll3;

            return (total, roll1, roll2, roll3);
        }
    }
}
