using System;
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
                if (MainList.ReturnMainCount(user.Name) <= 0)
                {
                    //Console.WriteLine($"NotepadPlayer:{MainList.ReturnMainCount(user.Name)}");
                    break;
                }
                else
                {
                    NotepadBehavior = ran.Next(40, 140);

                    foreach (var item in SaveIntList)
                    {
                        if (item == NotepadBehavior)
                        {

                            while (item == NotepadBehavior)
                            {
                                NotepadBehavior = ran.Next(40, 140);
                            }
                        }
                    }
                    if (user.StepFinish == NotepadBehavior)
                    {
                        //Console.BackgroundColor = ConsoleColor.Red;
                        //Console.ForegroundColor = ConsoleColor.White;
                        //Console.WriteLine($"Lucky{user.Name}[Step:{i}] {NotepadBehavior} = {Convert.ToInt32(user.StepFinish)}");
                        //Console.ResetColor();
                        MainList.ChangeStepFinishPlayer(user.Name, i);
                        break;
                    }
                    else HistoryListLogic.AddHistory(new HistoryList(_historyRow: NotepadBehavior, _namePlayer: user.Name));
                    // else Console.WriteLine($"({user.Name}[Step:{i}] {NotepadBehavior} != {Convert.ToInt32(user.StepFinish)}");

                    MainList.ChangeMainCount();
                    SaveIntList.Add(NotepadBehavior);
                }
            }
        }
    }
}
