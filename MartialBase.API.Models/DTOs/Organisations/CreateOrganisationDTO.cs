// <copyright file="CreateOrganisationDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

using MartialBase.API.Models.DTOs.Addresses;

namespace MartialBase.API.Models.DTOs.Organisations
{
    public class CreateOrganisationDTO
    {
        public CreateAddressDTO Address { get; set; }

        [Required(ErrorMessage = "Initials required.")]
        [MaxLength(8, ErrorMessage = "Initials cannot be longer than 8 characters.")]
        public string Initials { get; set; }

        [Required(ErrorMessage = "Name required.")]
        [MaxLength(60, ErrorMessage = "Name cannot be longer than 60 characters.")]
        public string Name { get; set; }

        [MaxLength(68, ErrorMessage = "Parent ID cannot be longer than 68 characters.")]
        public string ParentId { get; set; }
    }
}