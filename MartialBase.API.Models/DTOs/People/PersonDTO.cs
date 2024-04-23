// <copyright file="PersonDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System;

using MartialBase.API.Models.DTOs.Addresses;

namespace MartialBase.API.Models.DTOs.People
{
    public class PersonDTO
    {
        public PersonDTO()
        {
        }

        public PersonDTO(
            Guid id,
            string title,
            string firstName,
            string middleName,
            string lastName,
            DateTime? dateOfBirth,
            AddressDTO address,
            string mobileNo,
            string email)
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
        }

        public AddressDTO Address { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Email { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public Guid Id { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string MobileNo { get; set; }

        public string FullName => !string.IsNullOrEmpty(MiddleName)
            ? $"{Title} {FirstName} {MiddleName} {LastName}"
            : $"{Title} {FirstName} {LastName}";

        public int? Age
        {
            get
            {
                if (DateOfBirth == null)
                {
                    return null;
                }

                var today = DateTime.Today;
                var dateOfBirth = (DateTime)DateOfBirth;

                var age = today.Year - dateOfBirth.Year;

                // Go back to the year in which the person was born in case of a leap year
                if (dateOfBirth.Date > today.AddYears(-age))
                {
                    age--;
                }

                return age;
            }
        }
    }
}