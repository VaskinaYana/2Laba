let rec readDigits accumulator =
    let input = System.Console.ReadLine()
    
    match System.Int32.TryParse(input) with
    | (true, digit) when digit >= 0 && digit <= 9 ->
        readDigits (digit :: accumulator)
    | _ ->
        accumulator

let digitsToNumber digits =
    digits
    |> List.fold (fun accumulated digit -> accumulated * 10 + digit) 0

[<EntryPoint>]
let main argv =
    printfn "Введите десятичные цифры (для завершения введите любой другой символ):"
    
    let originalDigits = 
        readDigits []
        |> List.rev

    printfn "Введённые цифры: %A" originalDigits
    printfn "Полученное число: %d" (digitsToNumber originalDigits)
    
    0