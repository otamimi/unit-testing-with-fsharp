namespace CalculatorService

open System

module Calculate =

    let decompose (str:string) = 
        match str with
        | str when str.StartsWith("//") ->
            let delim = str.[2]
            ([| delim |], str.[3..])
        | str -> ([| ',';'\n' |], str)

    let Add str =
          match str with
          | "" -> 0
          | _ ->
                let delimiter, numbers = decompose str
                numbers.Split(delimiter) |> Array.map int |> Array.sum
         
         
