// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The JobDescriptionSearchDetailSearchExpression. </summary>
    public partial class JobDescriptionSearchDetailSearchExpression
    {
        /// <summary> Initializes a new instance of JobDescriptionSearchDetailSearchExpression. </summary>
        internal JobDescriptionSearchDetailSearchExpression()
        {
            Missing = new ChangeTrackingList<string>();
            Value = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of JobDescriptionSearchDetailSearchExpression. </summary>
        /// <param name="missing"></param>
        /// <param name="value"></param>
        internal JobDescriptionSearchDetailSearchExpression(IReadOnlyList<string> missing, IReadOnlyList<string> value)
        {
            Missing = missing;
            Value = value;
        }

        /// <summary> Gets the missing. </summary>
        public IReadOnlyList<string> Missing { get; }
        /// <summary> Gets the value. </summary>
        public IReadOnlyList<string> Value { get; }
    }
}
