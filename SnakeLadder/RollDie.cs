using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    internal class RollDie
    {
        public static void Roll()
        {
            Random random = new Random();
            int Die = random.Next(1, 6);
            Console.WriteLine($"Your Die number : {Die}");
        }

    }
}
