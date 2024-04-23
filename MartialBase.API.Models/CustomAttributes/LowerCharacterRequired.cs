// <copyright file="LowerCharacterRequired.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

namespace MartialBase.API.Models.CustomAttributes
{
    public class LowerCharacterRequired : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var input = (string)value;

            if (input == null)
            {
                return new ValidationResult(ErrorMessage);
            }

            var hasLowercase = !input.Equals(input.ToUpper());

            if (hasLowercase)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage);
        }
    }
}