﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz.Library.Test
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        //[Test]
        //public void Buzzer_When1_Returns1()
        //{
        //    // Arrange
        //    int input = 1;

        //    // Act
        //    string output = FizzBuzzer.GetValue(input);

        //    // Assert
        //    Assert.AreEqual("1", output);
        //}

        //[Test]
        //public void Buzzer_WhenDefault_ReturnsInput(
        //    [Values(1,2,4,7,8,11,13,14,16,17,19)] int input)
        //{
        //    string output = FizzBuzzer.GetValue(input);
        //    Assert.AreEqual(input.ToString(), output);
        //}

        //[Test]
        //public void Buzzer_When3_ReturnsFizz(
        //    [Values(3, 6, 9, 12, 18, 21)] int input)
        //{
        //    string output = FizzBuzzer.GetValue(input);
        //    Assert.AreEqual("Fizz", output);
        //}

        //[Test]
        //public void Buzzer_When5_ReturnsBuzz(
        //    [Values(5, 10, 20)] int input)
        //{
        //    string output = FizzBuzzer.GetValue(input);
        //    Assert.AreEqual("Buzz", output);
        //}

        //[Test]
        //public void Buzzer_WhenDiv3AndDiv5_ReturnsFizzBuzz(
        //    [Values(15)] int input)
        //{
        //    string output = FizzBuzzer.GetValue(input);
        //    Assert.AreEqual("FizzBuzz", output);
        //}

        [Test]
        public void GetValue_PassValidInput_ReturnCorrectString()
        {
            //Arrange
            var expectedresult = "Fizz";
            var input = 0;
            //Act
            var actualresult = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }
    }
}
