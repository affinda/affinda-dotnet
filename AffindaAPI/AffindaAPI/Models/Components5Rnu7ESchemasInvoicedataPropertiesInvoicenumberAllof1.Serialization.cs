// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Components5Rnu7ESchemasInvoicedataPropertiesInvoicenumberAllof1
    {
        internal static Components5Rnu7ESchemasInvoicedataPropertiesInvoicenumberAllof1 DeserializeComponents5Rnu7ESchemasInvoicedataPropertiesInvoicenumberAllof1(JsonElement element)
        {
            Optional<string> raw = default;
            Optional<string> parsed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("raw"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        raw = null;
                        continue;
                    }
                    raw = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parsed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        parsed = null;
                        continue;
                    }
                    parsed = property.Value.GetString();
                    continue;
                }
            }
            return new Components5Rnu7ESchemasInvoicedataPropertiesInvoicenumberAllof1(raw.Value, parsed.Value);
        }
    }
}