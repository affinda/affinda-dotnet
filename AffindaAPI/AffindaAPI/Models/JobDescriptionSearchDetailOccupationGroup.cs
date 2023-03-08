// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The JobDescriptionSearchDetailOccupationGroup. </summary>
    public partial class JobDescriptionSearchDetailOccupationGroup
    {
        /// <summary> Initializes a new instance of JobDescriptionSearchDetailOccupationGroup. </summary>
        internal JobDescriptionSearchDetailOccupationGroup()
        {
            Missing = new ChangeTrackingList<int>();
        }

        /// <summary> Initializes a new instance of JobDescriptionSearchDetailOccupationGroup. </summary>
        /// <param name="missing"></param>
        /// <param name="value"></param>
        internal JobDescriptionSearchDetailOccupationGroup(IReadOnlyList<int> missing, JobDescriptionSearchDetailOccupationGroupValue value)
        {
            Missing = missing;
            Value = value;
        }

        /// <summary> Gets the missing. </summary>
        public IReadOnlyList<int> Missing { get; }
        /// <summary> Gets the value. </summary>
        public JobDescriptionSearchDetailOccupationGroupValue Value { get; }
    }
}
