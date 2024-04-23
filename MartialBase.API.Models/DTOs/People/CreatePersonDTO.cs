// <copyright file="CreatePersonDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

using MartialBase.API.Models.DTOs.Addresses;

namespace MartialBase.API.Models.DTOs.People
{
    public class CreatePersonDTO
    {
        public CreateAddressDTO Address { get; set; }

        [RegularExpression(
            @"^\d{4}\-(0[1-9]|1[012])\-(0[1-9]|[12][0-9]|3[01])$",
            ErrorMessage = "Invalid date format. Ensure date is submitted as yyyy-mm-dd.")]
        public string DateOfBirth { get; set; }

        [MaxLength(45, ErrorMessage = "Email cannot be longer than 45 characters.")]
        public string Email { get; set; }

        [MaxLength(15, ErrorMessage = "Title cannot be longer than 15 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "First name required.")]
        [MaxLength(15, ErrorMessage = "First name cannot be longer than 15 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name required.")]
        [MaxLength(25, ErrorMessage = "Last name cannot be longer than 25 characters.")]
        public string LastName { get; set; }

        [MaxLength(35, ErrorMessage = "Middle name cannot be longer than 35 characters.")]
        public string MiddleName { get; set; }

        [MaxLength(30, ErrorMessage = "Mobile no. cannot be longer than 30 characters.")]
        public string MobileNo { get; set; }
    }
}
