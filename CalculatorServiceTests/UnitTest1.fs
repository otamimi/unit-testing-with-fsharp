namespace CalculatorService.Tests

open NUnit.Framework
open System
open CalculatorService


[<TestFixture>]
module TestClass  =

    [<TestCase("", ExpectedResult  = 0)>]
    [<TestCase("1", ExpectedResult  = 1)>]
    [<TestCase("100", ExpectedResult  = 100)>]
    [<TestCase("1,2", ExpectedResult  = 3)>]
    [<TestCase("2,3", ExpectedResult  = 5)>]
       let AddTwoNumbers_CommaDelimiter_Returns_Sum inputString =
            Calculate.Add inputString


   
        

