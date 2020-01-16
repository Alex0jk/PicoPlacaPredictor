using Microsoft.VisualStudio.TestTools.UnitTesting;
using PicoPlacaPredictor.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictor.Util.Tests
{
    [TestClass()]
    public class InputValidatorValidationTest
    {
        [TestMethod()]
        public void plateCar_ValidationTest_Expected()
        {
            string plateInput = "PQN0492";
            string expected = "PQN0492";
            string result;
            InputValidator val = new InputValidator();
            try
            {
                result = val.plateValidator(plateInput);
                Assert.AreEqual(expected, result);
            }
            catch
            {
                Assert.Fail();
            }
            
            
        }
        [TestMethod()]
        public void plateBike_ValidationTest_Expected()
        {
            string plateInput = "HX133M";
            string expected = "HX133M";
            string result;
            InputValidator val = new InputValidator();
            try
            {
                result = val.plateValidator(plateInput);
                Assert.AreEqual(expected, result);
            }
            catch
            {
                Assert.Fail();
            }


        }
        [TestMethod()]
        public void plate_ValidationTest_NotExpected()
        {
            string plateInput = "PQ1N0492";
            string expected = "Plate doesnt match with the specified format (PPP#### or PPP###)";
            string result;
            InputValidator val = new InputValidator();
            try
            {
                result = val.plateValidator(plateInput);
                Assert.Fail();
            }
            catch (FormatException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        
        [TestMethod()]
        public void date_ValidationTest_Expected()
        {
            string dateInput = "2020-02-29";
            DateTime expected = new DateTime(2020,2,29);
            DateTime result;
            InputValidator val = new InputValidator();
            try
            {
                result = val.dateValidator(dateInput);
                Assert.AreEqual(expected, result);
            }
            catch
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void date_ValidationTest_NotExpected()
        {
            string dateInput = "2020/02-29";
            string expected = "Date doesnt match with the specified format (yyyy-mm-dd)";
            DateTime result;
            InputValidator val = new InputValidator();
            try
            {
                result = val.dateValidator(dateInput);
                Assert.Fail();
            }
            catch (FormatException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod()]
        public void time_ValidationTest_Expected()
        {
            string timeInput = "07:29";
            TimeSpan expected = new TimeSpan(7,29,0);
            TimeSpan result;
            InputValidator val = new InputValidator();
            try
            {
                result = val.timeValidator(timeInput);
                Assert.AreEqual(expected, result);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void time_ValidationTest_NotExpected()
        {
            string timeInput = "07:29:0";
            string expected = "Time doesnt match with the specified format (hh:mm)";
            TimeSpan result;
            InputValidator val = new InputValidator();
            try
            {
                result = val.timeValidator(timeInput);
                Assert.Fail();
            }
            catch (FormatException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}