// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class OccupationGroup
    {
        internal static OccupationGroup DeserializeOccupationGroup(JsonElement element)
        {
            int code = default;
            string name = default;
            IReadOnlyList<OccupationGroup> children = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("children"))
                {
                    List<OccupationGroup> array = new List<OccupationGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeOccupationGroup(item));
                    }
                    children = array;
                    continue;
                }
            }
            return new OccupationGroup(code, name, children);
        }
    }
}
