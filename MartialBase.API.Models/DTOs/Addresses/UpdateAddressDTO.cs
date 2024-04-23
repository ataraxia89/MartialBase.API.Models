// <copyright file="UpdateAddressDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

namespace MartialBase.API.Models.DTOs.Addresses
{
    public class UpdateAddressDTO
    {
        [MaxLength(3, ErrorMessage = "Country code cannot be longer than 3 characters.")]
        public string CountryCode { get; set; }

        [MaxLength(30, ErrorMessage = "County cannot be longer than 30 characters.")]
        public string County { get; set; }

        [MaxLength(30, ErrorMessage = "Landline phone cannot be longer than 30 characters.")]
        public string LandlinePhone { get; set; }

        [MaxLength(50, ErrorMessage = "Line 1 cannot be longer than 50 characters.")]
        public string Line1 { get; set; }

        [MaxLength(30, ErrorMessage = "Line 2 cannot be longer than 30 characters.")]
        public string Line2 { get; set; }

        [MaxLength(30, ErrorMessage = "Line 3 cannot be longer than 30 characters.")]
        public string Line3 { get; set; }

        [MaxLength(8, ErrorMessage = "Postcode cannot be longer than 8 characters.")]
        public string PostCode { get; set; }

        [MaxLength(80, ErrorMessage = "Town cannot be longer than 80 characters.")]
        public string Town { get; set; }
    }
}
