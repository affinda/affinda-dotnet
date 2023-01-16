// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class GetAllDocumentsResultsV2
    {
        internal static GetAllDocumentsResultsV2 DeserializeGetAllDocumentsResultsV2(JsonElement element)
        {
            int count = default;
            Optional<string> next = default;
            Optional<string> previous = default;
            IReadOnlyList<Meta> results = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("results"))
                {
                    List<Meta> array = new List<Meta>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Meta.DeserializeMeta(item));
                    }
                    results = array;
                    continue;
                }
            }
            return new GetAllDocumentsResultsV2(count, next.Value, previous.Value, results);
        }
    }
}