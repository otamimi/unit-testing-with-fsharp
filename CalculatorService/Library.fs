namespace CalculatorService

open System

module Calculate =
    let Add inputString =
       match inputString with
       | "" -> 0
       | _ -> Int32.Parse inputString
