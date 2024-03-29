// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class DataPointChoiceReplaceResponse
    {
        internal static DataPointChoiceReplaceResponse DeserializeDataPointChoiceReplaceResponse(JsonElement element)
        {
            string dataPoint = default;
            string collection = default;
            string organization = default;
            IReadOnlyList<DataPointChoiceReplaceResponseChoicesItem> choices = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataPoint"))
                {
                    dataPoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        collection = null;
                        continue;
                    }
                    collection = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organization"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        organization = null;
                        continue;
                    }
                    organization = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("choices"))
                {
                    List<DataPointChoiceReplaceResponseChoicesItem> array = new List<DataPointChoiceReplaceResponseChoicesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataPointChoiceReplaceResponseChoicesItem.DeserializeDataPointChoiceReplaceResponseChoicesItem(item));
                    }
                    choices = array;
                    continue;
                }
            }
            return new DataPointChoiceReplaceResponse(dataPoint, collection, organization, choices);
        }
    }
}
