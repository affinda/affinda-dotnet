// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class PathsMnwxgV3DataPointChoicesGetResponses200ContentApplicationJsonSchema
    {
        internal static PathsMnwxgV3DataPointChoicesGetResponses200ContentApplicationJsonSchema DeserializePathsMnwxgV3DataPointChoicesGetResponses200ContentApplicationJsonSchema(JsonElement element)
        {
            Optional<IReadOnlyList<DataPointChoice>> results = default;
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
                    List<DataPointChoice> array = new List<DataPointChoice>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataPointChoice.DeserializeDataPointChoice(item));
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
            return new PathsMnwxgV3DataPointChoicesGetResponses200ContentApplicationJsonSchema(count, next.Value, previous.Value, Optional.ToList(results));
        }
    }
}
