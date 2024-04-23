// <copyright file="StudentSchoolDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using MartialBase.API.Models.DTOs.Documents;
using MartialBase.API.Models.DTOs.Schools;

namespace MartialBase.API.Models.DTOs.People
{
    public class StudentSchoolDTO
    {
        public StudentSchoolDTO()
        {
        }

        public StudentSchoolDTO(
            SchoolDTO school,
            DocumentDTO insuranceDocument,
            DocumentDTO licenceDocument,
            bool isInstructor,
            bool isSecretary)
        {
            School = school;
            InsuranceDocument = insuranceDocument;
            LicenceDocument = licenceDocument;
            IsInstructor = isInstructor;
            IsSecretary = isSecretary;
        }

        public DocumentDTO InsuranceDocument { get; set; }

        public bool IsInstructor { get; set; }

        public bool IsSecretary { get; set; }

        public DocumentDTO LicenceDocument { get; set; }

        public SchoolDTO School { get; set; }
    }
}