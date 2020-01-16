using Microsoft.VisualStudio.TestTools.UnitTesting;
using PicoPlacaPredictor.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictor.Controller.Tests
{
    [TestClass()]
    public class PicoPlacaControllerPicoPlacaControllerTests
    {
        [TestMethod()]
        public void is_LastPlateDigit_With_PicoPlacaTest_ExpectedDay()
        {
            int lastDigit = 1;
            int day = 1;
            bool expected = true;

            var controller = new PicoPlacaController();
            bool result = controller.isLastPlateDigitWithPicoPlaca(lastDigit, day);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void is_LastPlateDigit_With_PicoPlacaTest_NotExpectedDay()
        {
            int lastDigit = 5;
            int day = 5;
            bool expected = false;

            var controller = new PicoPlacaController();
            bool result = controller.isLastPlateDigitWithPicoPlaca(lastDigit, day);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void is_LastPlateDigit_With_PicoPlacaTest_Weekend()
        {
            int lastDigit = 1;
            int day = 7;
            bool expected = false;

            var controller = new PicoPlacaController();
            bool result = controller.isLastPlateDigitWithPicoPlaca(lastDigit, day);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void is_Time_WithPicoPlacaTest_ExpectedTimeMorning()
        {
            TimeSpan selectedTime = new TimeSpan(8, 0, 0);
            bool expected = true;

            var controller = new PicoPlacaController();
            bool result = controller.isTimeWithPicoPlaca(selectedTime);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void is_Time_WithPicoPlacaTest_ExpectedTimeAfternoon()
        {
            TimeSpan selectedTime = new TimeSpan(17, 0, 0);
            bool expected = true;

            var controller = new PicoPlacaController();
            bool result = controller.isTimeWithPicoPlaca(selectedTime);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void is_Time_WithPicoPlacaTest_NotExpectedTime()
        {
            TimeSpan selectedTime = new TimeSpan(12, 0, 0);
            bool expected = false;

            var controller = new PicoPlacaController();
            bool result = controller.isTimeWithPicoPlaca(selectedTime);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void is_Car_WithPicoPlacaTest_Expected()
        {
            string plate = "PQN492";
            DateTime date = new DateTime(2020, 01, 13);
            TimeSpan time = new TimeSpan(8, 0, 0);

            bool expected = true;

            var controller = new PicoPlacaController();
            bool result = controller.isCarWithPicoPlaca(plate,date,time);
            
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void is_Bike_WithPicoPlacaTest_Expected()
        {
            string plate = "HX131M";
            DateTime date = new DateTime(2020, 01, 13);
            TimeSpan time = new TimeSpan(8, 0, 0);

            bool expected = true;

            var controller = new PicoPlacaController();
            bool result = controller.isCarWithPicoPlaca(plate, date, time);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void is_Car_WithPicoPlacaTest_NotExpected()
        {
            string plate = "PQN2493";
            DateTime date = new DateTime(2020, 01, 13);
            TimeSpan time = new TimeSpan(18, 15, 0);

            bool expected = false;

            var controller = new PicoPlacaController();
            bool result = controller.isCarWithPicoPlaca(plate, date, time);

            Assert.AreEqual(expected, result);
        }
    }
}