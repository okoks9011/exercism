module Clock

type clock = int * int

let normalize (clock : clock) : clock =
    match clock with
    | (preH, preM) ->
        let updatedM = preM % 60 in
        let hasMinusM = updatedM < 0 in
        let newM = if hasMinusM then updatedM + 60 else updatedM in
        let updatedH = (preH + preM / 60 + (if hasMinusM then - 1 else 0)) % 24 in
        let newH = if updatedH < 0 then updatedH + 24 else updatedH in
        (newH, newM)

let create hours minutes : clock = normalize (hours, minutes)

let add minutes (clock : clock) =
    match clock with
    | (preH, preM) -> normalize (preH, preM + minutes)

let subtract minutes (clock : clock) =
    match clock with
    | (preH, preM) -> normalize (preH, preM - minutes)

let display (clock : clock) =
    match clock with
    | (h, m) -> sprintf "%02d:%02d" h m