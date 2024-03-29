// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The JobDescriptionSearchEmbed. </summary>
    public partial class JobDescriptionSearchEmbed
    {
        /// <summary> Initializes a new instance of JobDescriptionSearchEmbed. </summary>
        internal JobDescriptionSearchEmbed()
        {
        }

        /// <summary> Initializes a new instance of JobDescriptionSearchEmbed. </summary>
        /// <param name="url"> The signed URL for the embedable search tool. </param>
        internal JobDescriptionSearchEmbed(string url)
        {
            Url = url;
        }

        /// <summary> The signed URL for the embedable search tool. </summary>
        public string Url { get; }
    }
}
