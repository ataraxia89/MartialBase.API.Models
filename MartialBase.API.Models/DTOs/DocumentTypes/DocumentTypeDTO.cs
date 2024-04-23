// <copyright file="DocumentTypeDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

namespace MartialBase.API.Models.DTOs.DocumentTypes
{
    public class DocumentTypeDTO
    {
        public DocumentTypeDTO()
        {
        }

        public DocumentTypeDTO(
            string id,
            string organisationId,
            string organisation,
            string referenceNo,
            string name,
            int? documentExpiryDays,
            string templateURL)
        {
            Id = id;
            OrganisationId = organisationId;
            Organisation = organisation;
            ReferenceNo = referenceNo;
            Name = name;
            DocumentExpiryDays = documentExpiryDays;
            URL = templateURL;
        }

        public int? DocumentExpiryDays { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Organisation { get; set; }

        public string OrganisationId { get; set; }

        public string ReferenceNo { get; set; }

        public string URL { get; set; }
    }
}