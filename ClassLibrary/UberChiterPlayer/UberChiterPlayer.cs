using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UberChiterPlayer
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int StepFinish { get; set; }


        public static List<UberChiterPlayer> _chiterUberPlayer;

        static UberChiterPlayer()
        {
            _chiterUberPlayer = new List<UberChiterPlayer>();
        }

        public UberChiterPlayer(string _name, int _stepFinish)
        {
            this.Name = _name;
            this.StepFinish = _stepFinish;
            this.Type = "UberChiterPlayer";
        }
    }
}
