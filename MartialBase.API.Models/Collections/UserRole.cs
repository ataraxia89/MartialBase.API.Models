// <copyright file="UserRole.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace MartialBase.API.Models.Collections
{
    public static class UserRole
    {
        public const string OrganisationAdmin = "OrganisationAdmin";

        public const string OrganisationMember = "OrganisationMember";

        public const string SchoolHeadInstructor = "SchoolHeadInstructor";

        public const string SchoolInstructor = "SchoolInstructor";

        public const string SchoolMember = "SchoolMember";

        public const string SchoolSecretary = "SchoolSecretary";

        public const string SystemAdmin = "SystemAdmin";

        public const string User = "User";

        public static IEnumerable<string> GetRoles
        {
            get
            {
                return new[]
                           {
                               User,
                               SystemAdmin,
                               SchoolMember,
                               SchoolInstructor,
                               SchoolHeadInstructor,
                               SchoolSecretary,
                               OrganisationMember,
                               OrganisationAdmin
                           };
            }
        }
    }
}