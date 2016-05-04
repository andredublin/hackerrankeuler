open System

// a prime number is a whole number greater than 1, whose only two whole-number factors are 1 and itself
let isPrime (n : int64) = 
    // For a number like 17 it would take 7 iterations until the left hand side evaluates true
    // imagine the number of iterations for int64 max or 9223372036854775807
    // unfortunately this check function time space becomes O(n^2) or O(n!) for larger ints
    let rec check i = double i > double (n / 2L) || (n % i <> 0L && check (i + 1L))
    check 2L

let parse = Console.ReadLine
let cases = [ 1..(int (parse())) ] |> List.map (fun _ -> int64 (parse()))

for x in cases do
    seq { 
        for i in 2L..x do
            if x % i = 0L && isPrime i then yield i
    }
    |> Seq.last
    |> Console.WriteLine
