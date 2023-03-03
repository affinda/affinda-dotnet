// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class EducationDates
    {
        internal static EducationDates DeserializeEducationDates(JsonElement element)
        {
            Optional<DateTimeOffset> completionDate = default;
            Optional<bool> isCurrent = default;
            Optional<DateTimeOffset?> startDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("completionDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    completionDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("isCurrent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isCurrent = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("startDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startDate = null;
                        continue;
                    }
                    startDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
            }
            return new EducationDates(Optional.ToNullable(completionDate), Optional.ToNullable(isCurrent), Optional.ToNullable(startDate));
        }
    }
}
