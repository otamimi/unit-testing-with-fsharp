namespace CalculatorService

open System

module Calculate =
    let Add inputString =
       match inputString with
       | "" -> 0
       | _ when inputString.Contains "," ->
            [ for number in inputString.Split[| ','|] ->
                Int32.Parse number] |> List.reduce (fun n1 n2 -> n1 + n2)
       | _ -> Int32.Parse inputString
