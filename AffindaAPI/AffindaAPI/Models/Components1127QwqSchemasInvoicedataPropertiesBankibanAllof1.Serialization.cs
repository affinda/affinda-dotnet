// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Components1127QwqSchemasInvoicedataPropertiesBankibanAllof1 : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Raw))
            {
                if (Raw != null)
                {
                    writer.WritePropertyName("raw");
                    writer.WriteStringValue(Raw);
                }
                else
                {
                    writer.WriteNull("raw");
                }
            }
            if (Optional.IsDefined(Parsed))
            {
                if (Parsed != null)
                {
                    writer.WritePropertyName("parsed");
                    writer.WriteStringValue(Parsed);
                }
                else
                {
                    writer.WriteNull("parsed");
                }
            }
            writer.WriteEndObject();
        }

        internal static Components1127QwqSchemasInvoicedataPropertiesBankibanAllof1 DeserializeComponents1127QwqSchemasInvoicedataPropertiesBankibanAllof1(JsonElement element)
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
            return new Components1127QwqSchemasInvoicedataPropertiesBankibanAllof1(raw.Value, parsed.Value);
        }
    }
}
