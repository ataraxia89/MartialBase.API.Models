// <copyright file="OrganisationPersonDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

namespace MartialBase.API.Models.DTOs.People
{
    public class OrganisationPersonDTO
    {
        public OrganisationPersonDTO()
        {
        }

        public OrganisationPersonDTO(
            PersonDTO person,
            bool isAdmin)
        {
            Person = person;
            IsAdmin = isAdmin;
        }

        public bool IsAdmin { get; set; }

        public PersonDTO Person { get; set; }
    }
}