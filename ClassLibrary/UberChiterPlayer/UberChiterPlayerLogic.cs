using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UberChiterPlayerLogic
    {
        public static void CalcUberChiterPlayer(object obj)
        {
          
            int UberChiterBehavior, step = 0;
            UberChiterPlayer user = (UberChiterPlayer)obj;

            for (int i = 40; i < 141; i++)
            {
                UberChiterBehavior = i;
                if (user.StepFinish == UberChiterBehavior)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Lucky{user.Name}[Step:{step}] {UberChiterBehavior} = {Convert.ToInt32(user.StepFinish)}");
                    Console.ResetColor();
                    break;
                }
               //else Console.WriteLine($"({user.Name}[Step:{step}] {ChiterBehavior} != {Convert.ToInt32(user.StepFinish)}");

                step++;
            }
        }
    }
}
