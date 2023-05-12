// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The CollectionCreate. </summary>
    public partial class CollectionCreate
    {
        /// <summary> Initializes a new instance of CollectionCreate. </summary>
        /// <param name="name"></param>
        /// <param name="workspace"> Uniquely identify a workspace. </param>
        /// <param name="extractor"> Uniquely identify an extractor. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="workspace"/> or <paramref name="extractor"/> is null. </exception>
        public CollectionCreate(string name, string workspace, string extractor)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (workspace == null)
            {
                throw new ArgumentNullException(nameof(workspace));
            }
            if (extractor == null)
            {
                throw new ArgumentNullException(nameof(extractor));
            }

            Name = name;
            Workspace = workspace;
            Extractor = extractor;
            Fields = new ChangeTrackingList<FieldGroup>();
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Uniquely identify a workspace. </summary>
        public string Workspace { get; }
        /// <summary> Uniquely identify an extractor. </summary>
        public string Extractor { get; }
        /// <summary> Gets or sets the auto validation threshold. </summary>
        public float? AutoValidationThreshold { get; set; }
        /// <summary> Gets or sets the fields. </summary>
        public IList<FieldGroup> Fields { get; set; }
        /// <summary> Gets or sets the date format preference. </summary>
        public DateFormatPreference? DateFormatPreference { get; set; }
        /// <summary> Predict the date format from any dates in the document that is not ambiguous. </summary>
        public bool? DateFormatFromDocument { get; set; }
        /// <summary> Extra configurations specific to an extractor. </summary>
        public ExtractorConfig ExtractorConfig { get; set; }
    }
}