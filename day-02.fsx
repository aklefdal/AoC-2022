open System.IO

type Play =
    | Rock
    | Paper
    | Scissor

type Result =
    | Loose
    | Draw
    | Win

let game1 (line: string) =
    let opponentPlay =
        match line[0] with
        | 'A' -> Rock
        | 'B' -> Paper
        | 'C' -> Scissor
        | _ -> failwith "Ouch"

    let myPlay =
        match line[2] with
        | 'X' -> Rock
        | 'Y' -> Paper
        | 'Z' -> Scissor
        | _ -> failwith "Ouch"

    opponentPlay, myPlay

let score ((me, result): Play * Result) =
    let scorePlayed =
        match me with
        | Rock -> 1
        | Paper -> 2
        | Scissor -> 3

    let scoreResult =
        match result with
        | Loose -> 0
        | Draw -> 3
        | Win -> 6

    scorePlayed + scoreResult

let result1 (opponentPlay, myPlay) =
    let result =
        match opponentPlay, myPlay with
        | Rock, Rock -> Draw
        | Rock, Paper -> Win
        | Rock, Scissor -> Loose
        | Paper, Rock -> Loose
        | Paper, Paper -> Draw
        | Paper, Scissor -> Win
        | Scissor, Rock -> Win
        | Scissor, Paper -> Loose
        | Scissor, Scissor -> Draw

    myPlay, result
// Input
let inputFilename = "day-02-input.txt"

let svar1 =
    inputFilename
    |> File.ReadAllLines
    |> Array.map game1
    |> Array.map result1
    |> Array.map score
    |> Array.sum

let game2 (line: string) =
    let opponentPlay =
        match line[0] with
        | 'A' -> Rock
        | 'B' -> Paper
        | 'C' -> Scissor
        | _ -> failwith "Ouch"

    let result =
        match line[2] with
        | 'X' -> Loose
        | 'Y' -> Draw
        | 'Z' -> Win
        | _ -> failwith "Ouch"

    opponentPlay, result

let myPlay ((op, st): Play * Result) =
    let me =
        match op, st with
        | Rock, Loose -> Scissor
        | Paper, Loose -> Rock
        | Scissor, Loose -> Paper
        | Rock, Draw -> Rock
        | Paper, Draw -> Paper
        | Scissor, Draw -> Scissor
        | Rock, Win -> Paper
        | Paper, Win -> Scissor
        | Scissor, Win -> Rock

    me, st

let svar2 =
    inputFilename
    |> File.ReadAllLines
    |> Array.map game2
    |> Array.map myPlay
    |> Array.map score
    |> Array.sum
