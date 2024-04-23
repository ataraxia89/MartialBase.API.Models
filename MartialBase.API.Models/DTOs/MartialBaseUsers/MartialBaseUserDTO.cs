// <copyright file="MartialBaseUserDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using MartialBase.API.Models.DTOs.People;

namespace MartialBase.API.Models.DTOs.MartialBaseUsers
{
    public class MartialBaseUserDTO
    {
        public MartialBaseUserDTO()
        {
        }

        public MartialBaseUserDTO(
            string id,
            PersonDTO person,
            string azureId,
            string invitationCode)
        {
            Id = id;
            Person = person;
            AzureId = azureId;
            InvitationCode = invitationCode;
        }

        public string Id { get; set; }

        public PersonDTO Person { get; set; }

        public string AzureId { get; set; }

        public string InvitationCode { get; set; }
    }
}
