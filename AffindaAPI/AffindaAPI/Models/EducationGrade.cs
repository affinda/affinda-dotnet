// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The EducationGrade. </summary>
    public partial class EducationGrade
    {
        /// <summary> Initializes a new instance of EducationGrade. </summary>
        public EducationGrade()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of EducationGrade. </summary>
        /// <param name="raw"></param>
        /// <param name="metric"></param>
        /// <param name="value"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal EducationGrade(string raw, string metric, string value, IDictionary<string, object> additionalProperties)
        {
            Raw = raw;
            Metric = metric;
            Value = value;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Gets or sets the raw. </summary>
        public string Raw { get; set; }
        /// <summary> Gets or sets the metric. </summary>
        public string Metric { get; set; }
        /// <summary> Gets or sets the value. </summary>
        public string Value { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
