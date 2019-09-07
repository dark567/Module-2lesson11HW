using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{

    class Program
    {
        public static int MainSize, SimplePlayerStep, NotepadPlayerStep;
        
        static void Main(string[] args)
        {
            Random ran = new Random();
            MainSize = ran.Next(40, 140);

            //Thread simplePlayerThread = new Thread(new ParameterizedThreadStart(SimplePlayerLogic.CalcSimplePlayer));
            //SimplePlayer simplepl1 = new SimplePlayer(_name: "Petr", _stepFinish: MainSize);
            //simplePlayerThread.Start(simplepl1);

            Thread notepadPlayerThread = new Thread(new ParameterizedThreadStart(NotepadPlayerLogic.CalcNotepadPlayer));
            NotepadPlayer notepadpl1 = new NotepadPlayer(_name: "Ivan", _stepFinish: MainSize);
            notepadPlayerThread.Start(notepadpl1);

            Console.WriteLine($"{MainSize}");
            Console.ReadLine();
        }

       
    }
}
