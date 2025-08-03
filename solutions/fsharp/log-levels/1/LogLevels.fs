module LogLevels

let message (logLine: string): string =
    let splited = logLine.Split(':')
    splited.[1].Trim()

let logLevel(logLine: string): string =
    let splited = logLine.Split(':')
    let rawLevel = splited.[0]
    rawLevel.[1..rawLevel.Length-2].ToLower()

let reformat(logLine: string): string =
    sprintf "%s (%s)" (message logLine) (logLevel logLine)