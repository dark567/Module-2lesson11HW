﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ChiterPlayer
{
    public class ChiterPlayerLogic
    {
        public static void CalcChiterPlayer(object obj)
        {
            Random ran = new Random();
            int ChiterBehavior;
            ChiterPlayer user = (ChiterPlayer)obj;

            for (int i = 0; i < 100; i++)
            {
                ChiterBehavior = ran.Next(40, 140);
                foreach (HistoryList item in HistoryListLogic.GetHistoryList)
                {
                    if (item.HistoryRow == ChiterBehavior) ChiterBehavior = ran.Next(40, 140);
                }
                if (user.StepFinish == ChiterBehavior)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Lucky{user.Name}[Step:{i}] {ChiterBehavior} = {Convert.ToInt32(user.StepFinish)}");
                    Console.ResetColor();
                    break;
                }
                else HistoryListLogic.AddHistory(new HistoryList(_historyRow: ChiterBehavior, _namePlayer: user.Name));
            }
            
        }

        // else Console.WriteLine($"({user.Name}[Step:{i}] {SimbleBehavior} != {Convert.ToInt32(user.StepFinish)}");
    }
}
      