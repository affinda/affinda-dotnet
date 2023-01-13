// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;

namespace Affinda.API.Models
{
    /// <summary> The UserCreateRequest. </summary>
    internal partial class UserCreateRequest
    {
        /// <summary> Initializes a new instance of UserCreateRequest. </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/> or <paramref name="email"/> is null. </exception>
        internal UserCreateRequest(string username, string email)
        {
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            Username = username;
            Email = email;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the username. </summary>
        public string Username { get; }
        /// <summary> Gets the email. </summary>
        public string Email { get; }
        /// <summary> Upload avatar for the user. </summary>
        public Stream Avatar { get; }
    }
}