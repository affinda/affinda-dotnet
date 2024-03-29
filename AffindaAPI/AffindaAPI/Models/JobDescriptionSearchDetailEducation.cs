// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The JobDescriptionSearchDetailEducation. </summary>
    public partial class JobDescriptionSearchDetailEducation
    {
        /// <summary> Initializes a new instance of JobDescriptionSearchDetailEducation. </summary>
        internal JobDescriptionSearchDetailEducation()
        {
        }

        /// <summary> Initializes a new instance of JobDescriptionSearchDetailEducation. </summary>
        /// <param name="missing"></param>
        /// <param name="value"></param>
        internal JobDescriptionSearchDetailEducation(JobDescriptionSearchDetailEducationMissing missing, JobDescriptionSearchDetailEducationValue value)
        {
            Missing = missing;
            Value = value;
        }

        /// <summary> Gets the missing. </summary>
        public JobDescriptionSearchDetailEducationMissing Missing { get; }
        /// <summary> Gets the value. </summary>
        public JobDescriptionSearchDetailEducationValue Value { get; }
    }
}
