﻿using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class ErrorValidation
    {

    }
    public class GenreValidation : ValidationAttribute
    {
        private readonly string[] validGenres = { "Shooting", "Sport", "Strategy" };

        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                return false;
            }

            var genre = value.ToString();
            return validGenres.Contains(genre, StringComparer.OrdinalIgnoreCase);
        }
    }

    public class ReleaseYearValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var currentYear = DateTime.Now.Year;
            var releaseYear = value;

            return (int?)releaseYear >= (currentYear - 3);

        }

    }

    public class PurchaseDateValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var purchaseDate = Convert.ToDateTime(value);
            return purchaseDate <= DateTime.Now;
        }
    }

}
