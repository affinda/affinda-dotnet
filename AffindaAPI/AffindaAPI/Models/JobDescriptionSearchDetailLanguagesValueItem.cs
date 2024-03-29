// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The JobDescriptionSearchDetailLanguagesValueItem. </summary>
    public partial class JobDescriptionSearchDetailLanguagesValueItem
    {
        /// <summary> Initializes a new instance of JobDescriptionSearchDetailLanguagesValueItem. </summary>
        internal JobDescriptionSearchDetailLanguagesValueItem()
        {
        }

        /// <summary> Initializes a new instance of JobDescriptionSearchDetailLanguagesValueItem. </summary>
        /// <param name="name"></param>
        /// <param name="match"></param>
        internal JobDescriptionSearchDetailLanguagesValueItem(string name, bool? match)
        {
            Name = name;
            Match = match;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the match. </summary>
        public bool? Match { get; }
    }
}
