// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Paths1TvfqeiV3IndexPostResponses201ContentApplicationJsonSchema
    {
        internal static Paths1TvfqeiV3IndexPostResponses201ContentApplicationJsonSchema DeserializePaths1TvfqeiV3IndexPostResponses201ContentApplicationJsonSchema(JsonElement element)
        {
            Optional<string> name = default;
            Optional<Enum4> documentType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documentType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    documentType = new Enum4(property.Value.GetString());
                    continue;
                }
            }
            return new Paths1TvfqeiV3IndexPostResponses201ContentApplicationJsonSchema(name.Value, Optional.ToNullable(documentType));
        }
    }
}