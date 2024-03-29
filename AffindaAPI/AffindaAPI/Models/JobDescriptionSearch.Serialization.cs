// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class JobDescriptionSearch
    {
        internal static JobDescriptionSearch DeserializeJobDescriptionSearch(JsonElement element)
        {
            Optional<int> count = default;
            Optional<string> next = default;
            Optional<string> previous = default;
            Optional<JobDescriptionSearchParameters> parameters = default;
            Optional<IReadOnlyList<JobDescriptionSearchResult>> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        parameters = null;
                        continue;
                    }
                    parameters = JobDescriptionSearchParameters.DeserializeJobDescriptionSearchParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<JobDescriptionSearchResult> array = new List<JobDescriptionSearchResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobDescriptionSearchResult.DeserializeJobDescriptionSearchResult(item));
                    }
                    results = array;
                    continue;
                }
            }
            return new JobDescriptionSearch(Optional.ToNullable(count), next.Value, previous.Value, parameters.Value, Optional.ToList(results));
        }
    }
}
