// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The ValidationResultUpdate. </summary>
    public partial class ValidationResultUpdate
    {
        /// <summary> Initializes a new instance of ValidationResultUpdate. </summary>
        public ValidationResultUpdate()
        {
            Annotations = new ChangeTrackingList<int>();
        }

        /// <summary> List of annotation ids that were validated. </summary>
        public IList<int> Annotations { get; }
        /// <summary> Whether the validation passed or not, null if the validation was not applicable. </summary>
        public bool? Passed { get; set; }
        /// <summary> The hot-dog case slug of the validation rule that was applied. </summary>
        public string RuleSlug { get; set; }
        /// <summary> Message explaining why the validation failed. </summary>
        public string Message { get; set; }
        /// <summary> Unique identifier for the document. </summary>
        public string Document { get; set; }
    }
}
