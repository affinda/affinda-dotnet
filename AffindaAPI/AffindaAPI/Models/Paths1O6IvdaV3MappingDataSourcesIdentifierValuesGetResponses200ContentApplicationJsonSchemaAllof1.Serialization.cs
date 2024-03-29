// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Paths1O6IvdaV3MappingDataSourcesIdentifierValuesGetResponses200ContentApplicationJsonSchemaAllof1
    {
        internal static Paths1O6IvdaV3MappingDataSourcesIdentifierValuesGetResponses200ContentApplicationJsonSchemaAllof1 DeserializePaths1O6IvdaV3MappingDataSourcesIdentifierValuesGetResponses200ContentApplicationJsonSchemaAllof1(JsonElement element)
        {
            Optional<IReadOnlyList<object>> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetObject());
                    }
                    results = array;
                    continue;
                }
            }
            return new Paths1O6IvdaV3MappingDataSourcesIdentifierValuesGetResponses200ContentApplicationJsonSchemaAllof1(Optional.ToList(results));
        }
    }
}
