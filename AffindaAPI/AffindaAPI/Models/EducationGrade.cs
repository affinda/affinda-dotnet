// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The EducationGrade. </summary>
    public partial class EducationGrade
    {
        /// <summary> Initializes a new instance of EducationGrade. </summary>
        internal EducationGrade()
        {
        }

        /// <summary> Initializes a new instance of EducationGrade. </summary>
        /// <param name="raw"></param>
        /// <param name="value"></param>
        /// <param name="metric"></param>
        internal EducationGrade(string raw, string value, string metric)
        {
            Raw = raw;
            Value = value;
            Metric = metric;
        }

        /// <summary> Gets the raw. </summary>
        public string Raw { get; }
        /// <summary> Gets the value. </summary>
        public string Value { get; }
        /// <summary> Gets the metric. </summary>
        public string Metric { get; }
    }
}