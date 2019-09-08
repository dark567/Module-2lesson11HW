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
                if (MainList.ReturnMainCount(user.Name) <= 0)
                {
                    //Console.WriteLine($"UberChiterPlayer:{MainList.ReturnMainCount(user.Name)}");
                    break;
                }
                else
                {
                    UberChiterBehavior = i;
                    foreach (HistoryList item in HistoryListLogic.GetHistoryList)
                    {
                        if (item.HistoryRow == UberChiterBehavior) UberChiterBehavior = i++;
                    }
                    if (user.StepFinish == UberChiterBehavior)
                    {
                        //Console.BackgroundColor = ConsoleColor.Red;
                        //Console.ForegroundColor = ConsoleColor.White;
                        //Console.WriteLine($"Lucky{user.Name}[Step:{step}] {UberChiterBehavior} = {Convert.ToInt32(user.StepFinish)}");
                        //Console.ResetColor();
                        MainList.ChangeStepFinishPlayer(user.Name, step);
                        MainList.SetMainCount(); //set MainCount = 0 if somebody win
                        break;
                    }
                    //else Console.WriteLine($"({user.Name}[Step:{step}] {ChiterBehavior} != {Convert.ToInt32(user.StepFinish)}");
                    step++;
                    MainList.ChangeMainCount();
                }
            }
        }
    }
}
