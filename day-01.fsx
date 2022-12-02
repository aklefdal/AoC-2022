open System.IO

let folder (l: int list) (s: string) =
    if s = "" then
        0 :: l
    else
        let i = int s

        match l with
        | [] -> [ i ]
        | h :: t -> (h + i) :: t

// Input
let inputFilename = "day-01-input.txt"

let svar1 =
    inputFilename |> File.ReadAllLines |> Array.fold folder [ 0 ] |> List.max

let svar2 =
    inputFilename
    |> File.ReadAllLines
    |> Array.fold folder [ 0 ]
    |> List.sortDescending
    |> List.take 3
    |> List.sum
