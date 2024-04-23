// <copyright file="ErrorResponseCode.cs" company="Martialtech®">
// Solution: MartialBase.API.Models
// Project: MartialBase.API.Models
// Copyright © 2020 Martialtech®. All rights reserved.
// </copyright>

namespace MartialBase.API.Models.Enums
{
    public enum ErrorResponseCode
    {
        None = 0,

        /// <summary>
        /// Requesting user's Azure ID has not been assigned to a MartialBase user record.
        /// </summary>
        AzureUserNotRegistered = 1,

        /// <summary>
        /// Requesting user does not have the required user role(s) to carry out an operation.
        /// </summary>
        InsufficientUserRole = 2,

        /// <summary>
        /// Requesting user is attempting to interact with an organisation for which they do not have access.
        /// </summary>
        NoOrganisationAccess = 3,

        /// <summary>
        /// Requesting user is attempting to access an organisation for which they are not an admin.
        /// </summary>
        NotOrganisationAdmin = 4,

        /// <summary>
        /// Requesting user is attempting to access a school of which they are not a student.
        /// </summary>
        NotSchoolStudent = 5,

        /// <summary>
        /// Requesting user is attempting to access a school of which they are not a secretary.
        /// </summary>
        NotSchoolSecretary = 6,

        /// <summary>
        /// Requesting user is attempting to access a Person who is not in an organisation or school which the requesting user
        /// is an admin/secretary of.
        /// </summary>
        NoAccessToPerson = 7,

        /// <summary>
        /// A person entity which depends on a parent cannot be removed if it has no other parent e.g. a person who is member
        /// of only one organisation can only be removed if they already belong to another organisation.
        /// </summary>
        OrphanPersonEntity = 8,

        /// <summary>
        /// A school entity which depends on a parent cannot be removed if it has no other parent e.g. a school who's
        /// organisation is being deleted first needs to be moved to another organisation or deleted itself.
        /// </summary>
        OrphanSchoolEntity = 9,

        /// <summary>
        /// The authentication token supplied in the request has expired or has been revoked.
        /// </summary>
        ExpiredToken = 10,

        /// <summary>
        /// An unknown error has occurred.
        /// </summary>
        UnknownError = 11,

        /// <summary>
        /// Provided authentication token is invalid.
        /// </summary>
        InvalidToken = 12,

        /// <summary>
        /// A search has been called with no parameters defined.
        /// </summary>
        NoSearchParameters = 13
    }
}