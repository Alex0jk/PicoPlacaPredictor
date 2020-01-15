using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictor.ConfigData
{
    public class PicoPlacaParameters
    {
        //Time intervals for Pico y Placa
        public static readonly TimeSpan MorningTime1 = new TimeSpan(7, 0, 0);
        public static readonly TimeSpan MorningTime2 = new TimeSpan(9, 30, 0);
        public static readonly TimeSpan AfternoonTime1 = new TimeSpan(16, 0, 0);
        public static readonly TimeSpan AfternoonTime2 = new TimeSpan(19, 30, 0);

        //Active days and plates final numbers
        public static readonly Dictionary<int,List<int>> PicoPlacaDays = new Dictionary<int, List<int>>
        {
            {1,new List<int>(){1,2}},
            {2,new List<int>(){3,4}},
            {3,new List<int>(){5,6}},
            {4,new List<int>(){7,8 }},
            {5,new List<int>(){9,0}}
        };

    }
}
