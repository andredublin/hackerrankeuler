open System

let sumOfMultiples (offset : bigint, limit : bigint) : bigint =
    let length = (limit - 1I) / offset
    let last = offset + (length - 1I) * offset
    length * (offset + last) / 2I

let parse = Console.ReadLine

let listInts = [ 1..(int (parse())) ] |> List.map (fun _ -> int (parse()))

listInts
|> List.map (fun x -> sumOfMultiples (3I, bigint (x)) + sumOfMultiples (5I, bigint (x)) - sumOfMultiples (15I, bigint (x)))
|> List.iter Console.WriteLine
