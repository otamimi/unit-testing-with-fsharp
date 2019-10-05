namespace CalculatorService.Tests

open NUnit.Framework
open System
open CalculatorService


[<TestFixture>]
module TestClass  =

    [<Test>]
    let EmptyStringReturnsZero() =
        let expected = 0
        let actual = Calculate.Add ""
        Assert.That(actual, Is.EqualTo(expected))

    [<TestCase("1", ExpectedResult  = 1)>]
    [<TestCase("100", ExpectedResult  = 100)>]
    let SingleNumberReturnsSelf inputString =
         Calculate.Add inputString


   
        

