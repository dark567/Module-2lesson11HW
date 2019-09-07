using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    public enum Players
    {
        SimplePlayer,
        NotepadPlayer
    }
    class Program
    {
        public static int MainSize, SimplePlayerStep, NotepadPlayerStep;
        
        static void Main(string[] args)
        {
            Random ran = new Random();
            MainSize = ran.Next(40, 140);
            string typePlayer;
            //int[] Size = new 

            Thread simplePlayer = new Thread(new ParameterizedThreadStart(SimplePlayerLogic.CalcSimplePlayer));
            simplePlayer.Start(MainSize);

            Thread notepadPlayer = new Thread(new ParameterizedThreadStart(SimplePlayerLogic.CalcNotepadPlayer));
            simplePlayer.Start(MainSize);

            Console.WriteLine($"{MainSize}");
            Console.ReadLine();
        }

       
    }
}
