open System

let decompose (str:string) = 
    match str with
    | str when str.Contains("][") ->  
            let delim1 =  str.[3..str.IndexOf("]") - 1]
            let delim2 = str.[(str.IndexOf("][")+2)..str.LastIndexOf("]") - 1]
            ([| delim1;delim2 |], str.[str.IndexOf("\n")..])
    | str when str.StartsWith("//[") ->
             let delim = str.[3..str.IndexOf("]") - 1]
             ([| delim |], str.[str.IndexOf("\n")..])
    | str when str.StartsWith("//") ->
            let delim = str.[2]
            ([| string delim |], str.[3..])
    | str -> ([| ",";"\n" |], str)
   
let add str = 
    match str with
    | "" -> 0
    
    | str -> 
            let delim, numbers = decompose str
            let negatives, positives = numbers.Split(delim, StringSplitOptions.RemoveEmptyEntries) |> Array.map int |> Array.partition (fun n -> n < 0)
            if negatives.Length > 0 then 
                invalidArg "str" (sprintf "negative numbers are not allowed %s" <| String.Join(",", negatives))
            else
                positives  |> Array.filter (fun n -> n < 1000) |> Array.sum

//The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0) for example “” or “1” or “1,2”
let r1 = add "" = 0
let r2 = add "100" = 100
let r3 = add "1,2" = 3
let r4 = add "1,2,3" = 6
//.Allow the Add method to handle new lines between numbers (instead of commas).the following input is ok:  “1\n2,3”  (will equal 6)
let r5 = add "1\n2,3" = 6
//Support different delimiters  “//[delimiter]\n[numbers…]”  “//;\n1;2” should return three where the default delimiter is ‘;’ .
let r6 = add "//-\n1-2" = 3
let r7 = add "//;\n1;2;3" =6
//Calling Add with a negative number will throw an exception “negatives not allowed” - and the negative that was passed
//if there are multiple negatives, show all of them in the exception message
//let r8 = add "1,-2,-3" = 1
//Numbers bigger than 1000 should be ignored, so adding 2 + 1001  = 2
let r9 = add "2,1001" = 2
//Delimiters can be of any length with the following format:  “//[delimiter]\n” for example: “//[***]\n1***2***3” should return 6
let r10 = add "//[****]\n1****2****3" = 6
//Allow multiple delimiters like this:  “//[delim1][delim2]\n” for example “//[*][%]\n1*2%3” should return 6. 
let r11 = add "//[***][%%]\n1***2%%3" = 6