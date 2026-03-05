// Ввод цифр
printfn "Введите десятичные цифры (для завершения введите любой другой символ):"

// рекурсивная функция для чтения цифр
let rec readDigits acc =
    let input = System.Console.ReadLine()

    match System.Int32.TryParse(input) with
    | (true, digit) when digit >= 0 && digit <= 9 ->
        readDigits (digit :: acc)
    | _ ->
        acc

// получаем список цифр и переворачиваем его
let digits =
    readDigits []
    |> List.rev

// формируем число
let number =
    digits
    |> List.fold (fun acc digit -> acc * 10 + digit) 0

// вывод
printfn "Введённые цифры: %A" digits
printfn "Полученное число: %d" number