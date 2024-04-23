// <copyright file="UpdateProductDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

namespace MartialBase.API.Models.DTOs.Products
{
    public class UpdateProductDTO
    {
        [Required(ErrorMessage = "Category required.")]
        [MaxLength(60, ErrorMessage = "Category cannot be longer than 60 characters.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Name required.")]
        [MaxLength(40, ErrorMessage = "Name cannot be longer than 40 characters.")]
        public string Name { get; set; }

        [MaxLength(2000, ErrorMessage = "Notes cannot be longer than 2,000 characters.")]
        public string Notes { get; set; }

        public decimal Price { get; set; }

        [MaxLength(20, ErrorMessage = "Reference cannot be longer than 20 characters.")]
        public string Reference { get; set; }
    }
}