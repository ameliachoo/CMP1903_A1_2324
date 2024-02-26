using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        //Property
        private static Random _rnd = new Random();
        
        public int DiceRoll = _rnd.Next(1, 7);
        
        //Method
        public int Roll()
        {
            DiceRoll = _rnd.Next(1, 7);
            return DiceRoll;
        }
    }
}
