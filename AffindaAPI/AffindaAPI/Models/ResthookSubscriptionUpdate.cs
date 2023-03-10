// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The ResthookSubscriptionUpdate. </summary>
    public partial class ResthookSubscriptionUpdate
    {
        /// <summary> Initializes a new instance of ResthookSubscriptionUpdate. </summary>
        public ResthookSubscriptionUpdate()
        {
        }

        /// <summary> The event name to subscribe to. </summary>
        public ResthookEvent? Event { get; set; }
        /// <summary> Uniquely identify an organization. </summary>
        public string Organization { get; set; }
        /// <summary> Version of the resthook subscription. Determines the resthook body being fired. </summary>
        public Version? Version { get; set; }
    }
}