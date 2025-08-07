module Leap

(* let leapYear (year: int): bool =
    if year % 400 = 0 then
        true
    elif year % 100 = 0 then
        false
    elif year % 4 = 0 then
        true
    else
        false *)

let leapYear (year: int): bool =
    year % 4 = 0 && (year % 100 <> 0 || year % 400 = 0)