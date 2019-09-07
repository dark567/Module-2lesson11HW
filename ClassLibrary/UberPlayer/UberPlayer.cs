using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UberPlayer
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int StepFinish { get; set; }


        public static List<UberPlayer> _chiterPlayer;

        static UberPlayer()
        {
            _chiterPlayer = new List<UberPlayer>();
        }

        public UberPlayer(string _name, int _stepFinish)
        {
            this.Name = _name;
            this.StepFinish = _stepFinish;
            this.Type = "UberPlayer";
        }
    }
}
