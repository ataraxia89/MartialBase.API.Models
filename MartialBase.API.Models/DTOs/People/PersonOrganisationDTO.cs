// <copyright file="PersonOrganisationDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using MartialBase.API.Models.DTOs.Organisations;

namespace MartialBase.API.Models.DTOs.People
{
    public class PersonOrganisationDTO
    {
        public PersonOrganisationDTO()
        {
        }

        public PersonOrganisationDTO(
            PersonDTO person,
            OrganisationDTO organisation,
            bool isAdmin)
        {
            Person = person;
            Organisation = organisation;
            IsAdmin = isAdmin;
        }

        public bool IsAdmin { get; set; }

        public OrganisationDTO Organisation { get; set; }

        public PersonDTO Person { get; set; }
    }
}