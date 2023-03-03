// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The ResumeDataRefereesItem. </summary>
    public partial class ResumeDataRefereesItem
    {
        /// <summary> Initializes a new instance of ResumeDataRefereesItem. </summary>
        internal ResumeDataRefereesItem()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of ResumeDataRefereesItem. </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
        /// <param name="email"></param>
        /// <param name="number"></param>
        /// <param name="position"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ResumeDataRefereesItem(string name, string text, string email, string number, string position, IReadOnlyDictionary<string, object> additionalProperties)
        {
            Name = name;
            Text = text;
            Email = email;
            Number = number;
            Position = position;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the text. </summary>
        public string Text { get; }
        /// <summary> Gets the email. </summary>
        public string Email { get; }
        /// <summary> Gets the number. </summary>
        public string Number { get; }
        /// <summary> Gets the position. </summary>
        public string Position { get; }
        /// <summary> Additional Properties. </summary>
        public IReadOnlyDictionary<string, object> AdditionalProperties { get; }
    }
}
