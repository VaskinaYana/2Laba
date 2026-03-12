[<EntryPoint>]
let main argv =
    printfn "Введите десятичные цифры (для завершения введите любой другой символ):"

    let rec readDigits acc =
        let input = System.Console.ReadLine()

        match System.Int32.TryParse(input) with
        | (true, digit) when digit >= 0 && digit <= 9 ->
            readDigits (digit :: acc)
        | _ ->
            acc

    let digits =
        readDigits []
        |> List.rev

    let number =
        digits
        |> List.fold (fun acc digit -> acc * 10 + digit) 0

    printfn "Введённые цифры: %A" digits
    printfn "Полученное число: %d" number
    0