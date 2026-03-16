let rec readNumbers accumulator =
    let input = System.Console.ReadLine()
    
    match System.Int32.TryParse(input) with
    | (true, number) when number >= 1 && number <= 9 ->
        readNumbers (number :: accumulator)
    | _ ->
        accumulator

let toRoman number =
    match number with
    | 1 -> "I"
    | 2 -> "II"
    | 3 -> "III"
    | 4 -> "IV"
    | 5 -> "V"
    | 6 -> "VI"
    | 7 -> "VII"
    | 8 -> "VIII"
    | 9 -> "IX"
    | _ -> failwith "Неподдерживаемое число"

[<EntryPoint>]
let main argv =
    printfn "Введите числа от 1 до 9 (для завершения введите любой другой символ):"

    let originalList = 
        readNumbers []
        |> List.rev
    
    let romanList =
        originalList
        |> List.map toRoman

    printfn "Начальный список: %A" originalList
    printfn "Результат: %A" romanList
    
    0