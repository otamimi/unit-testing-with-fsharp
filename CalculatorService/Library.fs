namespace CalculatorService

open System

module Calculate =

   
    let Add str =
          match str with
          | "" -> 0
          | _ when str.StartsWith("//") -> 
                let delimiter = str.[2]
                str.[3..].Split(delimiter) |> Array.map int |> Array.sum
          | _  ->
              str.Split(',','\n') |> Array.map int |> Array.sum
         
