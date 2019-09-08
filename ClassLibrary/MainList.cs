using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum MyEnum
    {
        Simple,
        Notepad,
        Uber,
        Chiter,
        UberChiter
    }
    public class MainList
    {
        public int MainCount { get; set; }
        public int CountPlayers { get; set; }
        public string NamePlayer { get; set; }
        public string TypePlayer { get; set; }
        public int StepFinishPlayer { get; set; }

        public static List<MainList> _mainList;

        static MainList()
        {
            _mainList = new List<MainList>();
        }

        public MainList(int _countPlayers, string _namePlayer, string _typePlayer, int _stepFinishPlayer, int _mainCount = 100)
        {
            this.CountPlayers = _countPlayers;
            this.NamePlayer = _namePlayer;
            this.TypePlayer = _typePlayer;
            this.StepFinishPlayer = _stepFinishPlayer;
            this.MainCount = _mainCount;
        }
        /// <summary>
        /// 
        /// </summary>
        public static MainList[] GetMainList
        {
            get
            {
                return MainList._mainList.ToArray();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_mainList"></param>
        public static void AddMainList(MainList _mainList)
        {
            MainList._mainList.Add(_mainList);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_StepFinishPlayer"></param>
        public static void ChangeStepFinishPlayer(string _name, int _StepFinishPlayer)
        {
            int index = MainList._mainList.FindIndex(employee => employee.NamePlayer.Equals(_name, StringComparison.Ordinal));
            MainList._mainList[index].StepFinishPlayer = _StepFinishPlayer;
        }
        /// <summary>
        /// Return new MainCount
        /// </summary>
        /// <param name="_name"></param>
        /// <returns></returns>
        public static int ReturnMainCount(string _name)
        {
            int index = MainList._mainList.FindIndex(name => name.NamePlayer.Equals(_name, StringComparison.Ordinal));
            return MainList._mainList[index].MainCount;
        }

        /// <summary>
        /// decrement
        /// </summary>
        public static void ChangeMainCount()
        {
            for (int i = 0; i < MainList._mainList.Count; i++)
            {
                MainList._mainList[i].MainCount--;
            }
        }

    }
}
