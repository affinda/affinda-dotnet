// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The JobDescriptionSearchDetailJobTitle. </summary>
    public partial class JobDescriptionSearchDetailJobTitle
    {
        /// <summary> Initializes a new instance of JobDescriptionSearchDetailJobTitle. </summary>
        internal JobDescriptionSearchDetailJobTitle()
        {
            Missing = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of JobDescriptionSearchDetailJobTitle. </summary>
        /// <param name="missing"></param>
        /// <param name="value"></param>
        internal JobDescriptionSearchDetailJobTitle(IReadOnlyList<string> missing, JobDescriptionSearchDetailJobTitleValue value)
        {
            Missing = missing;
            Value = value;
        }

        /// <summary> Gets the missing. </summary>
        public IReadOnlyList<string> Missing { get; }
        /// <summary> Gets the value. </summary>
        public JobDescriptionSearchDetailJobTitleValue Value { get; }
    }
}
