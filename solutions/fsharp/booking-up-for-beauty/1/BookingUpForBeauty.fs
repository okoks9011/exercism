module BookingUpForBeauty

// The following line is needed to use the DateTime type
open System

let schedule = DateTime.Parse

let hasPassed (appointmentDate: DateTime): bool = DateTime.Compare (appointmentDate, DateTime.Now) < 0

let isAfternoonAppointment (appointmentDate: DateTime): bool =
    12 <= appointmentDate.Hour && appointmentDate.Hour < 18

let description (ad: DateTime): string =
    let dtStr = ad.ToString "G"
    sprintf "You have an appointment on %s." dtStr

let anniversaryDate(): DateTime =
    let thisYear = DateTime.Now.Year
    DateTime (thisYear, 9, 15, 0, 0, 0)
