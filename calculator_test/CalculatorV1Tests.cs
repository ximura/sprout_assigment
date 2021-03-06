﻿using calculator;
using NSubstitute;
using NUnit.Framework;
using System;

namespace calculator_test
{
    public class CalculatorV1Tests
    {
        [SetUp]
        public void Setup()
        {
            calculator = new CalculatorV1();
        }

        [Test]
        [TestCase(false, false, false, CalculatorResult.Error)]
        [TestCase(false, false, true, CalculatorResult.Error)]
        [TestCase(false, true, false, CalculatorResult.Error)]
        [TestCase(false, true, true, CalculatorResult.T)]
        [TestCase(true, false, false, CalculatorResult.Error)]
        [TestCase(true, false, true, CalculatorResult.Error)]
        [TestCase(true, true, false, CalculatorResult.M)]
        [TestCase(true, true, true, CalculatorResult.P)]
        public void Get_H(bool a, bool b, bool c, CalculatorResult result)
        {
            Assert.AreEqual(calculator.Get_H(a, b, c), result);
        }

        [Test]
        [TestCase(CalculatorResult.M, 10, 10, 10, 20)]
        [TestCase(CalculatorResult.P, 10, 10, 10, 21)]
        [TestCase(CalculatorResult.P, 25, 100, 0, 75)]
        [TestCase(CalculatorResult.T, 10, 10, 3, 9.0f)]
        public void Get_K(CalculatorResult h, float d, int e, int f, float result)
        {
            Assert.AreEqual(calculator.Get_K(h, d, e, f), result);
        }

        [Test]
        public void Get_K_should_throw()
        {
            Assert.Throws<ArgumentException>(() =>
                calculator.Get_K(CalculatorResult.Error, Arg.Any<float>(), Arg.Any<int>(), Arg.Any<int>()));
        }

        private ICalculator calculator;
    }
}