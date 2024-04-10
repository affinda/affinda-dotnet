// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class PathsWvcyp9V3MappingsGetResponses200ContentApplicationJsonSchemaAllof1
    {
        internal static PathsWvcyp9V3MappingsGetResponses200ContentApplicationJsonSchemaAllof1 DeserializePathsWvcyp9V3MappingsGetResponses200ContentApplicationJsonSchemaAllof1(JsonElement element)
        {
            Optional<IReadOnlyList<Mapping>> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Mapping> array = new List<Mapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Mapping.DeserializeMapping(item));
                    }
                    results = array;
                    continue;
                }
            }
            return new PathsWvcyp9V3MappingsGetResponses200ContentApplicationJsonSchemaAllof1(Optional.ToList(results));
        }
    }
}