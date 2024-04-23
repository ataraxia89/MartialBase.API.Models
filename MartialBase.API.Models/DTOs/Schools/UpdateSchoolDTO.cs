// <copyright file="UpdateSchoolDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using MartialBase.API.Models.DTOs.Addresses;

namespace MartialBase.API.Models.DTOs.Schools
{
    public class UpdateSchoolDTO
    {
        public Dictionary<string, UpdateAddressDTO> AdditionalTrainingVenues { get; set; }

        public UpdateAddressDTO Address { get; set; }

        [MaxLength(45, ErrorMessage = "Email cannot be longer than 45 characters.")]
        public string EmailAddress { get; set; }

        [MaxLength(20, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string Name { get; set; }

        [MaxLength(30, ErrorMessage = "Phone number cannot be longer than 30 characters.")]
        public string PhoneNo { get; set; }

        [MaxLength(70, ErrorMessage = "Website URL cannot be longer than 70 characters.")]
        public string WebsiteURL { get; set; }
    }
}
