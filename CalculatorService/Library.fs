namespace CalculatorService

open System

module Calculate =
    let Add inputString =
       match inputString with
       | "" -> 0
       | _ when inputString.Contains "," ->
            let numbers = inputString.Split [| ',' |]
            (Int32.Parse numbers.[0]) + (Int32.Parse numbers.[1])
       | _ -> Int32.Parse inputString
