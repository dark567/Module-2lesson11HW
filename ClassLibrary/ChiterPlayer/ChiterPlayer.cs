using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ChiterPlayer
{
    public class ChiterPlayer
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int StepFinish { get; set; }

        public static List<ChiterPlayer> _chiterPlayer;

        static ChiterPlayer()
        {
            _chiterPlayer = new List<ChiterPlayer>();
        }

        public ChiterPlayer(string _name, int _stepFinish)
        {
            this.Name = _name;
            this.StepFinish = _stepFinish;
            this.Type = "ChiterPlayer";
        }
    }
}
