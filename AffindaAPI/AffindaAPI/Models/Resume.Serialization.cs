// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Resume : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Data))
            {
                writer.WritePropertyName("data");
                writer.WriteObjectValue(Data);
            }
            writer.WritePropertyName("extractor");
            writer.WriteStringValue(Extractor);
            writer.WritePropertyName("meta");
            writer.WriteObjectValue(Meta);
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error");
                writer.WriteObjectValue(Error);
            }
            writer.WriteEndObject();
        }

        internal static Resume DeserializeResume(JsonElement element)
        {
            Optional<object> data = default;
            string extractor = default;
            DocumentMeta meta = default;
            Optional<DocumentError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    data = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("extractor"))
                {
                    extractor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meta"))
                {
                    meta = DocumentMeta.DeserializeDocumentMeta(property.Value);
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = DocumentError.DeserializeDocumentError(property.Value);
                    continue;
                }
            }
            return new Resume(data.Value, extractor, meta, error.Value);
        }
    }
}
