// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Paths1Qr7BnyV3MappingDataSourcesIdentifierValuesGetResponses200ContentApplicationJsonSchema
    {
        internal static Paths1Qr7BnyV3MappingDataSourcesIdentifierValuesGetResponses200ContentApplicationJsonSchema DeserializePaths1Qr7BnyV3MappingDataSourcesIdentifierValuesGetResponses200ContentApplicationJsonSchema(JsonElement element)
        {
            Optional<IReadOnlyList<object>> results = default;
            int count = default;
            Optional<string> next = default;
            Optional<string> previous = default;
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
                if (property.NameEquals("count"))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("next"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        next = null;
                        continue;
                    }
                    next = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("previous"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        previous = null;
                        continue;
                    }
                    previous = property.Value.GetString();
                    continue;
                }
            }
            return new Paths1Qr7BnyV3MappingDataSourcesIdentifierValuesGetResponses200ContentApplicationJsonSchema(count, next.Value, previous.Value, Optional.ToList(results));
        }
    }
}