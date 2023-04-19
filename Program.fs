open System

let fibonacci n =
    let rec fib n prev curr =
        match n with
        | 0 -> prev
        | 1 -> curr
        | _ -> fib (n - 1) curr (prev + curr)
    fib n 0 1

[<EntryPoint>]
let main argv =
    printfn "Enter the number of Fibonacci numbers to generate:"
    let input = Console.ReadLine()
    let mutable n = 0
    if Int32.TryParse(input, &n) then
        printfn "The first %d Fibonacci numbers are:" n
        for i = 0 to n - 1 do
            let fib = fibonacci i
            printfn "%d" fib
    else
        printfn "Invalid input, please enter an integer."
    0 // return an exit code of 0
    