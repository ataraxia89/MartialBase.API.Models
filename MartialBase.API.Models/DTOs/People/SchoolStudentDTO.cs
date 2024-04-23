// <copyright file="SchoolStudentDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System;
using MartialBase.API.Models.DTOs.Documents;

namespace MartialBase.API.Models.DTOs.People
{
    public class SchoolStudentDTO
    {
        public SchoolStudentDTO()
        {
        }

        public SchoolStudentDTO(
            PersonDTO student,
            Guid schoolId,
            string schoolName,
            DocumentDTO insuranceDocument,
            DocumentDTO licenceDocument,
            bool isInstructor,
            bool isSecretary)
        {
            Student = student;
            SchoolId = schoolId;
            SchoolName = schoolName;
            InsuranceDocument = insuranceDocument;
            LicenceDocument = licenceDocument;
            IsInstructor = isInstructor;
            IsSecretary = isSecretary;
        }

        public DocumentDTO InsuranceDocument { get; set; }

        public bool IsInstructor { get; set; }

        public bool IsSecretary { get; set; }

        public DocumentDTO LicenceDocument { get; set; }

        public Guid SchoolId { get; set; }

        public string SchoolName { get; set; }

        public PersonDTO Student { get; set; }
    }
}