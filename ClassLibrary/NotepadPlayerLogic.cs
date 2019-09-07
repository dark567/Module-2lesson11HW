﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NotepadPlayerLogic
    {
        public static void CalcNotepadPlayer(object obj)
        {
            Random ran = new Random();
            int NotepadBehavior;
            NotepadPlayer user = (NotepadPlayer)obj;

            List<int> SaveIntList = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                NotepadBehavior = ran.Next(40, 140);

                foreach (var item in SaveIntList)
                {
                    if (item == NotepadBehavior) i--;
                    else if (user.StepFinish == NotepadBehavior)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Lucky{user.Name}[Step:{i}] {NotepadBehavior} = {Convert.ToInt32(user.StepFinish)}");
                        Console.ResetColor();
                        break;
                    }
                    //else Console.WriteLine($"({user.Name}[Step:{i}] {NotepadBehavior} != {Convert.ToInt32(user.StepFinish)}");
                }

                SaveIntList.Add(NotepadBehavior);
            }
        }
    }
}