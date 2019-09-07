using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary.ChiterPlayer;

namespace ConsoleApp
{

    class Program
    {
        public static int MainSize;

        public static List<int> HistoryList = new List<int>();

        static void Main(string[] args)
        {
            Random ran = new Random();
            MainSize = ran.Next(40, 140);
            Console.WriteLine($"{MainSize}");

            Thread simplePlayerThread = new Thread(new ParameterizedThreadStart(SimplePlayerLogic.CalcSimplePlayer));
            SimplePlayer simplepl1 = new SimplePlayer(_name: "PetrSimple", _stepFinish: MainSize);
            MainList.AddMainList(new MainList(_countPlayers: 1, _namePlayer: "PetrSimple", _typePlayer: "SimplePlayer", _stepFinishPlayer: 100));
            simplePlayerThread.Start(simplepl1);

            Thread notepadPlayerThread = new Thread(new ParameterizedThreadStart(NotepadPlayerLogic.CalcNotepadPlayer));
            NotepadPlayer notepadpl1 = new NotepadPlayer(_name: "IvanNotepad", _stepFinish: MainSize);
            MainList.AddMainList(new MainList(_countPlayers: 1, _namePlayer: "IvanNotepad", _typePlayer: "NotepadPlayer", _stepFinishPlayer: 100));
            notepadPlayerThread.Start(notepadpl1);

            Thread uberPlayerThread = new Thread(new ParameterizedThreadStart(UberPlayerLogic.CalcUberPlayer));
            UberPlayer uberpl1 = new UberPlayer(_name: "DenUber", _stepFinish: MainSize);
            MainList.AddMainList(new MainList(_countPlayers: 1, _namePlayer: "DenUber", _typePlayer: "UberPlayer", _stepFinishPlayer: 100));
            uberPlayerThread.Start(uberpl1);

            Thread chiterPlayerThread = new Thread(new ParameterizedThreadStart(ChiterPlayerLogic.CalcChiterPlayer));
            ChiterPlayer chiterPlayer = new ChiterPlayer(_name: "ClirkChiter", _stepFinish: MainSize);
            MainList.AddMainList(new MainList(_countPlayers: 1, _namePlayer: "ClirkChiter", _typePlayer: "ChiterPlayer", _stepFinishPlayer: 100));
            chiterPlayerThread.Start(chiterPlayer);

            Thread uberchiterPlayerThread = new Thread(new ParameterizedThreadStart(UberChiterPlayerLogic.CalcUberChiterPlayer));
            UberChiterPlayer uberchiterPlayer = new UberChiterPlayer(_name: "MikiChiterUber", _stepFinish: MainSize);
            MainList.AddMainList(new MainList(_countPlayers: 1, _namePlayer: "MikiChiterUber", _typePlayer: "UberChiterPlayer", _stepFinishPlayer: 100));
            uberchiterPlayerThread.Start(uberchiterPlayer);




            Thread.Sleep(1000);
            
            SHowWhoWin(); // show orderBy List

            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        private static void SHowWhoWin()
        {
            Console.WriteLine(new string('-', 75));

            foreach (MainList item in MainList.GetMainList.OrderBy(i => i.StepFinishPlayer))
            {
                Console.WriteLine($"{item.NamePlayer}:{item.TypePlayer}:{item.StepFinishPlayer}:{item.MainCount}");
            }
        }

    }
}
