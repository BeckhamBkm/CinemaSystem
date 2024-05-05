﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaSystem.Models
{
    public class Director
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
