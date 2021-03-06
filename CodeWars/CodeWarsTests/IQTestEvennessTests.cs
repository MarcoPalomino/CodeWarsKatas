﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass()]
    public class IQTestEvennessTests
    {
        [TestMethod()]
        public void TestEvenessTest()
        {
            var numbers = "2 4 7 8 10";

            var iqTest = new IQTestEvenness();
            var result = iqTest.TestEveness(numbers);

            Assert.AreEqual(result, 3, "Incorrect");
        }

        [TestMethod()]
        public void TestEvenessOddTest()
        {
            var numbers = "1 2 2";
            
            var iqTest = new IQTestEvenness();
            var result = iqTest.TestEveness(numbers);

            Assert.AreEqual(result, 1, "Incorrect");
        }
    }
}