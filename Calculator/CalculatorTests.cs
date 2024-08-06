using System;
using Xunit;
using Domain;
using FluentAssertions;

namespace CalculatorTest
{
    public class CalculatorTests
    {
        // My Sum function works like this: if I add 2 and 2 the result should be 4
        [Fact]
        //public void Sum_of_2_and_2_should_be_4()
        //{
        //    var calculator = new Calculator();
        //    var result = calculator.Sum(2, 2);

        //    //using if statement makes our code messy. in order to get rid of it, we have to install
        //    // Fluent Assertions via Nuget and we simply write the Following statement:
        //    result.Should().Be(2); // we could also write either way (method)


        //    //if (result != 4)
        //    //{
        //    //    throw new Exception($"The Sum(2,2) was expected to be 4 but it's {result}");
        //    //}

        //}

         public void Sum_of_2_and_2_should_be_4() => new Calculator().Sum(2, 2).Should().Be(4);

    }
}