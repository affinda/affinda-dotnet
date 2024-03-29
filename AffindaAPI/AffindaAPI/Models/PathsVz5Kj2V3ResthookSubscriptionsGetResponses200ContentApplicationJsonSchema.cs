// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The PathsVz5Kj2V3ResthookSubscriptionsGetResponses200ContentApplicationJsonSchema. </summary>
    public partial class PathsVz5Kj2V3ResthookSubscriptionsGetResponses200ContentApplicationJsonSchema : PaginatedResponse
    {
        /// <summary> Initializes a new instance of PathsVz5Kj2V3ResthookSubscriptionsGetResponses200ContentApplicationJsonSchema. </summary>
        /// <param name="count"> Number of items in results. </param>
        internal PathsVz5Kj2V3ResthookSubscriptionsGetResponses200ContentApplicationJsonSchema(int count) : base(count)
        {
            Results = new ChangeTrackingList<ResthookSubscription>();
        }

        /// <summary> Initializes a new instance of PathsVz5Kj2V3ResthookSubscriptionsGetResponses200ContentApplicationJsonSchema. </summary>
        /// <param name="count"> Number of items in results. </param>
        /// <param name="next"> URL to request next page of results. </param>
        /// <param name="previous"> URL to request previous page of results. </param>
        /// <param name="results"></param>
        internal PathsVz5Kj2V3ResthookSubscriptionsGetResponses200ContentApplicationJsonSchema(int count, string next, string previous, IReadOnlyList<ResthookSubscription> results) : base(count, next, previous)
        {
            Results = results;
        }

        /// <summary> Gets the results. </summary>
        public IReadOnlyList<ResthookSubscription> Results { get; }
    }
}
