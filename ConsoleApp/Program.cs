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
        public static int MainSize, SimplePlayerStep, NotepadPlayerStep;

        public static List<int> HistoryList = new List<int>();


        static void Main(string[] args)
        {
            Random ran = new Random();
            MainSize = ran.Next(40, 140);
            Console.WriteLine($"{MainSize}");

            Thread simplePlayerThread = new Thread(new ParameterizedThreadStart(SimplePlayerLogic.CalcSimplePlayer));
            SimplePlayer simplepl1 = new SimplePlayer(_name: "PetrSimple", _stepFinish: MainSize);
            simplePlayerThread.Start(simplepl1);

            Thread notepadPlayerThread = new Thread(new ParameterizedThreadStart(NotepadPlayerLogic.CalcNotepadPlayer));
            NotepadPlayer notepadpl1 = new NotepadPlayer(_name: "IvanNotepad", _stepFinish: MainSize);
            notepadPlayerThread.Start(notepadpl1);

            Thread uberPlayerThread = new Thread(new ParameterizedThreadStart(UberPlayerLogic.CalcUberPlayer));
            UberPlayer uberpl1 = new UberPlayer(_name: "DenUber", _stepFinish: MainSize);
            uberPlayerThread.Start(uberpl1);

            Thread chiterPlayerThread = new Thread(new ParameterizedThreadStart(ChiterPlayerLogic.CalcChiterPlayer));
            ChiterPlayer chiterPlayer = new ChiterPlayer(_name: "ClirkChiter", _stepFinish: MainSize);
            chiterPlayerThread.Start(chiterPlayer);

            Thread uberchiterPlayerThread = new Thread(new ParameterizedThreadStart(UberChiterPlayerLogic.CalcUberChiterPlayer));
            UberChiterPlayer uberchiterPlayer = new UberChiterPlayer(_name: "MikiChiterUber", _stepFinish: MainSize);
            uberchiterPlayerThread.Start(uberchiterPlayer);


            //foreach (HistoryList item in HistoryListLogic.GetHistoryList)
            //{
            //    Console.WriteLine($"{item.NamePlayer}:{item.HistoryRow}");
            //}

            Console.ReadLine();
        }

       
    }
}
