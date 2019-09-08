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
            int UberBehavior, step = 0;
            UberPlayer user = (UberPlayer)obj;

            for (int i = 40; i < 141; i++)
            {
                if (MainList.ReturnMainCount(user.Name) <= 0)
                {
                    //Console.WriteLine($"UberPlayer:{MainList.ReturnMainCount(user.Name)}");
                    break;
                }
                else
                {
                    UberBehavior = i;
                    if (user.StepFinish == UberBehavior)
                    {
                        //Console.BackgroundColor = ConsoleColor.Red;
                        //Console.ForegroundColor = ConsoleColor.White;
                        //Console.WriteLine($"Lucky{user.Name}[Step:{step}] {UberBehavior} = {Convert.ToInt32(user.StepFinish)}");
                        //Console.ResetColor();
                        MainList.ChangeStepFinishPlayer(user.Name, step);
                        MainList.SetMainCount(); //set MainCount = 0 if somebody win
                        break;
                    }
                    else HistoryListLogic.AddHistory(new HistoryList(_historyRow: UberBehavior, _namePlayer: user.Name));
                    //else Console.WriteLine($"({user.Name}[Step:{step}] {ChiterBehavior} != {Convert.ToInt32(user.StepFinish)}");

                    MainList.ChangeMainCount();
                    step++;
                }
            }
        }
    }
}
