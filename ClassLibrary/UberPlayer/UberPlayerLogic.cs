using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UberPlayerLogic
    {
        public static void CalcUberPlayer(object obj)
        {
            Random ran = new Random();
            int UberBehavior, step = 0;
            UberPlayer user = (UberPlayer)obj;

            for (int i = 0; i < 100; i++)
            {
                UberBehavior = ran.Next(40, 140);
                if (user.StepFinish == UberBehavior)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Lucky{user.Name}[Step:{step}] {UberBehavior} = {Convert.ToInt32(user.StepFinish)}");
                    Console.ResetColor();
                    break;
                }
                else HistoryListLogic.AddHistory(new HistoryList(_historyRow: UberBehavior, _namePlayer: user.Name));
                //else Console.WriteLine($"({user.Name}[Step:{step}] {ChiterBehavior} != {Convert.ToInt32(user.StepFinish)}");

                step++;
            }
        }
    }
}
