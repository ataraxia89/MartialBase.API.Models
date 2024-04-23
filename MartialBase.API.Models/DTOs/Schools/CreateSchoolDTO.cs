// <copyright file="CreateSchoolDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using MartialBase.API.Models.DTOs.Addresses;

namespace MartialBase.API.Models.DTOs.Schools
{
    public class CreateSchoolDTO
    {
        public List<CreateAddressDTO> AdditionalTrainingVenues { get; set; }

        [Required(ErrorMessage = "Address required.")]
        public CreateAddressDTO Address { get; set; }

        [Required(ErrorMessage = "Art ID required.")]
        [MaxLength(68, ErrorMessage = "Art ID cannot be longer than 68 characters.")]
        public string ArtId { get; set; }

        [MaxLength(45, ErrorMessage = "Email cannot be longer than 45 characters.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Head instructor ID required.")]
        [MaxLength(68, ErrorMessage = "Head instructor ID cannot be longer than 68 characters.")]
        public string HeadInstructorId { get; set; }

        [Required(ErrorMessage = "Name required.")]
        [MaxLength(40, ErrorMessage = "Name cannot be longer than 40 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Organisation ID required.")]
        [MaxLength(68, ErrorMessage = "Organisation ID cannot be longer than 68 characters.")]
        public string OrganisationId { get; set; }

        [MaxLength(30, ErrorMessage = "Phone number cannot be longer than 30 characters.")]
        public string PhoneNo { get; set; }

        [MaxLength(70, ErrorMessage = "Website URL cannot be longer than 70 characters.")]
        public string WebsiteURL { get; set; }
    }
}
