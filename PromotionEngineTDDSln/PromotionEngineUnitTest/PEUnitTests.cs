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

        [TestMethod]
        public void TestScenarioB()
        {
            PEComponent objScenarioB = new PEComponent();

            List<string> LstScenarioB = new List<string>();
            // 5As, 5Bs and 1C
            LstScenarioB.Add("A");
            LstScenarioB.Add("A");
            LstScenarioB.Add("A");
            LstScenarioB.Add("A");
            LstScenarioB.Add("A");

            LstScenarioB.Add("B");
            LstScenarioB.Add("B");
            LstScenarioB.Add("B");
            LstScenarioB.Add("B");
            LstScenarioB.Add("B");

            LstScenarioB.Add("C");

            double result = objScenarioB.GetTotal(LstScenarioB);
            Assert.AreEqual(370, result);

        }

        [TestMethod]
        public void TestScenarioC()
        {
            PEComponent objScenarioC = new PEComponent();

            List<string> LstScenarioC = new List<string>();
            // 3As, 5Bs, 1C and 1D
            LstScenarioC.Add("A");
            LstScenarioC.Add("A");
            LstScenarioC.Add("A");

            LstScenarioC.Add("B");
            LstScenarioC.Add("B");
            LstScenarioC.Add("B");
            LstScenarioC.Add("B");
            LstScenarioC.Add("B");

            LstScenarioC.Add("C");

            LstScenarioC.Add("D");

            double result = objScenarioC.GetTotal(LstScenarioC);
            Assert.AreEqual(280, result);

        }
    }
}
