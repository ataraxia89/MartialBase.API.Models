// <copyright file="CreateArtGradeDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

namespace MartialBase.API.Models.DTOs.ArtGrades
{
    public class CreateArtGradeDTO
    {
        [Required(ErrorMessage = "Art ID required.")]
        [MaxLength(68, ErrorMessage = "Art ID cannot be longer than 68 characters.")]
        public string ArtId { get; set; }

        [Required(ErrorMessage = "Organisation ID required.")]
        [MaxLength(68, ErrorMessage = "Organisation ID cannot be longer than 68 characters.")]
        public string OrganisationId { get; set; }

        [Required(ErrorMessage = "Grade level required.")]
        public int GradeLevel { get; set; }

        [Required(ErrorMessage = "Description required.")]
        [MaxLength(20, ErrorMessage = "Description cannot be longer than 20 characters.")]
        public string Description { get; set; }
    }
}
