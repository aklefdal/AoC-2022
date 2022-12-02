open System.IO

let score1 =
    function
    | "A X" -> 1 + 3 // rock - rock - draw
    | "B X" -> 1 + 0 // paper - rock - loose
    | "C X" -> 1 + 6 // scissor - rock - win
    | "A Y" -> 2 + 6 // rock - paper - win
    | "B Y" -> 2 + 3 // paper - paper - draw
    | "C Y" -> 2 + 0 // scissor - paper - loose
    | "A Z" -> 3 + 0 // rock - scissor - loose
    | "B Z" -> 3 + 6 // paper - scissor - win
    | "C Z" -> 3 + 3 // scissor - scissor - draw
    | _ -> failwith "Ouch"

// Input
let inputFilename = "day-02-input.txt"

let svar1 = 
    inputFilename 
    |> File.ReadAllLines
    |> Array.map score1
    |> Array.sum

type play =
    | Rock
    | Paper
    | Scissor

let game2 =
    function
    | "A X" -> 1 + 3 // rock - rock - draw
    | "B X" -> 1 + 0 // paper - rock - loose
    | "C X" -> 1 + 6 // scissor - rock - win
    | "A Y" -> 2 + 6 // rock - paper - win
    | "B Y" -> 2 + 3 // paper - paper - draw
    | "C Y" -> 2 + 0 // scissor - paper - loose
    | "A Z" -> 3 + 0 // rock - scissor - loose
    | "B Z" -> 3 + 6 // paper - scissor - win
    | "C Z" -> 3 + 3 // scissor - scissor - draw
    | _ -> failwith "Ouch"




let svar2 = 
    inputFilename 
    |> File.ReadAllLines
