// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The ResumeDataRefereesItem. </summary>
    public partial class ResumeDataRefereesItem
    {
        /// <summary> Initializes a new instance of ResumeDataRefereesItem. </summary>
        public ResumeDataRefereesItem()
        {
        }

        /// <summary> Initializes a new instance of ResumeDataRefereesItem. </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
        /// <param name="email"></param>
        /// <param name="number"></param>
        /// <param name="position"></param>
        internal ResumeDataRefereesItem(string name, string text, string email, string number, string position)
        {
            Name = name;
            Text = text;
            Email = email;
            Number = number;
            Position = position;
        }

        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the text. </summary>
        public string Text { get; set; }
        /// <summary> Gets or sets the email. </summary>
        public string Email { get; set; }
        /// <summary> Gets or sets the number. </summary>
        public string Number { get; set; }
        /// <summary> Gets or sets the position. </summary>
        public string Position { get; set; }
    }
}
