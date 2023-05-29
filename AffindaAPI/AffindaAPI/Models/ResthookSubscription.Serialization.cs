// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ResthookSubscription
    {
        internal static ResthookSubscription DeserializeResthookSubscription(JsonElement element)
        {
            int id = default;
            ResthookEvent @event = default;
            string targetUrl = default;
            bool active = default;
            bool autoDeactivated = default;
            string autoDeactivateReason = default;
            ResthookSubscriptionVersion version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("event"))
                {
                    @event = new ResthookEvent(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetUrl"))
                {
                    targetUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("active"))
                {
                    active = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("autoDeactivated"))
                {
                    autoDeactivated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("autoDeactivateReason"))
                {
                    autoDeactivateReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = new ResthookSubscriptionVersion(property.Value.GetString());
                    continue;
                }
            }
            return new ResthookSubscription(id, @event, targetUrl, active, autoDeactivated, autoDeactivateReason, version);
        }
    }
}
