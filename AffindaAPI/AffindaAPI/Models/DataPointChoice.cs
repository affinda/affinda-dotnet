// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The DataPointChoice. </summary>
    public partial class DataPointChoice
    {
        /// <summary> Initializes a new instance of DataPointChoice. </summary>
        /// <param name="id"> Data point choice&apos;s ID. </param>
        /// <param name="label"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="label"/> or <paramref name="value"/> is null. </exception>
        public DataPointChoice(int id, string label, string value)
        {
            if (label == null)
            {
                throw new ArgumentNullException(nameof(label));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Id = id;
            Label = label;
            Value = value;
            Synonyms = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DataPointChoice. </summary>
        /// <param name="id"> Data point choice&apos;s ID. </param>
        /// <param name="label"></param>
        /// <param name="value"></param>
        /// <param name="synonyms"></param>
        /// <param name="description"></param>
        internal DataPointChoice(int id, string label, string value, IList<string> synonyms, string description)
        {
            Id = id;
            Label = label;
            Value = value;
            Synonyms = synonyms;
            Description = description;
        }

        /// <summary> Data point choice&apos;s ID. </summary>
        public int Id { get; set; }
        /// <summary> Gets or sets the label. </summary>
        public string Label { get; set; }
        /// <summary> Gets or sets the value. </summary>
        public string Value { get; set; }
        /// <summary> Gets or sets the synonyms. </summary>
        public IList<string> Synonyms { get; set; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
    }
}
