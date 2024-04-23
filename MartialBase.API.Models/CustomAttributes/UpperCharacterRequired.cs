// <copyright file="UpperCharacterRequired.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

namespace MartialBase.API.Models.CustomAttributes
{
    public class UpperCharacterRequired : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var input = (string)value;

            if (input == null)
            {
                return new ValidationResult(ErrorMessage);
            }

            var hasUppercase = !input.Equals(input.ToLower());

            if (hasUppercase)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage);
        }
    }
}