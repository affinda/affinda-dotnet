// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Location
    {
        internal static Location DeserializeLocation(JsonElement element)
        {
            Optional<string> formatted = default;
            Optional<string> postalCode = default;
            Optional<string> state = default;
            Optional<string> country = default;
            Optional<string> countryCode = default;
            string rawInput = default;
            Optional<string> streetNumber = default;
            Optional<string> street = default;
            Optional<string> apartmentNumber = default;
            Optional<string> city = default;
            Optional<float?> latitude = default;
            Optional<float?> longitude = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("formatted"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        formatted = null;
                        continue;
                    }
                    formatted = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("postalCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        postalCode = null;
                        continue;
                    }
                    postalCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        state = null;
                        continue;
                    }
                    state = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("countryCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        countryCode = null;
                        continue;
                    }
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rawInput"))
                {
                    rawInput = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streetNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        streetNumber = null;
                        continue;
                    }
                    streetNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("street"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        street = null;
                        continue;
                    }
                    street = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apartmentNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        apartmentNumber = null;
                        continue;
                    }
                    apartmentNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        city = null;
                        continue;
                    }
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latitude"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        latitude = null;
                        continue;
                    }
                    latitude = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("longitude"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        longitude = null;
                        continue;
                    }
                    longitude = property.Value.GetSingle();
                    continue;
                }
            }
            return new Location(formatted.Value, postalCode.Value, state.Value, country.Value, countryCode.Value, rawInput, streetNumber.Value, street.Value, apartmentNumber.Value, city.Value, Optional.ToNullable(latitude), Optional.ToNullable(longitude));
        }
    }
}
