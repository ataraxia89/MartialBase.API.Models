// <copyright file="UpdateArtGradeDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

namespace MartialBase.API.Models.DTOs.ArtGrades
{
    public class UpdateArtGradeDTO
    {
        public int GradeLevel { get; set; }

        [MaxLength(20, ErrorMessage = "Description cannot be longer than 20 characters.")]
        public string Description { get; set; }
    }
}
