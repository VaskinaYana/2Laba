[<EntryPoint>]
let main argv =
    printfn "Введите числа от 1 до 9 (для завершения введите любой другой символ):"

    let rec read acc =
        let input = System.Console.ReadLine()

        match System.Int32.TryParse(input) with
        | (true, number) when number >= 1 && number <= 9 ->
            read (number :: acc)
        | _ ->
            acc

    let list =
        read []
        |> List.rev

    let Roman number =
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

    let RomanNumbers =
        list
        |> List.map Roman

    printfn "Начальный список: %A" list
    printfn "Результат: %A" RomanNumbers
    0