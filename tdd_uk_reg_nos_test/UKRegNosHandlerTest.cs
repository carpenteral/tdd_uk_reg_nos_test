using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NCrunch.Framework;

namespace tdd_uk_reg_nos_test
{
    [TestClass]
    public class UKRegNosHandlerTest
    {
        [TestMethod]
        public void next_reg_no_after_march()
        {
            //arrange - setup
            UKRegNosHandler regHandler = new UKRegNosHandler();
            String initValue = "15";
            String expValue = "65";

            // act
            String result = regHandler.nextRegCode(initValue);

            // assert
            Assert.AreEqual(expValue, result);
        }

        [TestMethod]
        public void next_reg_no_after_september()
        {
            //arrange - setup
            UKRegNosHandler regHandler = new UKRegNosHandler();
            String initValue = "65";
            String expValue = "16";

            // act
            String result = regHandler.nextRegCode(initValue);

            // assert
            Assert.AreEqual(expValue, result);
        }

        [TestMethod]
        public void next_reg_no_after_march_in_noughties()
        {
            //arrange - setup
            UKRegNosHandler regHandler = new UKRegNosHandler();
            String initValue = "01";
            String expValue = "51";

            // act
            String result = regHandler.nextRegCode(initValue);

            // assert
            Assert.AreEqual(expValue, result);
        }

        [TestMethod]
        public void next_reg_no_after_september_in_noughties()
        {
            //arrange - setup
            UKRegNosHandler regHandler = new UKRegNosHandler();
            String initValue = "51";
            String expValue = "02";

            // act
            String result = regHandler.nextRegCode(initValue);

            // assert
            Assert.AreEqual(expValue, result);
        }

        [TestMethod]
        [ExpectedException(typeof(BadYearException))]
        public void next_reg_no_after_march_in_2050()
        {
            //arrange - setup
            UKRegNosHandler regHandler = new UKRegNosHandler();
            String initValue = "50";
            String expValue = "00";

            // act
            String result = regHandler.nextRegCode(initValue);

            // assert
            //Assert.AreEqual(expValue, result);
        }
    }
}
