using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PicoPlacaPredictor.ConfigData;

namespace PicoPlacaPredictor.Controller
{
    public class PicoPlacaController
    {
        public bool isLastPlateDigitWithPicoPlaca(int plateLastDigit,int day)
        {
            if (PicoPlacaParameters.PicoPlacaDays.ContainsKey(day))
            {
                if (PicoPlacaParameters.PicoPlacaDays[day].Contains(plateLastDigit)){
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool isTimeWithPicoPlaca(TimeSpan selectedTime)
        {
            TimeSpan mtime1 = PicoPlacaParameters.MorningTime1;
            TimeSpan mtime2 = PicoPlacaParameters.MorningTime2;
            TimeSpan atime1 = PicoPlacaParameters.AfternoonTime1;
            TimeSpan atime2 = PicoPlacaParameters.AfternoonTime2;
            if ((selectedTime > mtime1) && (selectedTime < mtime2) || (selectedTime > atime1) && (selectedTime < atime2))
            {
                return true;
            }
            return false;
        }
        public bool isCarWithPicoPlaca(string plate,DateTime date,TimeSpan time)
        {
            int lastDigit = plate.Last() - 48;
            if(lastDigit > 9 || lastDigit < 0)
            {
                lastDigit = plate[plate.Length - 2] - 48;
            }
            int day = (int) date.DayOfWeek;
            if (isLastPlateDigitWithPicoPlaca(lastDigit,day) && isTimeWithPicoPlaca(time))
            {
                return true;
            }
            return false;
        }


    }
}
