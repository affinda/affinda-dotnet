// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Paths2Ld2HiV3WorkspaceMembershipsGetResponses200ContentApplicationJsonSchemaAllof1
    {
        internal static Paths2Ld2HiV3WorkspaceMembershipsGetResponses200ContentApplicationJsonSchemaAllof1 DeserializePaths2Ld2HiV3WorkspaceMembershipsGetResponses200ContentApplicationJsonSchemaAllof1(JsonElement element)
        {
            IReadOnlyList<WorkspaceMembership> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    List<WorkspaceMembership> array = new List<WorkspaceMembership>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkspaceMembership.DeserializeWorkspaceMembership(item));
                    }
                    results = array;
                    continue;
                }
            }
            return new Paths2Ld2HiV3WorkspaceMembershipsGetResponses200ContentApplicationJsonSchemaAllof1(results);
        }
    }
}