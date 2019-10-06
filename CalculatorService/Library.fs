namespace CalculatorService

open System

module Calculate =

    let decompose (str:string) = 
        match str with
        | str when str.StartsWith("//[") ->
            let delimiter = str.[3..str.IndexOf("]") - 1]
            ([| delimiter |], str.[str.IndexOf("\n")..])
        | str when str.StartsWith("//") ->
            let delim = str.[2]
            ([| string delim |], str.[3..])
        | str -> ([| ",";"\n" |], str)

    let Add str =
          match str with
          | "" -> 0
          | _ ->
                let delimiter, numbers = decompose str
                let negatives, positives = numbers.Split(delimiter, StringSplitOptions.RemoveEmptyEntries) |> Array.map int |> Array.partition (fun n -> n<0)
                if negatives.Length > 0 then
                    invalidArg "str" (sprintf "negative numbers are not valid input %s" <| String.Join(",",negatives))
                else
                    positives |> Array.filter(fun n -> n<1000) |> Array.sum
                
         
         
