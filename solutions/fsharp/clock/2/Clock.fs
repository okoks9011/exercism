module Clock

type clock = int * int

let (/%) a b = ((a % b) + b) % b
let div a b = (a / b) + (if a % b < 0 then -1 else 0)

let normalize (clock : clock) : clock =
    let (preH, preM)  = clock
    let newM = preM /% 60
    let newH = (preH + div preM 60) /% 24
    (newH, newM)

let create hours minutes : clock = normalize (hours, minutes)

let add minutes (clock : clock) =
    normalize (fst clock, snd clock + minutes)

let subtract minutes (clock : clock) =
    add -minutes clock

let display (clock : clock) =
    let (h, m) = clock
    sprintf "%02d:%02d" h m