using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PicoPlacaPredictor.Util
{
    public class InputValidator
    {
        public string plateValidator(string plate)
        {
            string regex = @"^[A-Z]{3}[0-9]{3,4}$";
            Match match = Regex.Match(plate, regex);
            if (match.Success)
                return plate;
            else
                throw new FormatException("Plate doesnt match with the specified format (PPP#### or PPP###)");
        }
        public DateTime dateValidator(string date)
        {
            string regex = @"^([12]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01]))$";
            Match match = Regex.Match(date, regex);
            if (match.Success)
                return Convert.ToDateTime(date);
            else
                throw new FormatException("Date doesnt match with the specified format (yyyy-mm-dd)");
            
        }
        public TimeSpan timeValidator(string time)
        {
            string regex = @"^([0-9]{2}:[0-9]{2})$";
            Match match = Regex.Match(time, regex);
            if (match.Success)
                return Convert.ToDateTime(time).TimeOfDay;
            else
                throw new FormatException("Time doesnt match with the specified format (hh:mm)");
        }
    }
}
