using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SimplePlayerLogic
    {
        public static void CalcSimplePlayer(object obj)
        {
            Random ran = new Random();
            int SimbleBehavior;

            for (int i = 0; i < 100; i++)
            {
                SimbleBehavior = ran.Next(40, 140);
                if (Convert.ToInt32(obj) == SimbleBehavior)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Lucky[Step:{i}] {SimbleBehavior} = {Convert.ToInt32(obj)}");
                    Console.ResetColor();
                    break;
                }
                else Console.WriteLine($"( {SimbleBehavior} != {Convert.ToInt32(obj)}");
            }
        }

        public static void CalcNotepadPlayer(object obj)
        {
            Random ran = new Random();
            int SimbleBehavior;

            for (int i = 0; i < 100; i++)
            {
                SimbleBehavior = ran.Next(40, 140);
                if (Convert.ToInt32(obj) == SimbleBehavior)
                {
                    SimplePlayerStep = 
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Lucky[Step:{i}] {SimbleBehavior} = {Convert.ToInt32(obj)}");
                    Console.ResetColor();
                    break;
                }
                else Console.WriteLine($"( {SimbleBehavior} != {Convert.ToInt32(obj)}");
            }
        }
    }
}
