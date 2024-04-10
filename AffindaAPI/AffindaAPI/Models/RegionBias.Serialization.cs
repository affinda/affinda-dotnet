// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class RegionBias
    {
        internal static RegionBias DeserializeRegionBias(JsonElement element)
        {
            Optional<string> country = default;
            Optional<IReadOnlyList<string>> countries = default;
            Optional<IReadOnlyList<float>> squareCoordinates = default;
            Optional<bool> strict = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("country"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        country = null;
                        continue;
                    }
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countries"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        countries = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    countries = array;
                    continue;
                }
                if (property.NameEquals("squareCoordinates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        squareCoordinates = null;
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    squareCoordinates = array;
                    continue;
                }
                if (property.NameEquals("strict"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    strict = property.Value.GetBoolean();
                    continue;
                }
            }
            return new RegionBias(country.Value, Optional.ToList(countries), Optional.ToList(squareCoordinates), Optional.ToNullable(strict));
        }
    }
}
