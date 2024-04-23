// <copyright file="CreateDocumentDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;

namespace MartialBase.API.Models.DTOs.Documents
{
    public class CreateDocumentDTO
    {
        public DateTime? DocumentDate { get; set; }

        [Required(ErrorMessage = "Document type ID required.")]
        [MaxLength(68, ErrorMessage = "Document type ID cannot be longer than 68 characters.")]
        public string DocumentTypeId { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [MaxLength(20, ErrorMessage = "Reference cannot be longer than 20 characters.")]
        public string Reference { get; set; }

        [MaxLength(250, ErrorMessage = "URL cannot be longer than 250 characters.")]
        public string URL { get; set; }
    }
}