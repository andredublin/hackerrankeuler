open System

let parse = Console.ReadLine

let listInts = [ 1..(int (parse())) ] |> List.map (fun _ -> int (parse()))
