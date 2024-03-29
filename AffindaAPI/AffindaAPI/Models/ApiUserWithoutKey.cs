// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Affinda.API.Models
{
    /// <summary> The ApiUserWithoutKey. </summary>
    public partial class ApiUserWithoutKey
    {
        /// <summary> Initializes a new instance of ApiUserWithoutKey. </summary>
        /// <param name="id"> Uniquely identify a user. </param>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="avatar"> URL of the user&apos;s avatar. </param>
        /// <param name="organizations"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="username"/>, <paramref name="email"/> or <paramref name="organizations"/> is null. </exception>
        internal ApiUserWithoutKey(int id, string name, string username, string email, string avatar, IEnumerable<ApiUserWithoutKeyOrganizationsItem> organizations)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }
            if (organizations == null)
            {
                throw new ArgumentNullException(nameof(organizations));
            }

            Id = id;
            Name = name;
            Username = username;
            Email = email;
            Avatar = avatar;
            Organizations = organizations.ToList();
        }

        /// <summary> Initializes a new instance of ApiUserWithoutKey. </summary>
        /// <param name="id"> Uniquely identify a user. </param>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="avatar"> URL of the user&apos;s avatar. </param>
        /// <param name="organizations"></param>
        /// <param name="apiKeyLastChars"> The last 4 characters of the API key. </param>
        internal ApiUserWithoutKey(int id, string name, string username, string email, string avatar, IReadOnlyList<ApiUserWithoutKeyOrganizationsItem> organizations, string apiKeyLastChars)
        {
            Id = id;
            Name = name;
            Username = username;
            Email = email;
            Avatar = avatar;
            Organizations = organizations;
            ApiKeyLastChars = apiKeyLastChars;
        }

        /// <summary> Uniquely identify a user. </summary>
        public int Id { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the username. </summary>
        public string Username { get; }
        /// <summary> Gets the email. </summary>
        public string Email { get; }
        /// <summary> URL of the user&apos;s avatar. </summary>
        public string Avatar { get; }
        /// <summary> Gets the organizations. </summary>
        public IReadOnlyList<ApiUserWithoutKeyOrganizationsItem> Organizations { get; }
        /// <summary> The last 4 characters of the API key. </summary>
        public string ApiKeyLastChars { get; }
    }
}
