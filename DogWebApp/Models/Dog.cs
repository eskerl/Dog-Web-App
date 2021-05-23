﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace DogWebApp.Models
{
    public class Dog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Breed { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? Birthday { get; set; }
        [Range(0, 30)]
        public short? Age { get; set; }


        [Range(0.0, 350.0)]
        public float? Weight { get; set; }
    }
}
