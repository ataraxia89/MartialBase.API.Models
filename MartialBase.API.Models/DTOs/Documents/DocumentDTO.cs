// <copyright file="DocumentDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System;

namespace MartialBase.API.Models.DTOs.Documents
{
    public class DocumentDTO
    {
        public DocumentDTO()
        {
        }

        public DocumentDTO(
            string id,
            string typeId,
            string type,
            string issuer,
            DateTime? date,
            string reference,
            string documentURL,
            DateTime? expiryDate)
        {
            Id = id;
            TypeId = typeId;
            Issuer = issuer;
            Type = type;
            Date = date;
            Reference = reference;
            URL = documentURL;
            ExpiryDate = expiryDate;
        }

        public DateTime? Date { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public string Id { get; set; }

        public string Issuer { get; set; }

        public string Reference { get; set; }

        public string Type { get; set; }

        public string TypeId { get; set; }

        public string URL { get; set; }
    }
}