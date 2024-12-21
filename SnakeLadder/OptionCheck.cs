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
                int position= random.Next(1,100);
                Console.WriteLine($"You got {Die} : No Play . You will stay in {position}");
            }
            else if(Die == 2 || Die == 3)
            {
                int position = random.Next(1, 100);
                Console.WriteLine($"Wow!! you got {Die} : ladder . You will jump to {position+Die}");
            }
            else
            {
                int position = random.Next(1, 100);
                Console.WriteLine($" Bad Luck !!! you got {Die} : Snake . You will go back to {position-Die}");
            }
        }

    }
}
