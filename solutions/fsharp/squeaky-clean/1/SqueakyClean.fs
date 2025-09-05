module SqueakyClean

open System

let transform (c: char) : string =
    match c with
    | '-' -> "_"
    | ' ' -> ""
    | u when Char.IsUpper u -> Char.ToLower c |> sprintf "-%c"
    | d when Char.IsAsciiDigit d -> ""
    | gl when 'α' <= gl && gl <= 'ω' -> "?"
    | other -> Char.ToString other

let clean (identifier: string): string =
    String.collect transform identifier
