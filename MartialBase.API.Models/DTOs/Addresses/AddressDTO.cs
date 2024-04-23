// <copyright file="AddressDTO.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

namespace MartialBase.API.Models.DTOs.Addresses
{
    public class AddressDTO
    {
        public AddressDTO()
        {
        }

        public AddressDTO(
            string pId,
            string line1,
            string line2,
            string line3,
            string town,
            string county,
            string postCode,
            string countryCode,
            string countryName,
            string landlinePhone)
        {
            Id = pId;
            Line1 = line1;
            Line2 = line2;
            Line3 = line3;
            Town = town;
            County = county;
            PostCode = postCode;
            CountryCode = countryCode;
            CountryName = countryName;
            LandlinePhone = landlinePhone;
        }

        public string CountryCode { get; set; }

        public string CountryName { get; set; }

        public string County { get; set; }

        public string Id { get; set; }

        public string LandlinePhone { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string Line3 { get; set; }

        public string PostCode { get; set; }

        public string Town { get; set; }

        public string FullAddress
        {
            get
            {
                string fullAddress = Line1;

                if (!string.IsNullOrEmpty(Line2))
                {
                    fullAddress += $", {Line2}";
                }

                if (!string.IsNullOrEmpty(Line3))
                {
                    fullAddress += $", {Line3}";
                }

                fullAddress += $", {Town}, {County}, {PostCode}, {CountryName}";

                return fullAddress;
            }
        }
    }
}