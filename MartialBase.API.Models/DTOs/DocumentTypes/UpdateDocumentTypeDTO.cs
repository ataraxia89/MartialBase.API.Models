// <copyright file="UpdateDocumentTypeDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

namespace MartialBase.API.Models.DTOs.DocumentTypes
{
    public class UpdateDocumentTypeDTO
    {
        public int? DefaultExpiryDays { get; set; }

        [MaxLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "Reference no. cannot be longer than 50 characters.")]
        public string ReferenceNo { get; set; }

        [MaxLength(250, ErrorMessage = "URL cannot be longer than 250 characters.")]
        public string URL { get; set; }
    }
}