﻿// <copyright file="CreatedPersonOrganisationDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using MartialBase.API.Models.DTOs.Organisations;

namespace MartialBase.API.Models.DTOs.People
{
    public class CreatedPersonOrganisationDTO : PersonOrganisationDTO
    {
        public CreatedPersonOrganisationDTO()
        {
        }

        public CreatedPersonOrganisationDTO(
            CreatedPersonDTO person,
            OrganisationDTO organisation,
            bool isAdmin)
        {
            Person = person;
            Organisation = organisation;
            IsAdmin = isAdmin;
        }

        public new CreatedPersonDTO Person { get; set; }
    }
}
