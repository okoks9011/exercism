module BookingUpForBeauty

// The following line is needed to use the DateTime type
open System

let schedule = DateTime.Parse

let hasPassed (appointmentDate: DateTime): bool = appointmentDate < DateTime.Now

let isAfternoonAppointment (appointmentDate: DateTime): bool =
    12 <= appointmentDate.Hour && appointmentDate.Hour < 18

let description (ad: DateTime): string = $"You have an appointment on {ad}."

let anniversaryDate(): DateTime =
    DateTime (DateTime.Now.Year, 9, 15)
