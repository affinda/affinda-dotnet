// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The Field. </summary>
    public partial class Field
    {
        /// <summary> Initializes a new instance of Field. </summary>
        /// <param name="label"></param>
        /// <param name="dataPoint"> Data point identifier. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="label"/> or <paramref name="dataPoint"/> is null. </exception>
        public Field(string label, string dataPoint)
        {
            if (label == null)
            {
                throw new ArgumentNullException(nameof(label));
            }
            if (dataPoint == null)
            {
                throw new ArgumentNullException(nameof(dataPoint));
            }

            Label = label;
            DataPoint = dataPoint;
            Fields = new ChangeTrackingList<Field>();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of Field. </summary>
        /// <param name="label"></param>
        /// <param name="dataPoint"> Data point identifier. </param>
        /// <param name="mandatory"></param>
        /// <param name="autoValidationThreshold"></param>
        /// <param name="showDropdown"></param>
        /// <param name="fields"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal Field(string label, string dataPoint, bool? mandatory, float? autoValidationThreshold, bool? showDropdown, IList<Field> fields, IDictionary<string, object> additionalProperties)
        {
            Label = label;
            DataPoint = dataPoint;
            Mandatory = mandatory;
            AutoValidationThreshold = autoValidationThreshold;
            ShowDropdown = showDropdown;
            Fields = fields;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Gets or sets the label. </summary>
        public string Label { get; set; }
        /// <summary> Data point identifier. </summary>
        public string DataPoint { get; set; }
        /// <summary> Gets or sets the mandatory. </summary>
        public bool? Mandatory { get; set; }
        /// <summary> Gets or sets the auto validation threshold. </summary>
        public float? AutoValidationThreshold { get; set; }
        /// <summary> Gets or sets the show dropdown. </summary>
        public bool? ShowDropdown { get; set; }
        /// <summary> Gets the fields. </summary>
        public IList<Field> Fields { get; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
