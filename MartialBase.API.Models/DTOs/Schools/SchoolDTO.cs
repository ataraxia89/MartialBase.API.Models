// <copyright file="SchoolDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using MartialBase.API.Models.DTOs.Addresses;

namespace MartialBase.API.Models.DTOs.Schools
{
    public class SchoolDTO
    {
        public SchoolDTO()
        {
        }

        public SchoolDTO(
            Guid id,
            string artId,
            string artName,
            string organisationId,
            string organisationName,
            string name,
            string headInstructorId,
            string headInstructorName,
            AddressDTO address,
            string phoneNo,
            string emailAddress,
            string websiteURL,
            List<AddressDTO> trainingVenues)
        {
            Id = id;
            ArtId = artId;
            ArtName = artName;
            OrganisationId = organisationId;
            OrganisationName = organisationName;
            Name = name;
            HeadInstructorId = headInstructorId;
            HeadInstructorName = headInstructorName;
            Address = address;
            PhoneNo = phoneNo;
            EmailAddress = emailAddress;
            WebsiteURL = websiteURL;
            TrainingVenues = trainingVenues;
        }

        public AddressDTO Address { get; set; }

        public string ArtId { get; set; }

        public string ArtName { get; set; }

        public string EmailAddress { get; set; }

        public string HeadInstructorId { get; set; }

        public string HeadInstructorName { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string OrganisationId { get; set; }

        public string OrganisationName { get; set; }

        public string PhoneNo { get; set; }

        public List<AddressDTO> TrainingVenues { get; set; }

        public string WebsiteURL { get; set; }
    }
}