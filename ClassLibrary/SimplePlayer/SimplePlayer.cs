using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SimplePlayer
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int StepFinish { get; set; }

        public static List<SimplePlayer> _simplePlayer;

        static SimplePlayer()
        {
            _simplePlayer = new List<SimplePlayer>();
        }

        public SimplePlayer(string _name, int _stepFinish)
        {
            this.Name = _name;
            this.StepFinish = _stepFinish;
            this.Type = "SimplePlayer";
        }
    }
}
