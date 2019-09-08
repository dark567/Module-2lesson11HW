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

        static void Main(string[] args)
        {
            Random ran = new Random();
            MainSize = ran.Next(40, 140);
            Console.WriteLine($"MainSize: {MainSize}");

            //add players diffrent names and types
            SimplePlayerMethod("Petr", "SimplePlayer", MainSize);
            NotepadPlayerMethod("Ivan", "NotepadPlayer", MainSize);
            UberPlayerPlayerMethod("Den", "UberPlayer", MainSize);
            ChiterPlayerMethod("Clirk", "ChiterPlayer", MainSize);
            UberChiterPlayerMethod("Miki", "UberChiterPlayer", MainSize);

            Thread.Sleep(1000);

            SHowWhoWin(); // show orderBy List

            Console.ReadLine();
        }

        /// <summary>
        /// UberChiter void 
        /// </summary>
        /// <param name="_name">Name</param>
        /// <param name="_typePlayer">Type player</param>
        /// <param name="_stepFinishPlayer">MainSize and FinishStep</param>
        private static void UberChiterPlayerMethod(string _name, string _typePlayer, int _stepFinishPlayer)
        {
            Thread uberchiterPlayerThread = new Thread(new ParameterizedThreadStart(UberChiterPlayerLogic.CalcUberChiterPlayer));
            UberChiterPlayer uberchiterPlayer = new UberChiterPlayer(_name: _name, _stepFinish: MainSize);
            MainList.AddMainList(new MainList(_countPlayers: 1, _namePlayer: _name, _typePlayer: _typePlayer, _stepFinishPlayer: MainSize));
            uberchiterPlayerThread.Start(uberchiterPlayer);
        }
        /// <summary>
        /// Chiter void
        /// </summary>
        /// <param name="_name">Name</param>
        /// <param name="_typePlayer">Type player</param>
        /// <param name="_stepFinishPlayer">MainSize and FinishStep</param>
        private static void ChiterPlayerMethod(string _name, string _typePlayer, int _stepFinishPlayer)
        {
            Thread chiterPlayerThread = new Thread(new ParameterizedThreadStart(ChiterPlayerLogic.CalcChiterPlayer));
            ChiterPlayer chiterPlayer = new ChiterPlayer(_name: _name, _stepFinish: MainSize);
            MainList.AddMainList(new MainList(_countPlayers: 1, _namePlayer: _name, _typePlayer: _typePlayer, _stepFinishPlayer: MainSize));
            chiterPlayerThread.Start(chiterPlayer);
        }
        /// <summary>
        /// Uber void
        /// </summary>
        /// <param name="_name">Name</param>
        /// <param name="_typePlayer">Type player</param>
        /// <param name="_stepFinishPlayer">MainSize and FinishStep</param>
        private static void UberPlayerPlayerMethod(string _name, string _typePlayer, int _stepFinishPlayer)
        {
            Thread uberPlayerThread = new Thread(new ParameterizedThreadStart(UberPlayerLogic.CalcUberPlayer));
            UberPlayer uberpl1 = new UberPlayer(_name: "Den", _stepFinish: MainSize);
            MainList.AddMainList(new MainList(_countPlayers: 1, _namePlayer: "Den", _typePlayer: "UberPlayer", _stepFinishPlayer: 100));
            uberPlayerThread.Start(uberpl1);
        }
        /// <summary>
        /// Notepad void
        /// </summary>
        /// <param name="_name">Name</param>
        /// <param name="_typePlayer">Type player</param>
        /// <param name="_stepFinishPlayer">MainSize and FinishStep</param>
        private static void NotepadPlayerMethod(string _name, string _typePlayer, int _stepFinishPlayer)
        {
            Thread notepadPlayerThread = new Thread(new ParameterizedThreadStart(NotepadPlayerLogic.CalcNotepadPlayer));
            NotepadPlayer notepadpl1 = new NotepadPlayer(_name: _name, _stepFinish: _stepFinishPlayer);
            MainList.AddMainList(new MainList(_countPlayers: 1, _namePlayer: _name, _typePlayer: _typePlayer, _stepFinishPlayer: _stepFinishPlayer));
            notepadPlayerThread.Start(notepadpl1);
        }
        /// <summary>
        /// Simple void
        /// </summary>
        /// <param name="_name">Name</param>
        /// <param name="_typePlayer">Type player</param>
        /// <param name="_stepFinishPlayer">MainSize and FinishStep</param>
        private static void SimplePlayerMethod(string _name, string _typePlayer, int _stepFinishPlayer )
        {
            Thread simplePlayerThread = new Thread(new ParameterizedThreadStart(SimplePlayerLogic.CalcSimplePlayer));
            SimplePlayer simplepl1 = new SimplePlayer(_name: _name, _stepFinish: _stepFinishPlayer);
            MainList.AddMainList(new MainList(_countPlayers: 1, _namePlayer: _name, _typePlayer: _typePlayer, _stepFinishPlayer: _stepFinishPlayer));
            simplePlayerThread.Start(simplepl1);
        }

        /// <summary>
        /// Show Who Win
        /// </summary>
        private static void SHowWhoWin()
        {
            int _psevdoIndex = 0;
            Console.WriteLine(new string('-', 35) + "Rezult" + new string('-', 35));

            foreach (MainList item in MainList.GetMainList.OrderBy(i => i.StepFinishPlayer))
            {
                if(_psevdoIndex == 0) Console.BackgroundColor = ConsoleColor.White;
                else Console.ResetColor();
                Console.WriteLine($"{_psevdoIndex}:{item.NamePlayer}:{item.TypePlayer}:{item.StepFinishPlayer}");
                _psevdoIndex++;
            }
        }

    }
}
