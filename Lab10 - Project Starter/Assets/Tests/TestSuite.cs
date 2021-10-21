using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        private float result = 0.0f;

        // A Test behaves as an ordinary method
        [Test]
        public void TestAddition()
        {
            // Use the Assert class to test conditions
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        [Test]
        public void TestSubtraction()
        {
            result = Calculator.CalculatePair(10, 7, "-");
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void TestMultiplication()
        {
            result = Calculator.CalculatePair(4, 13, "*");
            Assert.AreEqual(result, 52);
        }

        [Test]
        public void TestDivision()
        {
            result = Calculator.CalculatePair(117, 9, "/");
            Assert.AreEqual(result, 13);
        }

        [Test]
        public void TestPowerOperation()
        {
            result = Calculator.CalculatePair(5, 3, "^");
            Assert.AreEqual(result, 125);
        }

        [Test]
        public void TestRootOperation()
        {
            result = Calculator.CalculatePair(289, 2, "√");
            Assert.AreEqual(result, 17);
        }
    }
}
