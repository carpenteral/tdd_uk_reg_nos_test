using System;
using System.Collections;
using NUnit.Framework;

namespace tdd_uk_reg_nos_test
{
    public class MyDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("15").Returns("65");
                yield return new TestCaseData("16").Returns("66");
                yield return new TestCaseData("17").Returns("67");
            }
        }
    }

    [TestFixture]
    public class NUnitCarRegTests
    {
        [TestCase("15", "65")]
        [TestCase("16", "66")]
        [TestCase("17", "67")]
        public void next_reg_no_after_march(string init, string exp)
        {
            //arrange - setup
            UKRegNosHandler regHandler = new UKRegNosHandler();
            String initValue = init;
            String expValue = exp;

            // act
            String result = regHandler.nextRegCode(initValue);

            // assert
            Assert.AreEqual(expValue, result);
        }

        [Test, TestCaseSource(typeof(MyDataClass), "TestCases")]
        public string next_reg_no_after_september_with_table(string init)
        {
            //arrange - setup
            UKRegNosHandler regHandler = new UKRegNosHandler();
            String initValue = init;
            //String expValue = exp;

            // act
            String result = regHandler.nextRegCode(initValue);

            // assert
            return result;
        }

    }
}
