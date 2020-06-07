using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
namespace PromotionEngineUnitTest
{
    [TestClass]
    public class PEUnitTests
    {
        [TestMethod]
        public void TestScenarioA()
        {
            PEComponent objScenarioA = new PEComponent();

            List<string> LstScenarioA = new List<string>();
            LstScenarioA.Add("A");
            LstScenarioA.Add("B");
            LstScenarioA.Add("C");

            double result = objScenarioA.GetTotal(LstScenarioA);
            Assert.AreEqual(100, result);

        }
    }
}
