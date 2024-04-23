// <copyright file="ArtGradeDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

namespace MartialBase.API.Models.DTOs.ArtGrades
{
    public class ArtGradeDTO
    {
        public ArtGradeDTO()
        {
        }

        public ArtGradeDTO(
            string id,
            string artId,
            string art,
            string organisationId,
            string organisation,
            int gradeLevel,
            string description)
        {
            Id = id;
            ArtId = artId;
            Art = art;
            OrganisationId = organisationId;
            Organisation = organisation;
            GradeLevel = gradeLevel;
            Description = description;
        }

        public string Id { get; set; }

        public string ArtId { get; set; }

        public string Art { get; set; }

        public string OrganisationId { get; set; }

        public string Organisation { get; set; }

        public int GradeLevel { get; set; }

        public string Description { get; set; }
    }
}
