using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PicoPlacaPredictor.Controller;
using PicoPlacaPredictor.Util;

namespace PicoPlacaPredictor
{
    class Program
    {
        static void Main()
        {
            //Input
            string plateInput;
            string dateInput;
            string timeInput;
            //Data
            string plateNumber;
            DateTime date;
            TimeSpan time;

            bool result;
            PicoPlacaController controller = new PicoPlacaController();
            InputValidator validator = new InputValidator();

            //Input
            Console.WriteLine("Input your full plate number (PPP### or PPP#### or PP###P): ");
            plateInput = Console.ReadLine();
            Console.WriteLine("Input the date you want to check out (yyyy-mm-dd): ");
            dateInput = Console.ReadLine();
            Console.WriteLine("Input the time you want to check out (hh:mm): ");
            timeInput = Console.ReadLine();

            //Input Validation
            try
            {
                plateNumber = validator.plateValidator(plateInput);
                date = validator.dateValidator(dateInput);
                time = validator.timeValidator(timeInput);

                //PicoPlaca Prediction
                result = controller.isCarWithPicoPlaca(plateNumber, date, time);
                //Output
                if (result)
                {
                    Console.WriteLine("You have Pico Y Placa, it is better to not drive during this time");
                }
                else
                {
                    Console.WriteLine("You don't have Pico Y Placa, you can drive without problems");
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input is invalid, use the correct format for each value");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
