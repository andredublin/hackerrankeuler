open System

let parse = Console.ReadLine

[ 1..(int (parse())) ]
|> Seq.map (fun _ -> int64 (parse()))
|> Seq.iter (fun x -> 
       Console.WriteLine(Seq.sum (Seq.unfold (fun (a, b, limit) -> 
                                      if a <= limit then 
                                          match a with
                                          | a when a % 2L = 0L -> Some(a, (b, a + b, limit))
                                          | _ -> Some(0L, (b, a + b, limit))
                                      else None) (0L, 1L, x))))
