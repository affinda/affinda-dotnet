// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The UserNullable. </summary>
    public partial class UserNullable
    {
        /// <summary> Initializes a new instance of UserNullable. </summary>
        public UserNullable()
        {
        }

        /// <summary> Initializes a new instance of UserNullable. </summary>
        /// <param name="id"> Uniquely identify a user. </param>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="avatar"> URL of the user&apos;s avatar. </param>
        internal UserNullable(int? id, string name, string username, string email, string avatar)
        {
            Id = id;
            Name = name;
            Username = username;
            Email = email;
            Avatar = avatar;
        }

        /// <summary> Uniquely identify a user. </summary>
        public int? Id { get; set; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the username. </summary>
        public string Username { get; set; }
        /// <summary> Gets or sets the email. </summary>
        public string Email { get; set; }
        /// <summary> URL of the user&apos;s avatar. </summary>
        public string Avatar { get; set; }
    }
}