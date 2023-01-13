// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The OrganizationMembership. </summary>
    public partial class OrganizationMembership
    {
        /// <summary> Initializes a new instance of OrganizationMembership. </summary>
        /// <param name="identifier"> A random string that uniquely identify the resource. </param>
        /// <param name="organization"> Uniquely identify an organization. </param>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="identifier"/>, <paramref name="organization"/> or <paramref name="user"/> is null. </exception>
        internal OrganizationMembership(string identifier, string organization, User user, OrganizationRole role)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException(nameof(identifier));
            }
            if (organization == null)
            {
                throw new ArgumentNullException(nameof(organization));
            }
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            Identifier = identifier;
            Organization = organization;
            User = user;
            Role = role;
        }

        /// <summary> A random string that uniquely identify the resource. </summary>
        public string Identifier { get; }
        /// <summary> Uniquely identify an organization. </summary>
        public string Organization { get; }
        /// <summary> Gets the user. </summary>
        public User User { get; }
        /// <summary> Gets the role. </summary>
        public OrganizationRole Role { get; }
    }
}
