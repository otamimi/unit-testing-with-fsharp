namespace CalculatorService.Tests

open NUnit.Framework
open System
open CalculatorService


[<TestFixture>]
type TestClass () =

    [<Test>]
    member this.EmptyStringReturnsZero() =
        let expected = 0
        let actual = Calculate.Add ""
        Assert.That(actual, Is.EqualTo(expected))

   // [<TestCase("1", Result = 1)>]
    [<Test>]
    member this.SingleNumberReturnsSelf() =
        let expected = 6
        let actual = Calculate.Add expected
        Assert.That(actual, Is.EqualTo(expected))