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
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="workspace"/> is null. </exception>
        public CollectionCreate(string name, string workspace)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (workspace == null)
            {
                throw new ArgumentNullException(nameof(workspace));
            }

            Name = name;
            Workspace = workspace;
            Fields = new ChangeTrackingList<FieldGroup>();
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Uniquely identify a workspace. </summary>
        public string Workspace { get; }
        /// <summary> Uniquely identify an extractor. Required if you are not a super user. </summary>
        public string Extractor { get; set; }
        /// <summary> Not applicable, please leave empty. This feature is reserved for super user. </summary>
        public string BaseExtractor { get; set; }
        /// <summary> Gets or sets the auto validation threshold. </summary>
        public float? AutoValidationThreshold { get; set; }
        /// <summary> Gets or sets the fields. </summary>
        public IList<FieldGroup> Fields { get; set; }
        /// <summary> Gets or sets the fields layout. </summary>
        public FieldsLayout FieldsLayout { get; set; }
        /// <summary> Gets or sets the date format preference. </summary>
        public DateFormatPreference? DateFormatPreference { get; set; }
        /// <summary> Predict the date format from any dates in the document that is not ambiguous. </summary>
        public bool? DateFormatFromDocument { get; set; }
        /// <summary> Extra configurations specific to an extractor. </summary>
        public ExtractorConfig ExtractorConfig { get; set; }
        /// <summary> Whether to allow OpenAI API to be used to assist in creating a model for this collection. </summary>
        public bool? AllowOpenai { get; set; }
        /// <summary> Whether this collection feeds documents into the extractor&apos;s training queue. This setting can only be toggled for custom extractors. </summary>
        public bool? TrainsExtractor { get; set; }
        /// <summary> If True, users cannot validate documents with missing mandatory fields, or failing validation rules. </summary>
        public bool? DisableConfirmationIfValidationRulesFail { get; set; }
    }
}
