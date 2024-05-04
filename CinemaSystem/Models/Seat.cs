using System;
using System.Collections.Generic;

namespace CinemaSystem.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public int? Row { get; set; }
        public string? Column { get; set; }
        public string? Venue { get; set; }
        public string? Status { get; set; }
        public string? SeatNumber { get; set; }
    }
}
