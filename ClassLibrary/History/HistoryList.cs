using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class HistoryList
    {
        public int HistoryRow { get; set; }
        public string NamePlayer { get; set; }
        public static List<HistoryList> _historyList;
        static HistoryList()
        {
            _historyList =new List<HistoryList>();
        }
        public HistoryList(int _historyRow, string _namePlayer)
        {
            this.HistoryRow = _historyRow;
            this.NamePlayer = _namePlayer;
        }

        
    }
}
