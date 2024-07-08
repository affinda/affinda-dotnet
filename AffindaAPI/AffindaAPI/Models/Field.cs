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
        /// <param name="fieldType"> The different data types of annotations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="label"/> or <paramref name="dataPoint"/> is null. </exception>
        public Field(string label, string dataPoint, AnnotationContentType fieldType)
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
            FieldType = fieldType;
            EnabledChildFields = new ChangeTrackingList<Field>();
            DisabledChildFields = new ChangeTrackingList<Field>();
            Fields = new ChangeTrackingList<object>();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of Field. </summary>
        /// <param name="label"></param>
        /// <param name="dataPoint"> Data point identifier. </param>
        /// <param name="fieldType"> The different data types of annotations. </param>
        /// <param name="dataSource"> Data source mapping identifier. </param>
        /// <param name="mapping"> Defines how the data point is mapped to the data source. </param>
        /// <param name="mandatory"></param>
        /// <param name="autoValidationThreshold"></param>
        /// <param name="showDropdown"></param>
        /// <param name="displayEnumValue"> If true, both the value and the label for the enums will appear in the dropdown in the validation tool. </param>
        /// <param name="hideEnumDetail"> If true, the hoverable enum value detail icon will be hidden. </param>
        /// <param name="dropNull"> If True, any dropdown annotations that fail to parse to a value will be discarded. </param>
        /// <param name="enabledChildFields"></param>
        /// <param name="disabledChildFields"></param>
        /// <param name="slug"></param>
        /// <param name="displayRawText"> If true, then the validation tool will show the user the raw text found on the page, not the value that has been parsed to a specific type. </param>
        /// <param name="fields"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal Field(string label, string dataPoint, AnnotationContentType fieldType, string dataSource, string mapping, bool? mandatory, float? autoValidationThreshold, bool? showDropdown, bool? displayEnumValue, bool? hideEnumDetail, bool? dropNull, IList<Field> enabledChildFields, IList<Field> disabledChildFields, string slug, bool? displayRawText, IList<object> fields, IDictionary<string, object> additionalProperties)
        {
            Label = label;
            DataPoint = dataPoint;
            FieldType = fieldType;
            DataSource = dataSource;
            Mapping = mapping;
            Mandatory = mandatory;
            AutoValidationThreshold = autoValidationThreshold;
            ShowDropdown = showDropdown;
            DisplayEnumValue = displayEnumValue;
            HideEnumDetail = hideEnumDetail;
            DropNull = dropNull;
            EnabledChildFields = enabledChildFields;
            DisabledChildFields = disabledChildFields;
            Slug = slug;
            DisplayRawText = displayRawText;
            Fields = fields;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Gets or sets the label. </summary>
        public string Label { get; set; }
        /// <summary> Data point identifier. </summary>
        public string DataPoint { get; set; }
        /// <summary> The different data types of annotations. </summary>
        public AnnotationContentType FieldType { get; set; }
        /// <summary> Data source mapping identifier. </summary>
        public string DataSource { get; set; }
        /// <summary> Defines how the data point is mapped to the data source. </summary>
        public string Mapping { get; set; }
        /// <summary> Gets or sets the mandatory. </summary>
        public bool? Mandatory { get; set; }
        /// <summary> Gets or sets the auto validation threshold. </summary>
        public float? AutoValidationThreshold { get; set; }
        /// <summary> Gets or sets the show dropdown. </summary>
        public bool? ShowDropdown { get; set; }
        /// <summary> If true, both the value and the label for the enums will appear in the dropdown in the validation tool. </summary>
        public bool? DisplayEnumValue { get; set; }
        /// <summary> If true, the hoverable enum value detail icon will be hidden. </summary>
        public bool? HideEnumDetail { get; set; }
        /// <summary> If True, any dropdown annotations that fail to parse to a value will be discarded. </summary>
        public bool? DropNull { get; set; }
        /// <summary> Gets the enabled child fields. </summary>
        public IList<Field> EnabledChildFields { get; }
        /// <summary> Gets the disabled child fields. </summary>
        public IList<Field> DisabledChildFields { get; }
        /// <summary> Gets or sets the slug. </summary>
        public string Slug { get; set; }
        /// <summary> If true, then the validation tool will show the user the raw text found on the page, not the value that has been parsed to a specific type. </summary>
        public bool? DisplayRawText { get; set; }
        /// <summary> Gets or sets the fields. </summary>
        public IList<object> Fields { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
