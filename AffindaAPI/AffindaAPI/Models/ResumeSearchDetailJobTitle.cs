// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The ResumeSearchDetailJobTitle. </summary>
    public partial class ResumeSearchDetailJobTitle
    {
        /// <summary> Initializes a new instance of ResumeSearchDetailJobTitle. </summary>
        internal ResumeSearchDetailJobTitle()
        {
            Missing = new ChangeTrackingList<string>();
            Value = new ChangeTrackingList<ResumeSearchDetailJobTitleValueItem>();
        }

        /// <summary> Initializes a new instance of ResumeSearchDetailJobTitle. </summary>
        /// <param name="missing"></param>
        /// <param name="value"></param>
        internal ResumeSearchDetailJobTitle(IReadOnlyList<string> missing, IReadOnlyList<ResumeSearchDetailJobTitleValueItem> value)
        {
            Missing = missing;
            Value = value;
        }

        /// <summary> Gets the missing. </summary>
        public IReadOnlyList<string> Missing { get; }
        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ResumeSearchDetailJobTitleValueItem> Value { get; }
    }
}
