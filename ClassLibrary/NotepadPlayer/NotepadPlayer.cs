using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NotepadPlayer
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int StepFinish { get; set; }

        public static List<NotepadPlayer> _notepadPlayer;

        static NotepadPlayer()
        {
            _notepadPlayer = new List<NotepadPlayer>();
        }

        public NotepadPlayer(string _name, int _stepFinish)
        {
            this.Name = _name;
            this.StepFinish = _stepFinish;
            this.Type = "NotepadPlayer";
        }
    }
}
