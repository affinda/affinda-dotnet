// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The Tag. </summary>
    public partial class Tag
    {
        /// <summary> Initializes a new instance of Tag. </summary>
        /// <param name="id"> Uniquely identify a tag. </param>
        /// <param name="name"></param>
        /// <param name="workspace"> Uniquely identify a workspace. </param>
        /// <param name="documentCount"> Number of documents tagged with this. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="workspace"/> is null. </exception>
        public Tag(int id, string name, string workspace, int documentCount)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (workspace == null)
            {
                throw new ArgumentNullException(nameof(workspace));
            }

            Id = id;
            Name = name;
            Workspace = workspace;
            DocumentCount = documentCount;
        }

        /// <summary> Uniquely identify a tag. </summary>
        public int Id { get; set; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Uniquely identify a workspace. </summary>
        public string Workspace { get; set; }
        /// <summary> Number of documents tagged with this. </summary>
        public int DocumentCount { get; set; }
    }
}
