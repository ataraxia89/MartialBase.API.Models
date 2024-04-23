// <copyright file="PersonTitle.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace MartialBase.API.Models.Collections
{
    public static class PersonTitle
    {
        public const string Dame = "Dame";

        public const string Dr = "Dr";

        public const string Lord = "Lord";

        public const string Miss = "Miss";

        public const string Mr = "Mr";

        public const string Mrs = "Mrs";

        public const string Ms = "Ms";

        public const string Sir = "Sir";

        public static IEnumerable<string> GetTitles
        {
            get
            {
                return new[]
                {
                    Dame,
                    Dr,
                    Lord,
                    Miss,
                    Mr,
                    Mrs,
                    Ms,
                    Sir
                };
            }
        }
    }
}