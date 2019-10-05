namespace CalculatorService.Tests

open NUnit.Framework
open System
open CalculatorService


[<TestFixture>]
module TestClass  =

    [<TestCase("", ExpectedResult  = 0, Description = "for an empty string it will return 0")>]
    [<TestCase("1", ExpectedResult  = 1, Description = "for a single sumber it will return that number")>]
    [<TestCase("1,2", ExpectedResult  = 3, Description = "for two numbers with comma it will return their sum")>]
     let AddTwoNumbers_CommaDelimiter_Returns_Sum inputString =
         Calculate.Add inputString


   [<TestCase("1,2,3", ExpectedResult  = 6)>]
   [<TestCase("3,4,5,6", ExpectedResult  = 18)>]
       let AddMoreThanTwoNumbers_CommaDelimiter_Returns_Sum inputString =
           Calculate.Add inputString

   [<TestCase("1\n2,3", ExpectedResult = 6)>]
    let Accept_Comma_And_newline_as_Seperators inputString = 
        Calculate.Add inputString
        

