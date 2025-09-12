module GuessingGame

let reply (guess: int): string =
    match guess with
    | 42 -> "Correct"
    | 41 | 43 -> "So close"
    | l when l < 41 -> "Too low"
    | h when h > 43 -> "Too high"
    | _ -> failwith "Impossible"