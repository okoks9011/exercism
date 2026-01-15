module LuciansLusciousLasagna

let expectedMinutesInOven = 40

let remainingMinutesInOven v = expectedMinutesInOven - v

let preparationTimeInMinutes layers = 2 * layers

let elapsedTimeInMinutes layers v =
    let extraTime = preparationTimeInMinutes layers
    v + extraTime