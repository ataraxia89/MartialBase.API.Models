// <copyright file="CreatePersonOrganisationDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

using MartialBase.API.Models.DTOs.People;

namespace MartialBase.API.Models.DTOs.Organisations
{
    public class CreatePersonOrganisationDTO
    {
        [Required]
        public CreateOrganisationDTO Organisation { get; set; }

        [Required]
        public CreatePersonDTO Person { get; set; }
    }
}