// <copyright file="UpdateOrganisationDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

namespace MartialBase.API.Models.DTOs.Organisations
{
    public class UpdateOrganisationDTO
    {
        [MaxLength(8, ErrorMessage = "Initials cannot be longer than 8 characters.")]
        public string Initials { get; set; }

        [MaxLength(60, ErrorMessage = "Name cannot be longer than 60 characters.")]
        public string Name { get; set; }
    }
}