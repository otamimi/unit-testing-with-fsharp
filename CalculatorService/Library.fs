namespace CalculatorService

open System

module Calculate =

   
    let Add inputString =
          match inputString with
          | "" -> 0
          | _  ->
               [ for number in inputString.Split[| ','; '\n'|] ->
                   Int32.Parse number] |> List.reduce (fun n1 n2 -> n1 + n2)
         
