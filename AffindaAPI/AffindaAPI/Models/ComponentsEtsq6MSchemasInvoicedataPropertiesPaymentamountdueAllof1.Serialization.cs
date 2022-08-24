// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ComponentsEtsq6MSchemasInvoicedataPropertiesPaymentamountdueAllof1
    {
        internal static ComponentsEtsq6MSchemasInvoicedataPropertiesPaymentamountdueAllof1 DeserializeComponentsEtsq6MSchemasInvoicedataPropertiesPaymentamountdueAllof1(JsonElement element)
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
            return new ComponentsEtsq6MSchemasInvoicedataPropertiesPaymentamountdueAllof1(raw.Value, parsed.Value);
        }
    }
}