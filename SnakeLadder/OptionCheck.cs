using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    internal class OptionCheck
    {

        public static void Check()
        {
            
            Random random = new Random();
            int Die = random.Next(1, 6);
            if (Die == 6 || Die == 4)
            {
                Console.WriteLine($"You got {Die} : No Play");
            }
            else if(Die == 1 || Die == 3)
            {
                Console.WriteLine($"Wow!! you got {Die} : ladder");
            }
            else
            {
                Console.WriteLine($" Bad Luck !!! you got {Die} : Snake");
            }
        }

    }
}
