using FibonacciGenerator.Exceptions;
using FibonacciGenerator;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FibonacciGeneratorTests
{
    [TestFixture]
    public class IntegrationTests
    {
        [Test]
        public void GeneratorCannotProduceLessThanEightNumbers()
        {
            var fibonacciGenerator = new Generator();
            var requestedNumber = 7;

            Assert.That(() => fibonacciGenerator.Generate(requestedNumber), Throws.TypeOf<InputTooShortException>());
        }

        [Test]
        public void GeneratorCannotProduceMoreThanFiftyNumbers()
        {
            var fibonacciGenerator = new Generator();
            var requestedNumber = 51;

            Assert.That(() => fibonacciGenerator.Generate(requestedNumber), Throws.TypeOf<InputTooLongException>());
        }

        [Test]
        public void GeneratorProducesTenNumbersWhenTenAreRequested()
        {
            var fibonacciGenerator = new Generator();
            var requestedNumber = 10;
            var expectedOutput = new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            var result = fibonacciGenerator.Generate(requestedNumber);

            Assert.That(expectedOutput, Is.EqualTo(result));
        }
    }
}
