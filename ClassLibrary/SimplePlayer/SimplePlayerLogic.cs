using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SimplePlayerLogic
    {
        public static void CalcSimplePlayer(object obj)
        {
            Random ran = new Random();
            int SimbleBehavior;
            SimplePlayer user = (SimplePlayer)obj;

            for (int i = 0; i < 100; i++)
            {
                SimbleBehavior = ran.Next(40, 140);
                if (user.StepFinish == SimbleBehavior)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Lucky{user.Name}[Step:{i}] {SimbleBehavior} = {Convert.ToInt32(user.StepFinish)}");
                    Console.ResetColor();
                    break;
                }
                else HistoryListLogic.AddHistory(new HistoryList(_historyRow: SimbleBehavior, _namePlayer: user.Name));

                
                // else Console.WriteLine($"({user.Name}[Step:{i}] {SimbleBehavior} != {Convert.ToInt32(user.StepFinish)}");
            }
        }

      
    }
}
