// <copyright file="CreatedPersonDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System;

using MartialBase.API.Models.DTOs.Addresses;

namespace MartialBase.API.Models.DTOs.People
{
    public class CreatedPersonDTO : PersonDTO
    {
        public CreatedPersonDTO()
        {
        }

        public CreatedPersonDTO(
            Guid id,
            string title,
            string firstName,
            string middleName,
            string lastName,
            DateTime? dateOfBirth,
            AddressDTO address,
            string mobileNo,
            string email,
            string invitationCode)
        {
            Id = id;
            Title = title;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Address = address;
            MobileNo = mobileNo;
            Email = email;
            InvitationCode = invitationCode;
        }

        public string InvitationCode { get; set; }
    }
}
