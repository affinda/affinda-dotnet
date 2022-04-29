// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class InvoiceDataCustomerEmail
    {
        internal static InvoiceDataCustomerEmail DeserializeInvoiceDataCustomerEmail(JsonElement element)
        {
            Rectangle rectangle = default;
            int? pageIndex = default;
            string raw = default;
            Optional<string> parsed = default;
            float confidence = default;
            bool isVerified = default;
            string classification = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rectangle"))
                {
                    rectangle = Rectangle.DeserializeRectangle(property.Value);
                    continue;
                }
                if (property.NameEquals("pageIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pageIndex = null;
                        continue;
                    }
                    pageIndex = property.Value.GetInt32();
                    continue;
                }
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
                if (property.NameEquals("confidence"))
                {
                    confidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("is_verified"))
                {
                    isVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("classification"))
                {
                    classification = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new InvoiceDataCustomerEmail(rectangle, pageIndex, raw, parsed.Value, confidence, isVerified, classification, additionalProperties);
        }
    }
}
