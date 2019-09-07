using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class HistoryListLogic
    {
        public static HistoryList[] GetHistoryList
        {
            get
            {
                return HistoryList._historyList.ToArray();
            }
        }

        public static void AddHistory(HistoryList _modelHistory)
        {
            HistoryList._historyList.Add(_modelHistory);
        }
    }
}
