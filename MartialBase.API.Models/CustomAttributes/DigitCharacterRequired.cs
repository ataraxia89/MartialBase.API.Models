// <copyright file="DigitCharacterRequired.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MartialBase.API.Models.CustomAttributes
{
    public class DigitCharacterRequired : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var input = (string)value;

            if (input == null)
            {
                return new ValidationResult(ErrorMessage);
            }

            var hasDigit = input.Any(char.IsDigit);

            if (hasDigit)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage);
        }
    }
}