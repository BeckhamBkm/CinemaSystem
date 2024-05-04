using System;
using System.Collections.Generic;

namespace CinemaSystem.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Rating { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? ImageUrl { get; set; }
        public decimal? Price { get; set; }
    }
}
