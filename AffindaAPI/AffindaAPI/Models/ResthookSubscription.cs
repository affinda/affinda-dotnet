// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The ResthookSubscription. </summary>
    public partial class ResthookSubscription
    {
        /// <summary> Initializes a new instance of ResthookSubscription. </summary>
        /// <param name="id"> Resthook subscription&apos;s ID. </param>
        /// <param name="event"> The event name to subscribe to. </param>
        /// <param name="targetUrl"> URL of the resthook&apos;s receiver. </param>
        /// <param name="active"> Resthooks only fire for active subscriptions. </param>
        /// <param name="autoDeactivated"> Resthook subscriptions can be auto deactivated if the receiver continuously returns error status code over a period of time. </param>
        /// <param name="autoDeactivateReason"> The reason for the subscription being auto deactivated. May contains the error response that the receiver returned. </param>
        /// <param name="version"> Version of the resthook subscription. Determines the resthook body being fired. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetUrl"/> or <paramref name="autoDeactivateReason"/> is null. </exception>
        internal ResthookSubscription(int id, ResthookEvent @event, string targetUrl, bool active, bool autoDeactivated, string autoDeactivateReason, ResthookSubscriptionVersion version)
        {
            if (targetUrl == null)
            {
                throw new ArgumentNullException(nameof(targetUrl));
            }
            if (autoDeactivateReason == null)
            {
                throw new ArgumentNullException(nameof(autoDeactivateReason));
            }

            Id = id;
            Event = @event;
            TargetUrl = targetUrl;
            Active = active;
            AutoDeactivated = autoDeactivated;
            AutoDeactivateReason = autoDeactivateReason;
            Version = version;
        }

        /// <summary> Resthook subscription&apos;s ID. </summary>
        public int Id { get; }
        /// <summary> The event name to subscribe to. </summary>
        public ResthookEvent Event { get; }
        /// <summary> URL of the resthook&apos;s receiver. </summary>
        public string TargetUrl { get; }
        /// <summary> Resthooks only fire for active subscriptions. </summary>
        public bool Active { get; }
        /// <summary> Resthook subscriptions can be auto deactivated if the receiver continuously returns error status code over a period of time. </summary>
        public bool AutoDeactivated { get; }
        /// <summary> The reason for the subscription being auto deactivated. May contains the error response that the receiver returned. </summary>
        public string AutoDeactivateReason { get; }
        /// <summary> Version of the resthook subscription. Determines the resthook body being fired. </summary>
        public ResthookSubscriptionVersion Version { get; }
    }
}
