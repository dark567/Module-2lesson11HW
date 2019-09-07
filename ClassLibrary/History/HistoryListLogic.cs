using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class HistoryListLogic
    {
        /// <summary>
        /// 
        /// </summary>
        public static HistoryList[] GetHistoryList
        {
            get
            {
                return HistoryList._historyList.ToArray();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_modelHistory"></param>
        public static void AddHistory(HistoryList _modelHistory)
        {
            HistoryList._historyList.Add(_modelHistory);
        }
    }
}
