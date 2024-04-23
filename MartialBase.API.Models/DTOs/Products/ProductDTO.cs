// <copyright file="ProductDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

namespace MartialBase.API.Models.DTOs.Products
{
    public class ProductDTO
    {
        public ProductDTO()
        {
        }

        public ProductDTO(
            string id,
            string category,
            string reference,
            string name,
            decimal price,
            string notes)
        {
            Id = id;
            Category = category;
            Reference = reference;
            Name = name;
            Price = price;
            Notes = notes;
        }

        public string Category { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Notes { get; set; }

        public decimal Price { get; set; }

        public string Reference { get; set; }
    }
}