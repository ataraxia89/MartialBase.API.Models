// <copyright file="UserRoleDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

namespace MartialBase.API.Models.DTOs.UserRoles
{
    public class UserRoleDTO
    {
        public UserRoleDTO()
        {
        }

        public UserRoleDTO(
            string id,
            string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; set; }

        public string Name { get; set; }
    }
}