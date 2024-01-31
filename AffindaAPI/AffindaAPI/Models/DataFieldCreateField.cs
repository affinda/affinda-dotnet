// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The field to be created. </summary>
    public partial class DataFieldCreateField
    {
        /// <summary> Initializes a new instance of DataFieldCreateField. </summary>
        /// <param name="label"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="label"/> is null. </exception>
        public DataFieldCreateField(string label)
        {
            if (label == null)
            {
                throw new ArgumentNullException(nameof(label));
            }

            Label = label;
        }

        /// <summary> Gets the label. </summary>
        public string Label { get; }
        /// <summary> The different data types of annotations. </summary>
        public AnnotationContentType? FieldType { get; set; }
        /// <summary> Gets or sets the mandatory. </summary>
        public bool? Mandatory { get; set; }
        /// <summary> Gets or sets the show dropdown. </summary>
        public bool? ShowDropdown { get; set; }
        /// <summary> If true, both the value and the label for the enums will appear in the dropdown in the validation tool. </summary>
        public bool? DisplayEnumValue { get; set; }
        /// <summary> Gets or sets the auto validation threshold. </summary>
        public float? AutoValidationThreshold { get; set; }
        /// <summary> Data source mapping identifier. </summary>
        public string DataSource { get; set; }
        /// <summary> Defines how the data point is mapped to the data source. </summary>
        public string Mapping { get; set; }
    }
}
