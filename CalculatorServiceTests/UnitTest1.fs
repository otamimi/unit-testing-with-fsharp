namespace CalculatorService.Tests

open NUnit.Framework
open System
open CalculatorService


[<TestFixture>]
type TestClass () =

    [<Test>]
    member this.TestEvenSequence() =
    let expected = Seq.empty<int>
    let actual = Calculate.Add [2; 4; 6; 8; 10]
    Assert.That(actual, Is.EqualTo(expected))