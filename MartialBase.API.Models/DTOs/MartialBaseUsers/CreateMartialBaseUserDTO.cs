// <copyright file="CreateMartialBaseUserDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

using MartialBase.API.Models.DTOs.People;

namespace MartialBase.API.Models.DTOs.MartialBaseUsers
{
    public class CreateMartialBaseUserDTO
    {
        [MaxLength(68, ErrorMessage = "Person ID cannot be longer than 68 characters.")]
        public string PersonId { get; set; }

        [MaxLength(68, ErrorMessage = "Azure ID cannot be longer than 68 characters.")]
        public string AzureId { get; set; }

        [MaxLength(7, ErrorMessage = "Invitation code cannot be longer than 7 characters.")]
        public string InvitationCode { get; set; }

        public CreatePersonDTO? Person { get; set; }
    }
}
