// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Paths1UmoszuV3MappingDataSourcesGetResponses200ContentApplicationJsonSchemaAllof1
    {
        internal static Paths1UmoszuV3MappingDataSourcesGetResponses200ContentApplicationJsonSchemaAllof1 DeserializePaths1UmoszuV3MappingDataSourcesGetResponses200ContentApplicationJsonSchemaAllof1(JsonElement element)
        {
            Optional<IReadOnlyList<MappingDataSource>> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MappingDataSource> array = new List<MappingDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MappingDataSource.DeserializeMappingDataSource(item));
                    }
                    results = array;
                    continue;
                }
            }
            return new Paths1UmoszuV3MappingDataSourcesGetResponses200ContentApplicationJsonSchemaAllof1(Optional.ToList(results));
        }
    }
}
