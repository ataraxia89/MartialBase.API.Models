// <copyright file="OrganisationDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using MartialBase.API.Models.DTOs.Addresses;

namespace MartialBase.API.Models.DTOs.Organisations
{
    public class OrganisationDTO
    {
        public OrganisationDTO()
        {
        }

        public OrganisationDTO(
            string id,
            string initials,
            string name,
            string parentOrganisationId,
            string parentOrganisationInitials,
            AddressDTO address)
        {
            Id = id;
            Initials = initials;
            Name = name;
            ParentOrganisationId = parentOrganisationId;
            ParentOrganisationInitials = parentOrganisationInitials;
            Address = address;
        }

        public AddressDTO Address { get; set; }

        public string Id { get; set; }

        public string Initials { get; set; }

        public string Name { get; set; }

        public string ParentOrganisationId { get; set; }

        public string ParentOrganisationInitials { get; set; }
    }
}