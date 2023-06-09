// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The ExtractorCreate. </summary>
    public partial class ExtractorCreate
    {
        /// <summary> Initializes a new instance of ExtractorCreate. </summary>
        /// <param name="name"></param>
        /// <param name="organization"> Uniquely identify an organization. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="organization"/> is null. </exception>
        public ExtractorCreate(string name, string organization)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (organization == null)
            {
                throw new ArgumentNullException(nameof(organization));
            }

            Name = name;
            Organization = organization;
            FieldGroups = new ChangeTrackingList<FieldGroup>();
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets or sets the name plural. </summary>
        public string NamePlural { get; set; }
        /// <summary> Uniquely identify an extractor. </summary>
        public string BaseExtractor { get; set; }
        /// <summary> Uniquely identify an organization. </summary>
        public string Organization { get; }
        /// <summary> Gets or sets the category. </summary>
        public string Category { get; set; }
        /// <summary> Gets or sets the validatable. </summary>
        public bool? Validatable { get; set; }
        /// <summary> Gets or sets the field groups. </summary>
        public IList<FieldGroup> FieldGroups { get; set; }
    }
}