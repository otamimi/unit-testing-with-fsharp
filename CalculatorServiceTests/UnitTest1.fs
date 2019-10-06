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
    [<TestCase("1,2\n3", ExpectedResult = 6)>]
        let Accept_Comma_And_newline_as_Seperators inputString = 
            Calculate.Add inputString
        

    [<TestCase("//;\n1;2", ExpectedResult = 3)>]
        let Support_Different_Delimiters inputString = 
            Calculate.Add inputString
    [<TestCase("//;\n1", ExpectedResult = 1)>]
        let Single_Number_With_Custom_delimiter inputString = 
            Calculate.Add inputString

    [<Test>]
        let NigativeNumbers_ThrowException_ShowInvalidInput() =
            Assert.Throws<ArgumentException>
                (fun () ->Calculate.Add "//;\n1;-2;-3" |> ignore)
            |> ignore
    [<TestCase("2,2002", ExpectedResult = 2)>]
        let Numbers_bigger_than_1000_should_be_ignored inputString = 
            Calculate.Add inputString
    [<TestCase("//[***]\n1***2***3", ExpectedResult = 6)>]
        let Delimiters_Can_Be_OfAny_Length inputString = 
            Calculate.Add inputString

   
           
           